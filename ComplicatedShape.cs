using System;
using System.Collections;
using System.Drawing;

namespace SHAPES
{
    [Serializable]
    public class ComplicatedShape : Shape
    {
        //Shape prev, cur;
        //prev = (Shape)shapes[i - 1];
        //cur = (Shape)shapes[i];
        //g.DrawLine(Pens.Yellow, prev.X, prev.Y, cur.X, cur.Y);

        float maxX;
        float maxY;
        float minX;
        float minY;

        SortedList dots;

        public bool isInBarrier(Point p)
        {
            return p.X < maxX && minX < p.X && p.Y < maxY && minY < p.Y;
        }


        public override void Draw(Graphics g)
        {

        }
        public override void Fill(Graphics g)
        {

        }
        public override bool IsInside(int xP, int yP)
        {
            return false;
        }

        public override void Follow(int xP, int yP)
        {

        }
    }
}
