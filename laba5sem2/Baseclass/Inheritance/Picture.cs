namespace laba5sem2
{
    public class Picture : OriginalText
    {
        public string Size { get; private set; }
        public string Format { get; private set; }

        public Picture(string text, string size, string format) : base(text)
        { 
            this.Size = size;
            this.Format = format;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Picture: {inputLine}, Format: {Format}, Size: {Size}\n");
        }

        public void ChangeSize(string size)
        {
            this.Size = size;
        }

        public void ChangeFormat(string format)
        {
            this.Format = format;
        }
    }
}
