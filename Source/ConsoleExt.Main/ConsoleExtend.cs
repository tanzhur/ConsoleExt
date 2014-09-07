namespace ConsoleExt.Main
{
    using ConsoleExt.Main.Modules;

    public class ConsoleExtend
    {
        private static ConsoleExtend instance;
        private readonly InputModule inputModule;
        private readonly OutputModule outputModlue;

        public ConsoleExtend()
        {
            this.inputModule = new InputModule();
            this.outputModlue = new OutputModule();
        }

        public static ConsoleExtend Instance
        {
            get
            {
                return instance ?? (instance = new ConsoleExtend());
            }
        }

        public OutputModule Output
        {
            get { return this.outputModlue; }
        }

        public InputModule Input
        {
            get { return this.inputModule; }
        }
    }
}
