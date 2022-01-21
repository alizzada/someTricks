using System;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            int pow = 3, number = 4,result=1;

            for (int i = 1; i <=pow; i++)
            {
                result *=number;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
