using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_min_element_in_array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 4, 6, 23, 7 };
            int minel = numbers[0];
            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i]<minel)
                {
                    minel = numbers[i];
                }
                
            }
            Console.WriteLine(minel);
            Console.ReadLine();
        }
    }
}
