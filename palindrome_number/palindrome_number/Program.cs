using System;

namespace palindrome_number
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Solution sol = new Solution();    
            var number = 121;
            bool result = sol.IsPalindrome(number);
            Console.WriteLine(result);

        }
    }
}
