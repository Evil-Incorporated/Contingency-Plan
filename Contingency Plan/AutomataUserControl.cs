using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Contingency_Plan
{
    public partial class AutomataUserControl : UserControl
    {
		private Timer dragDropTimer = new Timer();

		private List<GraphicState> stateArrayList;
		private List<Arrow> allArrowList;

		private Arrow currentTransitionArrow = null;

        private int num = 0;

		public Bitmap backBuffer;

		private Point deviation;
		private Point dragPoint;

		private GraphicState selectedState = null;
		private GraphicState hoverState = null;
		private GraphicState propertyChangingState = null;
	    private GraphicState fromState = null;
		private GraphicState topMostState = null;
		private GraphicState leftMostState = null;
		private GraphicState rightMostState = null;
		private GraphicState botMostState = null;

		private Size initialBackBufferSize;

		private Font stateNameFont;

		private StringFormat stateNameStringFormat;

        private SolidBrush stateNameBrush;
        private SolidBrush stateBrush;
		private SolidBrush backGroundBrush;

		private Pen stateBorderPen;
		private Pen stateBorderPen2;

        public AutomataUserControl()
        {
            InitializeComponent();
            panel2.Paint += new PaintEventHandler(Panel2_Paint);
            panel2.MouseClick += new MouseEventHandler(panel2_Click);
			panel2.MouseMove += new MouseEventHandler(Panel2_MouseMove);
			panel2.MouseDown += new MouseEventHandler(Panel2_MouseDown);
			panel2.MouseUp += new MouseEventHandler(Panel2_MouseUp);

			dragDropTimer.Tick += new EventHandler(DragDropTimer_Tick);
			dragDropTimer.Interval = 30;

			stateNameBrush = new SolidBrush(Color.White);
			stateBrush = new SolidBrush(Color.FromArgb(55,71,79));
			backGroundBrush = new SolidBrush(panel2.BackColor);
			stateBorderPen = new Pen(Color.FromArgb(0, 128, 192), 3);
			//stateBorderPen.EndCap = LineCap.ArrowAnchor;
			stateBorderPen2 = new Pen(Color.Red, 3);
			stateArrayList = new List<GraphicState>();
			allArrowList = new List<Arrow>();
			stateNameFont = new Font("New Times Roman", 15, FontStyle.Bold);
			//stateNameFont.
			stateNameStringFormat = new StringFormat();
			deviation = new Point();
			dragPoint = new Point();
			stateNameStringFormat.Alignment = StringAlignment.Center;
			stateNameStringFormat.LineAlignment = StringAlignment.Center;
			//stateNameStringFormat.

		}

		public GraphicState getInitialState()
		{
			foreach(GraphicState state in stateArrayList)
			{
				if (state.initial)
					return state;
			}
			return null;
		}

		private void DragDropTimer_Tick(object sender, EventArgs e)
		{
			dragDropTimer.Stop();
			if(selectedState != null)
				moveSelectedState();
		}

		private void Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (attributeEditorRadioButton.Checked && e.Button == MouseButtons.Left)
			{
				selectedState = GraphicState.getStateSelected(stateArrayList, new Point(e.X - panel2.AutoScrollPosition.X, e.Y - panel2.AutoScrollPosition.Y), ref deviation);
			}
		}

		

		private void Panel2_MouseUp(object sender, MouseEventArgs e)
		{
			if (attributeEditorRadioButton.Checked && e.Button == MouseButtons.Left)
			{
				if (selectedState != null)
				{
					updateDraggedState();
					GraphicState.setZOrderOfStateOnTop(selectedState, stateArrayList);
					updateEdgeStates();
					shirnkCanvasAsRequired();
				}

				selectedState = null;
			}
		}

		private void updateDraggedState()
		{
			int x = selectedState.location.X;
			int y = selectedState.location.Y;
			bool shouldProcess = enlargeBackBufferAsRequired(ref x, ref y); 
			selectedState.location.X = x;
			selectedState.location.Y = y;
			if (shouldProcess)
			{
				Graphics g = Graphics.FromImage(backBuffer);
				g.SmoothingMode = SmoothingMode.AntiAlias;

				GraphicState.drawState(selectedState, g, stateBrush, stateBorderPen, stateNameFont, stateNameBrush, stateNameStringFormat);

				foreach(GraphicState state in stateArrayList)
				{
					foreach (Arrow arrow in state.exitArrowList)
						arrow.updateArrowPosition(state, null);
					foreach (Arrow arrow in state.entryArrowList)
						arrow.updateArrowPosition(null, state);
				}

				reDrawBackBuffer();

				panel2.Invalidate();

			}
		}

		private void shirnkCanvasAsRequired()
		{
			if (initialBackBufferSize.Width < backBuffer.Size.Width || initialBackBufferSize.Height < backBuffer.Size.Height)
			{
				int x = leftMostState.location.X - GraphicState.STATE_RADII;
				int y = topMostState.location.Y - GraphicState.STATE_RADII;
				int width = rightMostState.location.X + GraphicState.STATE_RADII - x;
				int height = botMostState.location.Y + GraphicState.STATE_RADII - y;
				int xWidth, yWidth;
				if (y + height == backBuffer.Height || initialBackBufferSize.Height == backBuffer.Size.Height)
					yWidth = 0;
				else
					yWidth = (y + height > initialBackBufferSize.Height) ? y + height : initialBackBufferSize.Height;
				if (x + width == backBuffer.Width || initialBackBufferSize.Width == backBuffer.Size.Width)
					xWidth = 0;
				else
					xWidth = (x + width > initialBackBufferSize.Width) ? x + width : initialBackBufferSize.Width;
				if (xWidth != 0 || yWidth != 0)
				{
					if (yWidth == 0)
						yWidth = backBuffer.Size.Height;
					if (xWidth == 0)
						xWidth = backBuffer.Size.Width;
					Bitmap newBackBuffer = new Bitmap(xWidth, yWidth);
					Graphics g = Graphics.FromImage(newBackBuffer);
					g.DrawImage(backBuffer, 0, 0);
					backBuffer.Dispose();
					backBuffer = newBackBuffer;
					panel2.AutoScrollMinSize = new Size(backBuffer.Size.Width , backBuffer.Size.Height );
					panel2.Invalidate();
				}
			}
		}

		private void Panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if (selectedState != null)
			{
				dragPoint.X = e.X - panel2.AutoScrollPosition.X;
				dragPoint.Y = e.Y - panel2.AutoScrollPosition.Y;


				if (!dragDropTimer.Enabled)
					dragDropTimer.Start();
			}
			else if (attributeEditorRadioButton.Checked && !transitionTokenTextField.Visible)
				getSelectedTransition(e.X - panel2.AutoScrollPosition.X, e.Y - panel2.AutoScrollPosition.Y);
			else if (deleterRadioButton.Checked)
			{
				GraphicState prevHoverState = hoverState;
				Arrow prevTransitionArrow = currentTransitionArrow;
				hoverState = GraphicState.getStateSelected(stateArrayList, new Point(e.X - panel2.AutoScrollPosition.X, e.Y - panel2.AutoScrollPosition.Y));
				getCurrentTransitionArrow(e.X - panel2.AutoScrollPosition.X, e.Y - panel2.AutoScrollPosition.Y);
				if(hoverState!= prevHoverState || currentTransitionArrow != prevTransitionArrow)
				{
					reDrawBackBuffer();
					panel2.Invalidate();
				}
			}
		}

		private void getSelectedTransition(int x, int y)
		{
			if (getCurrentTransitionArrow(x, y))
			{
				reDrawBackBuffer();
				panel2.Invalidate();
			}
		}

		private bool getCurrentTransitionArrow(int x, int y)
		{
			bool reDraw = false;
			currentTransitionArrow = null;
			foreach (Arrow arrow in allArrowList)
			{
				if (arrow.textRect.Contains(x, y) && GraphicState.getStateSelected(stateArrayList, new Point(x, y)) == null)
				{
					currentTransitionArrow = arrow;
					if (arrow.isHoverOver)
						break;
					arrow.isHoverOver = true;
					reDraw = true;
					break;
				}
			}
			foreach (Arrow arrow in allArrowList)
			{
				if (arrow.isHoverOver && arrow != currentTransitionArrow)
				{
					reDraw = true;
					arrow.isHoverOver = false;
				}
			}
			return reDraw;
		}

		private void moveSelectedState()
		{

			selectedState.location.X = dragPoint.X - deviation.X;
			selectedState.location.Y = dragPoint.Y - deviation.Y;

			foreach(Arrow arrow in selectedState.exitArrowList)
				arrow.updateArrowPosition(selectedState, null);
			foreach (Arrow arrow in selectedState.entryArrowList)
				arrow.updateArrowPosition(null, selectedState);

			reDrawBackBuffer();

			panel2.Invalidate();
		}


		private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
			e.Graphics.TranslateTransform(panel2.AutoScrollPosition.X, panel2.AutoScrollPosition.Y);
            Graphics g = e.Graphics;
			if (backBuffer == null)
			{
				backBuffer = new Bitmap(panel2.Size.Width, panel2.Size.Height);
				initialBackBufferSize = new Size(backBuffer.Size.Width, backBuffer.Size.Height);
			}
			g.DrawImage(backBuffer, 0, 0);
		}

        private void panel2_Click(object sebder, MouseEventArgs e)
        {
			if (transitionTokenTextField.Visible)
				getTextFieldData();
			if (stateCreatorRadioButton.Checked && e.Button == MouseButtons.Left)
				createNewState(e.X - panel2.AutoScrollPosition.X, e.Y - panel2.AutoScrollPosition.Y);
			else if (transitionCreatorRadioButton.Checked && e.Button == MouseButtons.Left)
				selectTransitionState(e.X - panel2.AutoScrollPosition.X, e.Y - panel2.AutoScrollPosition.Y);
			else if (attributeEditorRadioButton.Checked && e.Button == MouseButtons.Left && currentTransitionArrow != null)
				initializeTokenTextField();
			else if (deleterRadioButton.Checked && e.Button == MouseButtons.Left)
				deleteItem();
			else if (e.Button == MouseButtons.Right && attributeEditorRadioButton.Checked)
			{
				if ((propertyChangingState = GraphicState.getStateSelected(stateArrayList, new Point(e.X - panel2.AutoScrollPosition.X, e.Y - panel2.AutoScrollPosition.Y))) != null)
				{
					if (propertyChangingState.final)
						finalStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
					else
						finalStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
					if (propertyChangingState.initial)
						initialStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
					else
						initialStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
					StateContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
				}
			}
		}

		private void selectTransitionState(int x, int y)
		{
			GraphicState s = GraphicState.getStateSelected(stateArrayList, new Point(x, y));
			Graphics g = Graphics.FromImage(backBuffer);
			g.SmoothingMode = SmoothingMode.AntiAlias;
			if (s != null)
			{
				if (fromState == null)
				{
					fromState = s;
					GraphicState.drawState(s, g, stateBrush, stateBorderPen2, stateNameFont, stateNameBrush, stateNameStringFormat);
				}
				else
				{
					GraphicState.drawState(fromState, g, stateBrush, stateBorderPen, stateNameFont, stateNameBrush, stateNameStringFormat);
					if (shouldCreateNewTransition(s))
					{
						Arrow arrow = new Arrow(fromState, s);
						allArrowList.Add(arrow);
						currentTransitionArrow = arrow;
						initializeTokenTextField();
						fromState.exitArrowList.Add(arrow);
						s.entryArrowList.Add(arrow);
						reDrawBackBuffer();
					}
					fromState = null;
				}
				panel2.Invalidate();
			}
			else if(fromState!=null)
			{
				GraphicState.drawState(fromState, g, stateBrush, stateBorderPen, stateNameFont, stateNameBrush, stateNameStringFormat);
				fromState = null;
				panel2.Invalidate();
			}
		}

		private void initializeTokenTextField()
		{
			transitionTokenTextField.Location = new Point(currentTransitionArrow.textRect.X + currentTransitionArrow.textRect.Width / 2 - transitionTokenTextField.Size.Width / 2 + panel2.AutoScrollPosition.X, currentTransitionArrow.textRect.Y + currentTransitionArrow.textRect.Height / 2 - transitionTokenTextField.Size.Height / 2 + panel2.AutoScrollPosition.Y);
			transitionTokenTextField.Text = "";
            transitionTokenTextField.SelectedText = currentTransitionArrow.transitionToken;
			transitionTokenTextField.Visible = true;
			transitionTokenTextField.Focus();
		}

		private bool shouldCreateNewTransition(GraphicState toState)
		{
			foreach(Arrow exitArrow in fromState.exitArrowList)
			{
				foreach (Arrow entryArrow in toState.entryArrowList)
					if (exitArrow == entryArrow)
						return false;
			}
			return true;
		}

		private void createNewState(int x, int y)
		{
			enlargeBackBufferAsRequired(ref x, ref y);
			Graphics g = Graphics.FromImage(backBuffer);
			g.SmoothingMode = SmoothingMode.AntiAlias;

			GraphicState s = new GraphicState(new Point(x, y), "q" + num);
			stateArrayList.Add(s);
			GraphicState.setZOrderOfStateOnTop(s, stateArrayList);

			GraphicState.drawState(s, g, stateBrush, stateBorderPen, stateNameFont, stateNameBrush, stateNameStringFormat);

			num++;

			updateEdgeStates();


			panel2.Invalidate();
		}

		private void updateEdgeStates()
		{
			if (topMostState == null)
				topMostState = leftMostState = rightMostState = botMostState = (GraphicState) stateArrayList[0];
			foreach(GraphicState state in stateArrayList)
			{
				if (state.location.X < leftMostState.location.X)
					leftMostState = state;
				if (state.location.Y < topMostState.location.Y)
					topMostState = state;
				if (state.location.X > rightMostState.location.X)
					rightMostState = state;
				if (state.location.Y > botMostState.location.Y)
					botMostState = state;

			}
		}


		private bool enlargeBackBufferAsRequired(ref int x, ref int y)
		{
			int top = GraphicState.STATE_RADII - y;
			int left = GraphicState.STATE_RADII - x;
			int right = x + GraphicState.STATE_RADII - backBuffer.Size.Width;
			int bot = y + GraphicState.STATE_RADII - backBuffer.Size.Height;
			Boolean resizeRequested = true;
			if (y - GraphicState.STATE_RADII <= 0)
			{
				if (x - GraphicState.STATE_RADII <= 0)
				{
					enlargeBackBuffer(top, left, 0, 0);
					x = GraphicState.STATE_RADII;
				}
				else if (x + GraphicState.STATE_RADII > backBuffer.Size.Width)
					enlargeBackBuffer(top, 0, right, 0);
				else
					enlargeBackBuffer(top, 0, 0, 0);
				y = GraphicState.STATE_RADII;
			}
			else if (y + GraphicState.STATE_RADII > backBuffer.Size.Height)
			{
				if (x - GraphicState.STATE_RADII <= 0)
				{
					enlargeBackBuffer(0, left, 0, bot);
					x = GraphicState.STATE_RADII;
				}
				else if (x + 50 > backBuffer.Size.Width)
					enlargeBackBuffer(0, 0, right, bot);
				else
					enlargeBackBuffer(0, 0, 0, bot);
			}
			else if (x - GraphicState.STATE_RADII <= 0)
			{
				enlargeBackBuffer(0, left, 0, 0);
				x = GraphicState.STATE_RADII;
			}
			else if (x + GraphicState.STATE_RADII > backBuffer.Size.Width)
				enlargeBackBuffer(0, 0, right, 0);
			else
				resizeRequested = false;
			return resizeRequested;
		}

		private void enlargeBackBuffer(int top, int left, int right, int bottom)
		{
			Point p = padStateLocations(left, top);
			Bitmap newBackBuffer = new Bitmap(right + backBuffer.Width + p.X, bottom + backBuffer.Height + p.Y);
            Graphics bbGraphics = Graphics.FromImage(newBackBuffer);
			bbGraphics.DrawImage(backBuffer, left, top);

			backBuffer.Dispose();
			backBuffer = newBackBuffer;
			panel2.AutoScrollMinSize = new Size(backBuffer.Size.Width, backBuffer.Size.Height);
		}
		private Point padStateLocations(int left, int top)
		{
			Point p = new Point(0,0);
			if(left!=0 || top!=0)
				foreach(GraphicState state in stateArrayList)
				{
					state.location.X += left;
					state.location.Y += top;
					if ((p.X == 0 && state.location.X + GraphicState.STATE_RADII > backBuffer.Width) || (p.X != 0 && state.location.X + GraphicState.STATE_RADII - backBuffer.Width > p.X))
						p.X = state.location.X + GraphicState.STATE_RADII - backBuffer.Width;
					if ((p.Y== 0 && state.location.Y + GraphicState.STATE_RADII > backBuffer.Height) || (p.Y != 0 && state.location.Y + GraphicState.STATE_RADII - backBuffer.Height > p.Y))
						p.Y = state.location.Y + GraphicState.STATE_RADII - backBuffer.Height;
				}
			return p;
		}
		private void reDrawBackBuffer()
		{
			Graphics g = Graphics.FromImage(backBuffer);
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.FillRectangle(backGroundBrush, 0, 0, backBuffer.Width, backBuffer.Height);
			stateArrayList.Sort((x, y) =>  x.zOrder.CompareTo(y.zOrder));
			foreach (GraphicState state in stateArrayList)
			{
				foreach(Arrow arrow in state.exitArrowList)
				{
					Pen arrowPen = (arrow.isHoverOver) ? stateBorderPen2 : stateBorderPen;
					if (arrow.bezierPoint1.X == -1)
						g.DrawLine(arrowPen, arrow.start, arrow.end);
					else
						g.DrawBezier(arrowPen, arrow.start, arrow.bezierPoint1, arrow.bezierPoint2, arrow.end);
					g.DrawLine(arrowPen, arrow.arrowTipPoint1, arrow.end);
					g.DrawLine(arrowPen, arrow.arrowTipPoint2, arrow.end);
					
					g.FillRectangle(backGroundBrush, arrow.textRect.X+GraphicState.STATE_RADII - arrow.transitionToken.Length*15/2, arrow.textRect.Y+GraphicState.STATE_RADII - stateNameFont.Height/2, arrow.transitionToken.Length*15, stateNameFont.Height);
					g.DrawString(arrow.transitionToken, stateNameFont, stateNameBrush, arrow.textRect, stateNameStringFormat);
				}

			}
			foreach (GraphicState state in stateArrayList)
			{
				if(state!=selectedState)
				GraphicState.drawState(state, g, stateBrush, (state == hoverState)?stateBorderPen2: stateBorderPen, stateNameFont, stateNameBrush, stateNameStringFormat);
			}
			if(selectedState!=null)
				GraphicState.drawState(selectedState, g, stateBrush, stateBorderPen, stateNameFont, stateNameBrush, stateNameStringFormat);

		}
		private void TransitionTokenTextField_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				getTextFieldData();
                e.Handled = true;
			}
        }
		private void getTextFieldData()
		{
			transitionTokenTextField.Visible = false;
			if (currentTransitionArrow != null)
			{
				if (transitionTokenTextField.Text.CompareTo("") != 0)
					currentTransitionArrow.transitionToken = transitionTokenTextField.Text;
				else if(currentTransitionArrow.transitionToken.CompareTo("") == 0)
					currentTransitionArrow.transitionToken = "λ";
				transitionTokenTextField.Text = "";
				currentTransitionArrow.isHoverOver = false;
				currentTransitionArrow = null;
				reDrawBackBuffer();
				panel2.Invalidate();
			}
		}

		private void deleteItem()
		{
			if (hoverState != null)
			{
				foreach(GraphicState state in stateArrayList)
				{
					if(state!= hoverState)
					{
						foreach (Arrow arrow in state.exitArrowList)
						{
							if (arrow.toState == hoverState) {
								state.exitArrowList.Remove(arrow);
								allArrowList.Remove(arrow);
								break;
                            }
						}
					}
				}
				foreach(Arrow arrow in hoverState.exitArrowList)
					allArrowList.Remove(arrow);
				stateArrayList.Remove(hoverState);
				if(hoverState == botMostState)
					botMostState = new GraphicState(new Point(0,0),"no name");
				if (hoverState == rightMostState)
					rightMostState = new GraphicState(new Point(0, 0), "no name");
				updateEdgeStates();
				shirnkCanvasAsRequired();
				hoverState = null;
				reDrawBackBuffer();
				panel2.Invalidate();
			}
			else if( currentTransitionArrow != null)
			{
				currentTransitionArrow.fromState.exitArrowList.Remove(currentTransitionArrow);
				currentTransitionArrow.toState.entryArrowList.Remove(currentTransitionArrow);
				allArrowList.Remove(currentTransitionArrow);
				currentTransitionArrow = null;
				reDrawBackBuffer();
				panel2.Invalidate();
			}
		}

		private void initialStateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (initialStateToolStripMenuItem.Checked)
				initialStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
			else
				initialStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			foreach (GraphicState state in stateArrayList)
			{
				if (state != propertyChangingState)
					state.initial = false;
				else
					state.initial = !state.initial;
			}
			reDrawBackBuffer();
			panel2.Invalidate();
		}

		private void finalStateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (finalStateToolStripMenuItem.Checked)
				finalStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
			else
				finalStateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			propertyChangingState.final = !propertyChangingState.final;
			reDrawBackBuffer();
			panel2.Invalidate();
		}
	}
}
