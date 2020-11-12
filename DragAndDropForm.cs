using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tthk_dragndrop
{
    public partial class DragAndDropForm : Form
    {
        Rectangle rectangle, circle, square;
        List<Tuple<Rectangle, Coordinates, bool>> isClicked = new List<Tuple<Rectangle, Coordinates, bool>>(); 

        public DragAndDropForm()
        {
            rectangle = new Rectangle(10, 10, 200, 100);
            circle = new Rectangle(220, 10, 150, 150);
            square = new Rectangle(380, 10, 150, 150);
            foreach (var rect in new List<Rectangle>() { rectangle, circle, square })
            {
                isClicked.Add(new Tuple<Rectangle, Coordinates, bool> (rect, new Coordinates(0,0), false));
            }
            InitializeComponent();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, circle);
            e.Graphics.FillRectangle(Brushes.Blue, square);
            e.Graphics.FillRectangle(Brushes.Yellow, rectangle);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if ( (e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.Y) )
            {
                if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > e.Y))
                {
                    isClicked[rectangle] = true;

                    rectangle.X = e.X - rectangle.X;
                    rectangle.Y = e.Y - rectangle.Y;
                }
            }    
        }
    }
}
