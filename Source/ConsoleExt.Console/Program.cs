namespace ConsoleExt.Console
{
    using ConsoleExt.Main;

    public class Program
    {
        internal static void Main(string[] args)
        {
            ConsoleExtend.Instance.Output.WriteMessage("Echo", ConsoleMessageType.Success);
            var output = ConsoleExtend.Instance.Input.SafeRead<long>();
        }
    }
}
