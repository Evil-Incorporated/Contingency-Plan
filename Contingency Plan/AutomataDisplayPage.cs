using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Speech.Synthesis;

namespace Contingency_Plan
{
	public partial class AutomataDisplayPage : UserControl
	{
		private SpeechSynthesizer speech;

		public delegate void clickEventHandler(object sender, EventArgs e);

		public event clickEventHandler onUserCloseClick;

		private Bitmap backBuffer;

		private GraphicState currentState;

		private Arrow targetArrow;

		private Pen greenPen;

		private String validationString = "aaaab";

		private String processedString = "";

		private Rectangle displayStringRect;

		//private bool stringProcessed = false;

		private int currStringIndex = 0;

		private Font stateNameFont;

		private StringFormat stateNameStringFormat;

		private SolidBrush stateNameBrush;
		private SolidBrush backGroundBrush;

		public AutomataDisplayPage(GraphicState initialState, Bitmap backBuffer, String validationString)
		{
			InitializeComponent();
			this.currentState = initialState;
			this.backBuffer = backBuffer;
			this.validationString = validationString;
			backBuffer = new Bitmap(backBuffer.Width, backBuffer.Height);
			greenPen = new Pen(Color.FromArgb(0,255,0), 3);
			stateNameBrush = new SolidBrush(Color.White);
			backGroundBrush = new SolidBrush(drawPanel1.BackColor);
			stateNameFont = new Font("New Times Roman", 15, FontStyle.Bold);
			stateNameStringFormat = new StringFormat();
			stateNameStringFormat.Alignment = StringAlignment.Center;
			stateNameStringFormat.LineAlignment = StringAlignment.Center;
			displayStringRect = new Rectangle(0, 0, 0, 0);
			drawPanel1.AutoScrollMinSize = backBuffer.Size;

			speech = new SpeechSynthesizer();
			speech.Rate = -2;
			speech.SetOutputToDefaultAudioDevice();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			onUserCloseClick(sender, e);
		}

		private void DrawPanel1_Paint(object sender, PaintEventArgs e)
		{
			if (displayStringRect.Width == 0)
			{
				displayStringRect = new Rectangle(0, 0, drawPanel1.Width, stateNameFont.Height);
			}
			e.Graphics.TranslateTransform(drawPanel1.AutoScrollPosition.X, drawPanel1.AutoScrollPosition.Y);
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.DrawImage(backBuffer, 0, 0);
			if (targetArrow != null)
			{
				if (targetArrow.bezierPoint1.X == -1)
					g.DrawLine(greenPen, targetArrow.start, targetArrow.end);
				else
					g.DrawBezier(greenPen, targetArrow.start, targetArrow.bezierPoint1, targetArrow.bezierPoint2, targetArrow.end);
				g.DrawLine(greenPen, targetArrow.arrowTipPoint1, targetArrow.end);
				g.DrawLine(greenPen, targetArrow.arrowTipPoint2, targetArrow.end);

				g.FillRectangle(backGroundBrush, targetArrow.textRect.X + GraphicState.STATE_RADII - targetArrow.transitionToken.Length * 15 / 2, targetArrow.textRect.Y + GraphicState.STATE_RADII - stateNameFont.Height / 2, targetArrow.transitionToken.Length * 15, stateNameFont.Height);
				g.DrawString(targetArrow.transitionToken, stateNameFont, stateNameBrush, targetArrow.textRect, stateNameStringFormat);
			}
			if (currentState != null)
			{
				g.DrawEllipse(greenPen, currentState.location.X - GraphicState.STATE_RADII + 3, currentState.location.Y - GraphicState.STATE_RADII + 3, 2 * GraphicState.STATE_RADII - 6, 2 * GraphicState.STATE_RADII - 6);
				if (currentState.initial)
				{
					greenPen.Width = GraphicState.STATE_RADII;
					greenPen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
					g.DrawLine(greenPen, currentState.location.X - GraphicState.STATE_RADII - 25, currentState.location.Y, currentState.location.X - GraphicState.STATE_RADII - 23, currentState.location.Y);
					greenPen.Width = 3;
				}
				if(currentState.final)
					g.DrawEllipse(greenPen, currentState.location.X - GraphicState.STATE_RADII + 12, currentState.location.Y - GraphicState.STATE_RADII + 12, 2 * GraphicState.STATE_RADII - 24, 2 * GraphicState.STATE_RADII - 24);
			}
			g.DrawString("String processed: " + processedString, stateNameFont, stateNameBrush, displayStringRect, stateNameStringFormat);
		}

		private void materialRaisedButton1_Click(object sender, EventArgs e)
		{
			//if(validationString.ElementAt(currStringIndex))
			if (validationString.Length>0)
			{
				targetArrow = null;
				if (currentState != null)
					foreach (Arrow arrow in currentState.exitArrowList)
					{
						foreach (String str in arrow.getDelta())
						{
							if (str.CompareTo("" + validationString[currStringIndex]) == 0)
							{
								targetArrow = arrow;
								break;
							}
						}
						if (targetArrow != null)
							break;
					}
				if (targetArrow != null)
					currentState = targetArrow.toState;
				else
					currentState = null;
				if (currentState == null)
				{
					materialRaisedButton1.Enabled = false;
					displayMessageBox("String not accepted");
				}
				else
				{
					if(materialCheckBox1.Checked)
						speech.Speak(targetArrow.fromState.stateName + " on " + Char.ToUpper(validationString[currStringIndex]) + " goes to " + targetArrow.toState.stateName);
					processedString = processedString + validationString[currStringIndex];
					if (currStringIndex + 1 != validationString.Length)
						currStringIndex++;
					else if (currentState.final)
					{
						materialRaisedButton1.Enabled = false;
						displayMessageBox("String accepted");
					}
					else
					{
						materialRaisedButton1.Enabled = false;
						displayMessageBox("String not accepted");
					}
				}
				drawPanel1.Invalidate();
			}
			

		}

		private void displayMessageBox(String message)
		{
			AutomataMessageBox messageBox = new AutomataMessageBox(message);
			messageBox.StartPosition = FormStartPosition.CenterScreen;
			if (materialCheckBox1.Checked)
				speech.Speak(message);
			messageBox.ShowDialog();
		}
	}
}
