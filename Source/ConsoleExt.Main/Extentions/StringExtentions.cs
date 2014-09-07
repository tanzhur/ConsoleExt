namespace ConsoleExt.Main.Extentions
{
    using System.ComponentModel;
    using System.Text;

    public static class StringExtentions
    {
        /// <summary>
        /// Converts a string to a type T
        /// </summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <param name="input">The string that will be converted</param>
        /// <returns>Returns the converted type T</returns>
        public static T Convert<T>(this string input)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter != null)
            {
                return (T)converter.ConvertFromString(input);
            }

            return default(T);
        }
    }
}
