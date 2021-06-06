using System;

namespace pairedNArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {};
            int n = 0;
            Console.WriteLine(pairedN(a,n));
        }



        private static int pairedN(int[]a,int n)
        {

            if (a == null || a.Length < 2)
            {
                return 0;
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if(i!=j && (a[i]+a[j])==n && (i + j) == n)
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
    }
}
