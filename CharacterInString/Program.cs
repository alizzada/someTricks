using System;

namespace CharacterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Azerbaycan";
            char character = 'a';
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == character)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
