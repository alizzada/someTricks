using System;

namespace MIU
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24;
            Console.WriteLine(IsDigitIncreasing(n));
        }


        public static int IsDigitIncreasing(int n)
        {

            if (n > 0 && n < 10)
                return 1;

            int previusNumber, sum;

            for (int i = 1; i <= 9; i++)
            {
                sum = i;
                previusNumber = i;

                while (sum <= n)
                {
                    previusNumber = previusNumber * 10 + i;
                    sum = sum + previusNumber;
                    if (sum == n)
                    {
                        return 1;
                    }

                }

            }

            return 0;

        }
    }
}
