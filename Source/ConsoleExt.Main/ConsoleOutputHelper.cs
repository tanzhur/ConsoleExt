namespace ConsoleExt.Main
{
    using System;

    public class ConsoleOutputHelper
    {
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

        public static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        public static void PrintStringOnPosition(int x, int y, string printString, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(printString);
        }

        public static void PrintStringOnPosition(Point2D point, string printString, ConsoleColor color)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.ForegroundColor = color;
            Console.Write(printString);
        }
    }
}
