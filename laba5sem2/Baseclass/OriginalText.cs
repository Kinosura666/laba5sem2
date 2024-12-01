namespace laba5sem2
{
    public abstract class OriginalText
    {
        public string inputLine { get; protected set; }
        public int symbolCount { get; protected set; }

        public OriginalText(string inputline)
        {
            this.inputLine = inputline;
            this.symbolCount = inputLine.Length;
        }

        public abstract void ShowInfo();

        public virtual void ChangeContext(string context)
        {
            this.inputLine = context;
        }
    }
}
