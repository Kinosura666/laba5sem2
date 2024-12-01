namespace laba5sem2
{
    public class Word : OriginalText
    {
        public string alphabet { get; private set; }

        public Word(string text) : base(text)
        {
            alphabet = GetAlphabet();
        }

        private string GetAlphabet()
        {
            int cyrillicCount = 0;
            int latinCount = 0;

            foreach (char c in inputLine)
            {
                if (char.IsLetter(c))
                {
                    if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                        cyrillicCount++;
                    else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                        latinCount++;
                }
            }
            if (cyrillicCount == latinCount)
                return "Mixed";
            else if (cyrillicCount > latinCount)
                return "Cyrillic";
            else if (latinCount > cyrillicCount)
                return "Latin";
            else
                return "Unknown";
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"\nWord: {inputLine}, Length: {symbolCount}, Alphabet: {alphabet}\n");
        }
        
        public void CutWord()
        {
            foreach (var word in inputLine)
            {
                Console.Write($"{word}\t");
            }
            Console.WriteLine();
        }
        public override void ChangeContext(string context)
        {
            this.inputLine = context;
            this.symbolCount = context.Length;
            this.alphabet = GetAlphabet();
        }
    }
}
