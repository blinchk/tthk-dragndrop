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

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
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
