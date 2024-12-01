using System;

namespace laba5sem2
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Cyan;
            var sentence = new Sentence("Hello влівдліолаіаівадіваівлаіваві");              // the only sentence object
            sentence.ShowInfo();
            sentence.ChangeContext("Привіт свіdf,s,sfsd.,mf.m,sdfmmsdfsdf,sd,fт");          // override method
            sentence.ShowInfo();
            sentence.ChangeContext("Украанська мова English languag");
            sentence.ShowInfo();

            string reversedlatin = sentence.ReverseSentence();
            Console.WriteLine($"Reversed Sentence: {reversedlatin}");

            Console.ForegroundColor= ConsoleColor.Green;
            var word = new Word("HelloПрив"); // doesnt detect ukrainian і ї                the only word object
            word.ShowInfo();
            word.ChangeContext("Привіт");                                                  // override method
            word.ShowInfo();
            word.ChangeContext("FreezeМорози");
            word.ShowInfo();
            word.CutWord();


            Console.ForegroundColor = ConsoleColor.Red;
            var hieroglyph = new Hieroglyphics("あ");                                      // the only hieroglyph object
            hieroglyph.ShowInfo();
            hieroglyph.ChangeContext("한");                                                // override method
            hieroglyph.ShowInfo();
            hieroglyph.ChangeContext("汉");
            hieroglyph.ShowInfo();

            Console.ForegroundColor = ConsoleColor.Yellow;
            var picture = new Picture("Image1", "1920x1080","Vector");               // the only picture object
            picture.ShowInfo();
            picture.ChangeFormat("Bitmap");
            picture.ShowInfo();
            picture.ChangeSize("1080x720");
            picture.ShowInfo();
            picture.ChangeContext("NewImage");                                          // base (OriginalText class) method
            picture.ShowInfo();
            Console.ResetColor();
        }
    }
}