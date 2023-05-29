using System;
using System.Collections;
using System.Drawing;

namespace SHAPES
{
    [Serializable]
    public abstract class SimpleShape : Shape
    {
        float left; // x value of the top left point
        float top;  // y value of the top left point

        protected virtual float XMid { get; set; }
        protected virtual float YMid { get; set; }

        public float Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }
        public float Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

        protected abstract void SetTopLeft();

        public override void Follow(int xP, int yP)
        {
            if (IsInside(xP, yP))
            {
                float SdeltaX = Math.Abs(StartX - XMid);
                float SdeltaY = Math.Abs(StartY - YMid);
                float EdeltaX = Math.Abs(EndX - XMid);
                float EdeltaY = Math.Abs(EndY - YMid);

                XMid = xP;
                YMid = yP;
                StartX = StartX < XMid ? XMid - SdeltaX : XMid + SdeltaX;
                StartY = StartY < YMid ? YMid - SdeltaY : YMid + SdeltaY;
                EndX = EndX < XMid ? XMid - EdeltaX : XMid + EdeltaX;
                EndY = EndY < YMid ? YMid - EdeltaY : YMid + EdeltaY;
            }
        }
    }
}
