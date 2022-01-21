using System;

namespace LeetCodeTwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] sumIndexes = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        sumIndexes[0] = i;
                        sumIndexes[1] = j;
                    }

                }

                
            }

            return sumIndexes;
        }
    }
}
