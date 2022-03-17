using System;

namespace palindrome_number
{
    internal class Program
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                int sum = 0, d, num;
                num = x;
                while (x > 0)
                {
                    d = x % 10;
                    x = x / 10;
                    sum = (sum * 10) + d;
                }
                if (sum == num)
                {
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();    
            int x = 121;
            bool result = s.IsPalindrome(x);
            Console.WriteLine(result);

        }
    }
}
