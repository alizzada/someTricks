using System;

namespace DigitIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = 10;
            Console.WriteLine(CheckNumber(n));
        }



		private static int CheckNumber(int n)
		{
			if (n>0 && n< 10  )
            {
				return 1;
			}				
				

			int sum = 0, previusNumber =0;


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
