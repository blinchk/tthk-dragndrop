using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace tthk_dragndrop
{
    public partial class DragAndDropForm : Form
    {
        private MainMenu menu;
        private Rectangle rectangle, circle, square;
        private Coordinates rectangleCoordinates, circleCoordinates, squareCoordinates;
        private bool rectangleClicked, circleClicked, squareClicked;
        private int x, y, dX, dY;
        private bool scaled;
        private int fillingOrder;
        Timer timer = new Timer()
        {
            Interval = 200
        };

        private int lastClicked = 0;

        public DragAndDropForm()
        {
            PaintObjects();
            timer.Tick += ReturnScaledForScalable;
            menu = new MainMenu();
            menu.MenuItems.Add("Файл");
            menu.MenuItems[0].MenuItems.Add("Выход", new EventHandler(ExitApplicationClicked));
            menu.MenuItems.Add("Редактировать");
            menu.MenuItems[1].MenuItems.Add("Отчистить", new EventHandler(RestartFormClicked));
            menu.MenuItems.Add("О нас", new EventHandler(AboutUsMenuItemClicked));
            fillingOrder = 0;
            Menu = menu;
            InitializeComponent();
        }

        private void PaintObjects()
        {
            rectangle = new Rectangle(10, 10, 200, 100);
            circle = new Rectangle(220, 10, 150, 150);
            square = new Rectangle(380, 10, 150, 150);
            rectangleCoordinates = new Coordinates();
            circleCoordinates = new Coordinates();
            squareCoordinates = new Coordinates();
        }

        private void RestartFormClicked(object sender, EventArgs e)
        {
            PaintObjects();
            pictureBox.Invalidate();
        }

        private void ExitApplicationClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutUsMenuItemClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Nikolas Laus, TARpv19", "О нас", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Рисует фигуры на PictureBox.
        /// </summary>
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            switch (fillingOrder)
            {
                case 0:
                    e.Graphics.FillEllipse(Brushes.Red, circle);
                    e.Graphics.FillRectangle(Brushes.Blue, square);
                    e.Graphics.FillRectangle(Brushes.Yellow, rectangle);
                    break;
                case 1:
                    e.Graphics.FillRectangle(Brushes.Blue, square);
                    e.Graphics.FillRectangle(Brushes.Yellow, rectangle);
                    e.Graphics.FillEllipse(Brushes.Red, circle);
                    break;
                case 2:
                    e.Graphics.FillRectangle(Brushes.Yellow, rectangle);
                    e.Graphics.FillEllipse(Brushes.Red, circle);
                    e.Graphics.FillRectangle(Brushes.Blue, square);
                    break;
            }
            
        }

        /// <summary>
        /// Событие, которые вызывается когда держим мышку на PictureBox.
        /// </summary>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if ( (e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.Y))
            {
                if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
                {
                    rectangleClicked = true;
                    rectangleCoordinates.X = e.X - rectangle.X;
                    rectangleCoordinates.Y = e.Y - rectangle.Y;
                }
            }
            if ((e.X < circle.X + circle.Width) && (e.X > circle.Y))
            {
                if ((e.Y < circle.Y + circle.Height) && (e.Y > circle.Y))
                {
                    circleClicked = true;
                    circleCoordinates.X = e.X - circle.X;
                    circleCoordinates.Y = e.Y - circle.Y;
                }
            }
            if ((e.X < square.X + square.Width) && (e.X > square.Y))
            {
                if ((e.Y < square.Y + square.Height) && (e.Y > square.Y))
                {
                    squareClicked = true;
                    squareCoordinates.X = e.X - square.X;
                    squareCoordinates.Y = e.Y - square.Y;
                }
            }
        }

        /// <summary>
        /// Событие, когда отпускаем мышку от PictureBox.
        /// </summary>
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (rectangleClicked)
            {
                lastClicked = 1;
            }
            else if (circleClicked)
            {
                lastClicked = 2;
            }
            else if (squareClicked)
            {
                lastClicked = 3;
            }
            rectangleClicked = false;
            circleClicked = false;
            squareClicked = false;
        }

        /// <summary>
        /// Событие, когда двигаем мышку на PictureBox.
        /// </summary>
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectangleClicked) 
            {
                fillingOrder = 0;
                rectangle.X = e.X - rectangleCoordinates.X;
                rectangle.Y = e.Y - rectangleCoordinates.Y;
                if ((viewLabel.Location.X < rectangle.X + rectangle.Width) && (viewLabel.Location.X > rectangle.X))
                {
                    if ((viewLabel.Location.Y < rectangle.Y + rectangle.Height) && (viewLabel.Location.Y > rectangle.Y))
                    {
                        infoLabel.Text = "Жёлтый прямоугольник";
                        DisplayFigureHeightAndWeight(rectangle);
                    }
                }
                if ((scaleUpLabel.Location.X < rectangle.X + rectangle.Width) && (scaleUpLabel.Location.X > rectangle.X))
                {
                    if ((scaleUpLabel.Location.Y < rectangle.Y + rectangle.Height) && (scaleUpLabel.Location.Y > rectangle.Y))
                    {
                        rectangle = ScaleUp(rectangle);
                    }
                }
                if ((scaleDownLabel.Location.X < rectangle.X + rectangle.Width) && (scaleDownLabel.Location.X > rectangle.X))
                {
                    if ((scaleDownLabel.Location.Y < rectangle.Y + rectangle.Height) && (scaleDownLabel.Location.Y > rectangle.Y))
                    {
                        rectangle = ScaleDown(rectangle);
                    }
                }
                CheckForFormChanging(rectangle, rectangleCoordinates);
            }
            else if (circleClicked)
            {
                fillingOrder = 1;
                circle.X = e.X - circleCoordinates.X;
                circle.Y = e.Y - circleCoordinates.Y;
                if ((viewLabel.Location.X < circle.X + circle.Width) && (viewLabel.Location.X > circle.X))
                {
                    if ((viewLabel.Location.Y < circle.Y + circle.Height) && (viewLabel.Location.Y > circle.Y))
                    {
                        infoLabel.Text = "Красный круг";
                        DisplayFigureHeightAndWeight(circle);
                    }
                }
                if ((scaleUpLabel.Location.X < circle.X + circle.Width) && (scaleUpLabel.Location.X > circle.X))
                {
                    if ((scaleUpLabel.Location.Y < circle.Y + circle.Height) && (scaleUpLabel.Location.Y > circle.Y))
                    {
                        circle = ScaleUp(circle);
                    }
                }
                if ((scaleDownLabel.Location.X < circle.X + circle.Width) && (scaleDownLabel.Location.X > circle.X))
                {
                    if ((scaleDownLabel.Location.Y < circle.Y + circle.Height) && (scaleDownLabel.Location.Y > circle.Y))
                    {
                        circle = ScaleDown(circle);
                    }
                }
                CheckForFormChanging(circle, circleCoordinates);
            }
            else if (squareClicked)
            {
                fillingOrder = 2;
                square.X = e.X - squareCoordinates.X;
                square.Y = e.Y - squareCoordinates.Y;
                if ((viewLabel.Location.X < square.X + square.Width) && (viewLabel.Location.X > square.X))
                {
                    if ((viewLabel.Location.Y < square.Y + square.Height) && (viewLabel.Location.Y > square.Y))
                    {
                        infoLabel.Text = "Синий квадрат";
                        DisplayFigureHeightAndWeight(square);
                    }
                }
                if ((scaleUpLabel.Location.X < square.X + square.Width) && (scaleUpLabel.Location.X > square.X))
                {
                    if ((scaleUpLabel.Location.Y < square.Y + square.Height) && (scaleUpLabel.Location.Y > square.Y))
                    {
                        square = ScaleUp(square);
                    }
                }
                if ((scaleDownLabel.Location.X < square.X + square.Width) && (scaleDownLabel.Location.X > square.X))
                {
                    if ((scaleDownLabel.Location.Y < square.Y + square.Height) && (scaleDownLabel.Location.Y > square.Y))
                    {
                        square = ScaleDown(square);
                    }
                }
                CheckForFormChanging(square, squareCoordinates);
            }
            pictureBox.Invalidate();
        }

        private void DisplayFigureHeightAndWeight(Rectangle rect)
        {
            heightAndWeightLabel.Text = $"Ширина: {rect.Width}, высота: {rect.Height}";
        }
        
        private void CheckForFormChanging(Rectangle rect, Coordinates rectCoordinates)
        {
            if (lastClicked == 1 && rect != rectangle)
            {
                if ((formLabel.Location.X < rect.X + rect.Width) && (formLabel.Location.X > rect.X))
                {
                    if ((formLabel.Location.Y < rect.Y + rect.Height) && (formLabel.Location.Y > rect.Y))
                    {
                        x = rect.X;
                        y = rect.Y;
                        dX = rectCoordinates.X;
                        dY = rectCoordinates.Y;

                        rect.X = circle.X;
                        rect.Y = circle.Y;
                        rectCoordinates.X = circleCoordinates.X;
                        rectCoordinates.Y = circleCoordinates.Y;

                        circle.X = x;
                        circle.Y = y;
                        circleCoordinates.X = dX;
                        circleCoordinates.Y = dY;
                    }
                }
            }
            if (lastClicked == 2 && rect != circle)
            {
                if ((formLabel.Location.X < rect.X + rect.Width) && (formLabel.Location.X > rect.X))
                {
                    if ((formLabel.Location.Y < rect.Y + rect.Height) && (formLabel.Location.Y > rect.Y))
                    {
                        x = rect.X;
                        y = rect.Y;
                        dX = rectCoordinates.X;
                        dY = rectCoordinates.Y;

                        rect.X = square.X;
                        rect.Y = square.Y;
                        rectCoordinates.X = squareCoordinates.X;
                        rectCoordinates.Y = squareCoordinates.Y;

                        square.X = x;
                        square.Y = y;
                        squareCoordinates.X = dX;
                        squareCoordinates.Y = dY;
                    }
                }
            }
            if (lastClicked == 3 && rect != square)
            {
                if ((formLabel.Location.X < rect.X + rect.Width) && (formLabel.Location.X > rect.X))
                {
                    if ((formLabel.Location.Y < rect.Y + rect.Height) && (formLabel.Location.Y > rect.Y))
                    {
                        x = rect.X;
                        y = rect.Y;
                        dX = rectCoordinates.X;
                        dY = rectCoordinates.Y;

                        rect.X = rectangle.X;
                        rect.Y = rectangle.Y;
                        rectCoordinates.X = rectangleCoordinates.X;
                        rectCoordinates.Y = rectangleCoordinates.Y;

                        rectangle.X = x;
                        rectangle.Y = y;
                        rectangleCoordinates.X = dX;
                        rectangleCoordinates.Y = dY;
                    }
                }
            }
        }
        private Rectangle ScaleUp(Rectangle rect)
        {
            if (!scaled)
            {
                rect.Width = Convert.ToInt32(rect.Width * 1.05);
                rect.Height = Convert.ToInt32(rect.Height * 1.05);
                scaled = true;
                timer.Start();
            }
            return rect;
        }
        private Rectangle ScaleDown(Rectangle rect)
        {
            if (!scaled)
            {
                rect.Width = Convert.ToInt32(rect.Width * 0.95);
                rect.Height = Convert.ToInt32(rect.Height * 0.95);
                scaled = true;
                timer.Start();
            }
            return rect;
        }

        private void ReturnScaledForScalable(object sender, EventArgs e)
        {
            scaled = false;
            timer.Stop();
        }    
    }
}
