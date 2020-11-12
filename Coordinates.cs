namespace tthk_dragndrop
{
    class Coordinates
    {
        private int x;
        private int y;

        public Coordinates()
        {
            x = 0;
            y = 0;
        }

        public Coordinates(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
