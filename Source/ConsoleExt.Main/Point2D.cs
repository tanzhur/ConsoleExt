﻿namespace ConsoleExt.Main
{
    public struct Point2D
    {
        public Point2D(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
