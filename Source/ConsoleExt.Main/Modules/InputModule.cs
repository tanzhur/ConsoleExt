namespace ConsoleExt.Main.Modules
{
    using System;
    using ConsoleExt.Main.Extentions;

    public class InputModule
    {
        private const string ReadDefaultGreetingMessage = "Hello! Please enter a desired input.";
        private const string ReadDefaultErrorMessage = "Invalid input. Please try again.";

        /// <summary>
        /// Safely reads a T type form the console. If the input is 
        /// invalid outputs throws an exception.
        /// </summary>
        /// <typeparam name="T">The type witch will be read form the console</typeparam>
        /// <returns>Returns the parsed T type.</returns>
        public T SafeRead<T>()
        {
            string input = Console.ReadLine();
            var inputNumber = input.Convert<T>();
            return inputNumber;
        }

        /// <summary>
        /// Safely reads a T type form the console. If the input is 
        /// invalid outputs an error message and prompt for another input.
        /// </summary>
        /// <typeparam name="T">The type witch will be read form the console</typeparam>
        /// <param name="greetingMessage">Greeting message for the read start.</param>
        /// <param name="errorMessage">Error message if the parsing fails.</param>
        /// <returns>Returns the parsed T type.</returns>
        public T SafeReadWithMessage<T>(
            string greetingMessage = ReadDefaultGreetingMessage,
            string errorMessage = ReadDefaultErrorMessage)
        {
            while (true)
            {
                Console.WriteLine(greetingMessage);
                string input = Console.ReadLine();

                try
                {
                    var inputNumber = input.Convert<T>();
                    return inputNumber;
                }
                catch (Exception)
                {
                    ConsoleExtend.Instance.Output.WriteMessage(errorMessage, ConsoleMessageType.Error);
                }
            }
        }
    }
}
