namespace ConsoleExt.Main.Models
{
    /// <summary>
    /// Representation of 2D point
    /// </summary>
    public struct Point2D
    {
        public Point2D(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// The X Coordinate of the 2D Point
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The Y Coordinate of the 2D Point
        /// </summary>
        public int Y { get; set; }
    }
}
