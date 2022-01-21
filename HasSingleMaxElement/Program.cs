using System;

namespace HasSingleMaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {-6,-6,-6,-6,-6};

            Console.WriteLine(HasSingleMax(a));
        }


        private static int HasSingleMax(int[] a)
        {

            if (a == null || a.Length == 0)
                return 0;

            int max = a[0];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index = i;

                }

            }

            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] == a[index] && j != index)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
