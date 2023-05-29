using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using SHAPES;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ShapeList pts = new ShapeList();
        
        enum State
        {
            draw,
            drag,
            scale,
            delete,
            color_change
        }
        enum WhichShape
        {
            circle,
            rectangle
        }

        Color fill_color = Color.Blue;
        bool is_fill = false;

        Point start, end;
        bool isPressed = false;
        int curIndex = -1;
        State state = State.draw;
        State prev_state = State.draw;
        WhichShape shapeType = WhichShape.rectangle;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            isPressed = true;

            curIndex = -1;
            string buttonClick = e.Button.ToString();
            for (int i = pts.NextIndex - 1; 0 <= i; i--)
            {
                if (pts[i].IsInside(e.X, e.Y))
                {
                    curIndex = i;
                    if (buttonClick == "Right") //if Right button pressed - Remove
                    {
                        prev_state = state;
                        state = State.delete;
                    }
                    break;
                }
            }

            if (state == State.delete && 0 <= curIndex)
            {
                pts.Remove(curIndex);
                curIndex = -1;
                pictureBox1.Invalidate();
                return;
            }

            if (state == State.draw)
            {
                end.X = start.X + 2;
                end.Y = start.Y + 2;
                switch (shapeType)
                {
                    case WhichShape.circle:
                        pts[pts.NextIndex] = new CircleS(start,end);
                        break;
                    case WhichShape.rectangle:
                        pts[pts.NextIndex] = new RectangleS(start,end);
                        break;
                }

                curIndex = pts.NextIndex - 1;

            

                if(is_fill)
                    pts[curIndex].ShapeFill = fill_color;
                pictureBox1.Invalidate();
            }

            if (state == State.color_change && 0 <= curIndex)
            {
                pts[curIndex].IsFill = false;
                pictureBox1.Invalidate();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.Location;
            isPressed = false;

            string buttonClick = e.Button.ToString();
            if (buttonClick == "Right" && state == State.delete)
                state = prev_state;

            if (state == State.color_change && 0 <= curIndex)
            {
                if(is_fill)
                {
                    pts[curIndex].ShapeFill = fill_color;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            end = e.Location;
            if (isPressed)
            {
                if ((state == State.draw || state == State.scale) && 0 <= curIndex)
                {
                    pts[curIndex].EndX = end.X;
                    pts[curIndex].EndY = end.Y;
                }
                else if (state == State.drag && 0 <= curIndex)
                {
                    pts[curIndex].Follow(end.X, end.Y);
                }

                pictureBox1.Invalidate();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pts.DrawAll(g);
        }

        private void radioButtonRec_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = WhichShape.rectangle;
        }

        private void radioButtonCirc_CheckedChanged(object sender, EventArgs e)
        {
            shapeType = WhichShape.circle;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            pts.RemoveAll();
            pictureBox1.Invalidate();
        }

        private void comboBoxModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox mode = (ComboBox)sender;
            switch (mode.Text)
            {
                case "Draw":
                    state = State.draw;
                    break;
                case "Drag":
                    state = State.drag;
                    break;
                case "Color Change":
                    state = State.color_change;
                    break;
                case "Scale":
                    state = State.scale;
                    break;
                case "Delete":
                    state = State.delete;
                    break;
            }
        }

        private void listBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox color = (ListBox)sender;
            switch (color.Text)
            {
                case "(Non)":
                    is_fill = false;
                    break;
                case "Red":
                    fill_color = Color.Red;
                    is_fill = true;
                    break;
                case "Blue":
                    fill_color = Color.Blue;
                    is_fill = true;
                    break;
                case "Yellow":
                    fill_color = Color.Yellow;
                    is_fill = true;
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\myModels";
            Directory.CreateDirectory(saveFileDialog1.InitialDirectory);
            saveFileDialog1.Filter = "paint files (*.pnt)|*.pnt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, pts);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\myModels";
            openFileDialog1.Filter = "paint files (*.pnt)|*.pnt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                using (Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open))
                {
                    pts = (ShapeList)binaryFormatter.Deserialize(stream);
                }
                pictureBox1.Invalidate();
            }
        }
    }
}
