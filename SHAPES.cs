/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System;
using System.Collections;
using System.Drawing;

namespace SHAPES
{
    [Serializable]
    public abstract class Shape
    {
        float startX; // ( , )
        float startY;
        float endX;
        float endY;
        bool isFill = false;
        Color fill = Color.Blue;

        public bool IsFill
        {
            get
            {
                return isFill;
            }
            set
            {
                isFill = value;
            }
        }

        public Color ShapeFill
        {
            set
            {
                isFill = true;
                fill = value;
            }
            get
            {
                return fill;
            }
        }

        public float StartX
        {
            set
            {
                startX = value;
            }
            get
            {
                return startX;
            }
        }

        public float StartY
        {
            set
            {
                startY = value;
            }
            get
            {
                return startY;
            }
        }

        public float EndX
        {
            set
            {
                endX = value;
            }
            get
            {
                return endX;
            }
        }

        public float EndY
        {
            set
            {
                endY = value;
                 
            }
            get
            {
                return endY;
            }
        }

        public abstract void Draw(Graphics g);
        public abstract void Fill(Graphics g);
        public abstract bool IsInside(int xP, int yP);
        public abstract void Follow(int xP, int yP);
    }
}
