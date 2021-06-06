using System;

namespace CharCharacterArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = new char[] { 'a', 'b', 'c' };
            int start = 0,length=3;

            Console.WriteLine(getArray(a, start, length));
            Console.ReadKey();
            
        }


        static char[] getArray(char[] array,int start,int length)
        {
            if (length<0||start<0||start+length-1>=array.Length)
            {
                return null;
            }



            char[] sub = new char[length];

            for (int i = start, j=0; j < length; i++,j++)
            {
                sub[j] = array[i];
            }
            return sub;
        }
    }
}
