using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            bool result=false;
            int number = int.Parse(Console.ReadLine());
            for ( i = 2; i <number; i++)
            {
                for( k=2; k < number; k++)
                {
                    if (i != k && i % k == 0)
                    {
                        result = true;
                        break;
                    }
                        
                }
                if (result == true)
                {
                    Console.WriteLine(i);
                }
                result = false;
            }
            
            Console.ReadLine();
        }
    }
}
