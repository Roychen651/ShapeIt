using System;
using System.Collections;
using System.Drawing;

namespace SHAPES
{
    [Serializable]
    public class CircleS : SimpleShape
    {
        float radius;
        public CircleS()
        {
            StartX = 0;
            StartY = 0;
            EndX = 10;
            EndY = 10;

        }

        public CircleS(Point start,Point end)
        {
            StartX = start.X;
            StartY = start.Y;
            EndX = end.X;
            EndY = end.Y;
        }

        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        protected override float XMid
        {
            get
            {
                return Left + radius;
            }
            set
            {
                Left = value - radius;
            }
        }
        protected override float YMid
        {
            get
            {
                return Top + radius;
            }
            set
            {
                Top = value - radius;
            }
        }

        public override void Draw(Graphics g)
        {
            SetTopLeft();
            Pen pen = new Pen(Color.Black, 5);
            g.DrawEllipse(pen, Left, Top, 2 * radius, 2 * radius);
        }

        public override void Fill(Graphics g)
        {
            SetTopLeft();
            SolidBrush br = new SolidBrush(ShapeFill);
            g.FillEllipse(br, Left, Top, 2 * radius, 2 * radius);
        }

        public override bool IsInside(int xP, int yP)
        {
            return Math.Sqrt((xP - XMid) * (xP - XMid) + (yP - YMid) * (yP - YMid)) < radius;
        }

        protected override void SetTopLeft()
        {
            float width, height;
            Left = Math.Min(StartX, EndX);
            Top = Math.Min(StartY, EndY);

            width = Math.Abs(StartX - EndX);
            height = Math.Abs(StartY - EndY);
            radius = (float)Math.Sqrt(width * width + height * height) / 2;
        }
    }
}
