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
            bool result=true;
            int number = int.Parse(Console.ReadLine());
            for ( i = 2; i <number; i++)
            {
                for( k=2; k < number; k++)
                {
                    if (i != k && i % k == 0)
                    {
                        result = false;
                        break;
                    }
                        
                }
                if (result == true)
                {
                    Console.WriteLine(i);
                }
                result = true;
            }
            
            Console.ReadLine();
        }
    }
}
