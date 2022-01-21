using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 6, 2, 7 };
            int[] reversedArray = new int[array.Length];
            int count = 0;

            for (int i = array.Length-1; i >=0; i--)
            {
                reversedArray[count] = array[i];
                count++;
            }
            foreach(var item in reversedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
