using System;

namespace two_sum
{
    internal class Program
    {
        public class Solution
        {


            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }

                    }

                }

                return null;
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int [] num = new int[] { 5,8,7,9,2};
            int target = 15;
            int [] result=solution.TwoSum(num, target);
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}
