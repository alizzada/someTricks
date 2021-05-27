using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {3,2,1,4,5};

            int middleNumber = 0;

            if ((array.Length) % 2 == 0)
            {
                middleNumber = array[array.Length / 2 - 1];
            }
            else
                middleNumber = array[array.Length / 2];



             Console.WriteLine(middleNumber);
            Console.ReadKey();
        }
    }
}
