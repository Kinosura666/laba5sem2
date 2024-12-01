namespace laba5sem2
{
    public class Sentence : OriginalText
    {
        public int wordCount { get; private set; }
        public string alphabet { get; private set; }

        public Sentence(string text) : base(text)
        {
            this.wordCount = CountWords();
            this.alphabet = GetAlphabet();
        }
        private int CountWords()
        {
            return inputLine.Split(new char[]{' ',',',';',':','\t','\n','.'}, StringSplitOptions.RemoveEmptyEntries).Length;
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

            if (cyrillicCount > latinCount)
                return "Cyrillic";
            else if (latinCount > cyrillicCount)
                return "Latin";
            else if (cyrillicCount > 0 && latinCount > 0)
                return "Mixed";
            else
                return "Unknown";
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Sentence: {inputLine}\nNumber of words: {wordCount}\nAphabet type: {alphabet}\n");
        }
        public string ReverseSentence()
        {
            char[] reversedArray = inputLine.ToCharArray();
            Array.Reverse(reversedArray);
            return new string(reversedArray);
        }
        public override void ChangeContext(string context)
        {
            this.inputLine = context;
            this.wordCount = CountWords();
            this.alphabet = GetAlphabet();
        }
    }
}
