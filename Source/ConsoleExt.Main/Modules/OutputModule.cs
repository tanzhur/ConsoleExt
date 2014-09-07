namespace ConsoleExt.Main.Modules
{
    using System;
    using ConsoleExt.Main.Models;

    /// <summary>
    /// Output module that helps with the console output
    /// </summary>
    public class OutputModule
    {
        /// <summary>
        /// Writes a message on the console with a spesific color depending on its type
        /// </summary>
        /// <param name="message">The message that will be written</param>
        /// <param name="messageType">The type of the message</param>
        public void WriteMessage(
            string message,
            ConsoleMessageType messageType = ConsoleMessageType.Default)
        {
            switch (messageType)
            {
                case ConsoleMessageType.Default:
                    {
                        Console.ResetColor();
                        break;
                    }

                case ConsoleMessageType.Error:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }

                case ConsoleMessageType.Info:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }

                case ConsoleMessageType.Warrning:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }

                case ConsoleMessageType.Success:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }

                default:
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="foregroundColor"></param>
        /// <param name="backgroundColor"></param>
        public void WriteMessage(
            string message,
            ConsoleColor foregroundColor,
            ConsoleColor backgroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Removes the scrollbars from the console
        /// </summary>
        public static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        /// <summary>
        /// Prints a specific string on a specific position on the console
        /// </summary>
        /// <param name="x">The X coordinate of the postion where the string will be written</param>
        /// <param name="y">The Y coordinate of the postion where the string will be written</param>
        /// <param name="printString">The string to be printed</param>
        /// <param name="color">The color of the printed string</param>
        public static void PrintStringOnPosition(int x, int y, string printString, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(printString);
            Console.ResetColor();
        }

        /// <summary>
        /// Prints a specific string on a specific position on the console
        /// </summary>
        /// <param name="point">The position on the console where the string will be printed</param>
        /// <param name="printString">The string to be printed</param>
        /// <param name="color">The color of the printed string</param>
        public static void PrintStringOnPosition(Point2D point, string printString, ConsoleColor color)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.ForegroundColor = color;
            Console.Write(printString);
            Console.ResetColor();
        }
    }
}
