using System;

namespace ExamQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 2,1 };
            int n = 2;
            Console.WriteLine(NValues(a, n));
        }


        private static int NValues(int[] a, int n)
        {
            if (a == null || a.Length == 0)
                return 0;
            
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                bool isNotDistinct = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j])
                    {
                        isNotDistinct = true;
                        break;
                    }
                }
                if (!isNotDistinct)
                {
                    count++;
                }

            }

            if (count == n)
                return 1;

            return 0;
        }
    }
}
