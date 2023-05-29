using System;
using System.Collections;
using System.Drawing;

namespace SHAPES
{
    [Serializable]
    public class ShapeList
    {
        protected SortedList shapes;

        public ShapeList()
        {
            shapes = new SortedList();
        }

        public void Remove(int index)
        {

            if (index >= 0 && index < shapes.Count)
            {
                for (int i = index; i < shapes.Count - 1; i++)
                    shapes[i] = shapes[i + 1];
                shapes.RemoveAt(shapes.Count - 1);
            }
        }

        public int NextIndex
        {
            get
            {
                return shapes.Count;
            }
        }

        public Shape this[int index]
        {
            get
            {
                if (index >= shapes.Count || index < 0)
                    return (Shape)null;

                //SortedList internal method
                return (Shape)shapes.GetByIndex(index);
            }
            set
            {
                if (index <= shapes.Count && 0 <= index)
                    shapes[index] = value;
            }
        }

        public void DrawAll(Graphics g)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                ((Shape)shapes[i]).Draw(g);
                if (((Shape)shapes[i]).IsFill)
                    ((Shape)shapes[i]).Fill(g);
            }
        }

        public void RemoveAll()
        {
            for (int i = shapes.Count - 1; 0 <= i; i--)
            {
                Remove(i);
            }
        }
    }
}
