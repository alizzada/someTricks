using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello World!"));
        }

        private static string ReverseString(string input)
        {
            string reversedInput = "";
            int length;

            length = input.Length - 1;
            while (length>=0)
            {
                reversedInput = reversedInput + input[length];
                length--;
            }

            return reversedInput;
        }
    }
}
