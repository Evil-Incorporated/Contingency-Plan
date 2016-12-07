using System;
using System.Collections.Generic;
using System.Drawing;

namespace Contingency_Plan
{
	public class Arrow
	{
		//LineEquation pathEquation;

		public Point start;
		public Point end;
		public Point bezierPoint1;
		public Point bezierPoint2;
		public Point arrowTipPoint1;
		public Point arrowTipPoint2;

		public Rectangle textRect;
		//public Rectangle textBackGroundRect;

		public string transitionToken;

		public bool isHoverOver = false;

		public GraphicState fromState;
		public GraphicState toState;

		public Arrow(GraphicState s1, GraphicState s2)
		{
			fromState = s1;
			toState = s2;
			transitionToken = "";
			updateArrowPosition(s1, s2);
		}

		public void updateArrowPosition(GraphicState s1, GraphicState s2)
		{
			bezierPoint1 = new Point(-1, -1);
			bezierPoint2 = new Point(-1, -1);
			if (s1 == null)
				s1 = fromState;
			if (s2 == null)
				s2 = toState;
			if (s1 != s2)
			{
				double t1 = Math.Atan2(s2.location.Y - s1.location.Y, s2.location.X - s1.location.X);
				double t2 = Math.Atan2(s1.location.Y - s2.location.Y, s1.location.X - s2.location.X);
				start = new Point((int)(Math.Cos(t1) * GraphicState.STATE_RADII + s1.location.X), (int)(Math.Sin(t1) * GraphicState.STATE_RADII + s1.location.Y));
				end = new Point((int)(Math.Cos(t2) * GraphicState.STATE_RADII + s2.location.X), (int)(Math.Sin(t2) * GraphicState.STATE_RADII + s2.location.Y));
				double theta1 = Math.Atan2(start.Y - s1.location.Y, start.X - s1.location.X);
				theta1 = (((theta1 * 180) / Math.PI - 10) * Math.PI) / 180;
				double theta2 = Math.Atan2(end.Y - s2.location.Y, end.X - s2.location.X);
				theta2 = (((theta2 * 180) / Math.PI + 10) * Math.PI) / 180;
				start.X = (int)(Math.Cos(theta1) * GraphicState.STATE_RADII + s1.location.X);
				start.Y = (int)(Math.Sin(theta1) * GraphicState.STATE_RADII + s1.location.Y);
				end.X = (int)(Math.Cos(theta2) * GraphicState.STATE_RADII + s2.location.X);
				end.Y = (int)(Math.Sin(theta2) * GraphicState.STATE_RADII + s2.location.Y);

				//pathEquation = new LineEquation(start.X, start.Y, end.X, end.Y);

				double theta = Math.Atan2(start.Y - end.Y, start.X - end.X);
				theta = (((theta * 180) / Math.PI) * Math.PI) / 180;
				double theta3 = (((theta * 180) / Math.PI - 10) * Math.PI) / 180;
				double theta4 = (((theta * 180) / Math.PI + 10) * Math.PI) / 180;
				arrowTipPoint1 = new Point((int)(Math.Cos(theta3) * 30 + end.X), (int)(Math.Sin(theta3) * 30 + end.Y));
				arrowTipPoint2 = new Point((int)(Math.Cos(theta4) * 30 + end.X), (int)(Math.Sin(theta4) * 30 + end.Y));
				textRect = new Rectangle((3*start.X + end.X) / 4 - GraphicState.STATE_RADII, (3*start.Y + end.Y) / 4 - GraphicState.STATE_RADII, 2 * GraphicState.STATE_RADII, 2 * GraphicState.STATE_RADII);
			}
			else
			{
				start = new Point((int)(s1.location.X - GraphicState.STATE_RADII / Math.Sqrt(2)), (int)(s1.location.Y - GraphicState.STATE_RADII / Math.Sqrt(2)) + 5);
				end = new Point((int)(s1.location.X + GraphicState.STATE_RADII / Math.Sqrt(2)), (int)(s1.location.Y - GraphicState.STATE_RADII / Math.Sqrt(2)));
				bezierPoint1.X = start.X + GraphicState.STATE_RADII / 10;
				bezierPoint1.Y = start.Y - 2 * GraphicState.STATE_RADII;
				bezierPoint2.X = end.X - GraphicState.STATE_RADII / 10;
				bezierPoint2.Y = start.Y - 2 * GraphicState.STATE_RADII;
				arrowTipPoint1 = new Point(end.X - 7, end.Y - 20);
				arrowTipPoint2 = new Point(end.X + 5, end.Y - 20);
				textRect = new Rectangle((bezierPoint1.X+ bezierPoint2.X)/2 - GraphicState.STATE_RADII, (bezierPoint1.Y + bezierPoint2.Y)/2 - GraphicState.STATE_RADII, 2*GraphicState.STATE_RADII, 2*GraphicState.STATE_RADII);
			}

		}
		public List<String> getDelta()
		{
			List<String> deltaList = new List<String>();
			String currStr = "";
			foreach(char c in transitionToken.ToCharArray())
			{
				if (c != ',')
					currStr = currStr + c;
				else
				{
					deltaList.Add(currStr);
					currStr = "";
				}
			}
			deltaList.Add(currStr);
			return deltaList;
		}
	}
}
