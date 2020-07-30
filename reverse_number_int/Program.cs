using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_number_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int rev = 0, b;
            Console.WriteLine("Ededi daxil edin");
            int a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                b = a % 10;
                rev = (rev * 10) + b;    //   Reqemlerin tersine yazilmasi
                a = a / 10;
            }

            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
