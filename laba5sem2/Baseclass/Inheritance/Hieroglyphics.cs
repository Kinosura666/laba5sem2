namespace laba5sem2
{
    public class Hieroglyphics : OriginalText
    {
        public string Origin { get; private set; }

        public Hieroglyphics(string text) : base(text) 
        { 
            this.Origin = GetOrigin();
        }

        private string GetOrigin()
        {
            foreach (char c in inputLine)
            {
                if (IsJapanese(c))
                    return "Japanese";
                else if (IsChinese(c))
                    return "Chinese";
                else if (IsKorean(c))
                    return "Korean";
            }
            return "Unknown"; 
        }
        public override void ChangeContext(string context)
        {
            this.inputLine = context;
            this.Origin = GetOrigin();
        }
        private bool IsChinese(char c)
        {
            int codePoint = char.ConvertToUtf32(c.ToString(), 0);
            return (codePoint >= 0x4E00 && codePoint <= 0x9FFF) || (codePoint >= 0x3400 && codePoint <= 0x4DBF) || (codePoint >= 0x20000 && codePoint <= 0x2A6DF) || (codePoint >= 0x2A700 && codePoint <= 0x2B73F);
        }

        private bool IsJapanese(char c)
        {
            return (c >= '\u3040' && c <= '\u309F') || (c >= '\u30A0' && c <= '\u30FF') || (c >= '\u31F0' && c <= '\u31FF');
        }

        private bool IsKorean(char c)
        {
            return (c >= '\uAC00' && c <= '\uD7AF') || (c >= '\u1100' && c <= '\u11FF') || (c >= '\u3130' && c <= '\u318F'); 
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Hieroglyph: {inputLine}, Origin: {Origin}\n");
        }
    }
}
