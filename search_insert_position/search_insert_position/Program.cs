using System;

namespace search_insert_position
{
    internal class Program
    {
        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        return i;
                    }
                    else if (nums[i] > target)
                        return i;
                    else if (i == nums.Length - 1 && target > nums[i])
                        return i + 1;
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {
           Solution solution = new Solution();
            int[] nums = new int[] { 1, 3 , 8, 9};
            int target = 0;
            int result = solution.SearchInsert(nums, target);
            Console.WriteLine(result);
        }
    }
}
