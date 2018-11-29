using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Goals:
            // Replace all spaces with underscores
            // Replace all lowercase "A"s with an uppercase "A"
            // Remove all leading and trailing spaces
            Console.Write("Gimme a string, any string ");

            string StringTyped = Console.ReadLine();
            Console.WriteLine(UnderscoresAndUppercaseA(StringTyped.Trim()));
            // New Goals:
            // Reverse string passed in

            Console.Write("Gimme another string ");

            string StringToReverse = Console.ReadLine();

            Console.WriteLine(ReverseString(StringToReverse));
        }

        public static string UnderscoresAndUppercaseA(string Word)
        {
            StringBuilder ChangedWord = new StringBuilder(Word);
            for (int i = 0; i < Word.Length; i++)
            {
                if (ChangedWord[i] == ' ')
                {
                    ChangedWord[i] = '_';
                }
                else if (ChangedWord[i] == 'a')
                {
                    ChangedWord[i] = Char.ToUpper(ChangedWord[i]);
                }
            }
            return ChangedWord.ToString();
        }

        public static string ReverseString(string Word)
        {
            string ReversedString = "";
            for(int i = Word.Length - 1; i > -1; i--)
            {
                ReversedString += Word[i];
            }
            return ReversedString;
        }
    }
}
