using System;

namespace EquilibriumIndexOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 1, 1, 2, 1, 7 };
            Console.WriteLine(equilibrium(array));
        }


        static int equilibrium(int[] arr)
        {
            int i, j;
            int leftsum, rightsum;
            int n = arr.Length;

            /* Check for indexes one by
             one until an equilibrium
            index is found */
            for (i = 0; i < n; ++i)
            {

                // initialize left sum
                // for current index i
                leftsum = 0;

                // initialize right sum
                // for current index i
                rightsum = 0;

                /* get left sum */
                for (j = 0; j < i; j++)
                    leftsum += arr[j];

                /* get right sum */
                for (j = i + 1; j < n; j++)
                    rightsum += arr[j];

                /* if leftsum and rightsum are
                 same, then we are done */
                if (leftsum == rightsum)
                    return i;
            }

            /* return -1 if no equilibrium
             index is found */
            return -1;
        }
    }
}
