using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tthk_dragndrop
{
    public partial class DragAndDropForm : Form
    {
        Rectangle rectangle, circle, square;
        Coordinates rectangleXY, circleXY, squareXY;
        bool rectangleClicked, circleClicked, squareClicked;

        public DragAndDropForm()
        {
            rectangle = new Rectangle(10, 10, 200, 100);
            circle = new Rectangle(220, 10, 150, 150);
            square = new Rectangle(380, 10, 150, 150);
            rectangleXY = new Coordinates();
            circleXY = new Coordinates();
            squareXY = new Coordinates();
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
            if ( (e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.Y))
            {
                if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
                {
                    rectangleClicked = true;
                    rectangleXY.X = e.X - rectangle.X;
                    rectangleXY.Y = e.Y - rectangle.Y;
                }
            }
            if ((e.X < circle.X + circle.Width) && (e.X > circle.Y))
            {
                if ((e.Y < circle.Y + circle.Height) && (e.Y > circle.Y))
                {
                    circleClicked = true;
                    circleXY.X = e.X - circle.X;
                    circleXY.Y = e.Y - circle.Y;
                }
            }

            pictureBox.Invalidate();
        }
    }
}
