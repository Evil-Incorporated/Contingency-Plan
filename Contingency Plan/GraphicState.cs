using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Contingency_Plan
{
	public class GraphicState
	{
		public static int STATE_RADII = 50;

		public Point location;

		public string stateName;

		public bool final = false;
		public bool initial = false;

		public int zOrder;

		public List<Arrow> exitArrowList { get; set; }
		public List<Arrow> entryArrowList { get; set; }


        public GraphicState(Point location, string stateName)
        {
            this.location = location;
			this.stateName = stateName;
			exitArrowList = new List<Arrow>();
			entryArrowList = new List<Arrow>();
			
			zOrder = 0;
        }

		public static GraphicState getStateSelected(List<GraphicState> stateArrayList, Point point, ref Point deviation)
		{
			GraphicState selectedState = getStateSelected(stateArrayList, point);
			if (selectedState != null)
			{
				deviation.X = point.X - selectedState.location.X;
				deviation.Y = point.Y - selectedState.location.Y;
			}
			return selectedState;
		}

		public static GraphicState getStateSelected(List<GraphicState> stateArrayList, Point point)
		{
			List<GraphicState> candidateStates = new List<GraphicState>();
			foreach (GraphicState state in stateArrayList)
			{
				if (Math.Sqrt(Math.Pow(point.X - state.location.X, 2) + Math.Pow(point.Y - state.location.Y, 2)) <= STATE_RADII)
					candidateStates.Add(state);
			}
			int maxZOrder = -1;
			GraphicState selectedState = null;
			foreach(GraphicState state in candidateStates)
			{
				if (state.zOrder > maxZOrder)
				{
					selectedState = state;
					maxZOrder = selectedState.zOrder;
				}
			}
			return selectedState;
		}

		public static void drawState(GraphicState state, Graphics g, SolidBrush stateBrush, Pen stateBorderPen, Font stateNameFont, SolidBrush stateNameBrush, StringFormat stateNameStringFormat, Rectangle rect)
		{
			g.FillEllipse(stateBrush, rect);
			g.DrawEllipse(stateBorderPen, rect.X + 3, rect.Y + 3, rect.Width - 6, rect.Height - 6);
			if(state.final)
				g.DrawEllipse(stateBorderPen, rect.X + 12, rect.Y + 12, rect.Width - 24, rect.Height - 24);
			g.DrawString(state.stateName, stateNameFont, stateNameBrush, rect, stateNameStringFormat);
			if (state.initial)
			{
				stateBorderPen.Width = GraphicState.STATE_RADII;
				stateBorderPen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
				g.DrawLine(stateBorderPen, state.location.X - GraphicState.STATE_RADII - 25, state.location.Y, state.location.X-GraphicState.STATE_RADII - 23, state.location.Y);
				stateBorderPen.Width = 3;
            }
		}

		public static void drawState(GraphicState state, Graphics g, SolidBrush stateBrush, Pen stateBorderPen, Font stateNameFont, SolidBrush stateNameBrush, StringFormat stateNameStringFormat)
		{
			Rectangle rect = new Rectangle(state.location.X - STATE_RADII, state.location.Y - STATE_RADII, 2 * STATE_RADII, 2 * STATE_RADII);
			drawState(state, g, stateBrush, stateBorderPen, stateNameFont, stateNameBrush, stateNameStringFormat, rect);
		}

		public static void setZOrderOfStateOnTop(GraphicState state, List<GraphicState> stateArrayList)
		{
			int maxZOrder = -1;
			state.zOrder = -1;
			foreach(GraphicState s in stateArrayList)
			{
				if(s != state && Math.Sqrt(Math.Pow(s.location.X - state.location.X, 2) + Math.Pow(s.location.Y - state.location.Y, 2)) <= 2 * STATE_RADII && s.zOrder > maxZOrder)
					maxZOrder = s.zOrder;
			}

			state.zOrder = maxZOrder + 1;
		}
	}
}
