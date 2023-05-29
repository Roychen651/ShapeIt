using System;
using System.Collections;
using System.Drawing;

namespace SHAPES
{
    [Serializable]
    public class RectangleS : SimpleShape
    {
        float width;
        float height;
        public RectangleS()
        {
            StartX = 0;
            StartY = 0;
            EndX = 10;
            EndY = 10;
        }

        public RectangleS(Point start,Point end)
        {
            StartX = start.X;
            StartY = start.Y;
            EndX = end.X;
            EndY = end.Y;
           
        }

        public float Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public float Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        protected override float XMid
        {
            get
            {
                return Left + width / 2;
            }
            set
            {
                Left = value - width / 2;
            }
        }

        protected override float YMid
        {
            get
            {
                return Top + height / 2;
            }
            set
            {
                Top = value - height / 2;
            }
        }

        public override void Draw(Graphics g)
        {
            SetTopLeft();
            Pen pen = new Pen(Color.Black, 5);
            g.DrawRectangle(pen, Left, Top, width, height);
        }

        public override void Fill(Graphics g)
        {
            SetTopLeft();
            SolidBrush br = new SolidBrush(ShapeFill);
            g.FillRectangle(br, Left, Top, width, height);
        }

        public override bool IsInside(int xP, int yP)
        {
            return Math.Abs(xP - XMid) <= width / 2 && Math.Abs(yP - YMid) <= height / 2;
        }

        protected override void SetTopLeft()
        {
            Left = Math.Min(StartX, EndX);
            Top = Math.Min(StartY, EndY);
            width = Math.Abs(StartX - EndX);
            height = Math.Abs(StartY - EndY);
        }
    }
}
