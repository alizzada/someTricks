using System;
using System.Collections;

namespace ArraysCommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 3, 4, 6 };
            int[] second = new int[] { 1, 5, 3, 4 };

            Console.WriteLine(getCommonElements(first,second));
        }


        static int[] getCommonElements(int[] first, int[] second)
        {
            if (first == null || second == null) 
                return null;

            if (first.Length == 0 || second.Length == 0)
                return new int[0];

            int min = (first.Length < second.Length) ? first.Length : second.Length;
            int[] x, y;
            if (min == first.Length)
            {
                x = first;
                y = second;
            }
            else
            {
                x = second;
                y = first;
            }

            ArrayList list = new ArrayList();

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        list.Add(x[i]);
                    }
                }
            }

            int[] retArray = new int[list.Count];
            for (int i=0; i<list.Count; i++)
            {
                retArray[i] = (int)list[i];
            }

            return retArray;
            
        }
    }
}
