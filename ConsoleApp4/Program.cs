using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt16( Console.ReadLine());
            int result=1;
            for (int i = 1; i <= number; i++)
            {
                 result *=  i;    
            }
            Console.Write(result);
            Console.ReadLine();
            

        }
    }
}
