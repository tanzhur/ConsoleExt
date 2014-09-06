namespace ConsoleExt.Main
{
    public class ConsoleExtend
    {
        private static ConsoleExtend instance;
        private readonly ConsoleInputHelper inputModule;
        private readonly ConsoleOutputHelper outputModlue;

        public ConsoleExtend()
        {
            this.inputModule = new ConsoleInputHelper();
            this.outputModlue = new ConsoleOutputHelper();
        }

        public static ConsoleExtend Instance
        {
            get
            {
                return instance ?? (instance = new ConsoleExtend());
            }
        }

        public ConsoleOutputHelper Output
        {
            get { return this.outputModlue; }
        }

        public ConsoleInputHelper Input
        {
            get { return this.inputModule; }
        }
    }
}
