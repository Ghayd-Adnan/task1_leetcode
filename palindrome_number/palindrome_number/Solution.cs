using System;
using System.Collections.Generic;
using System.Text;

namespace palindrome_number
{
    public class Solution
    {
        public bool IsPalindrome(int number)
        {
            var sum = 0;
            var lastDigit = 0;
            var dividedNumber = number;
            while (dividedNumber > 0)
            {
                lastDigit = dividedNumber % 10;
                dividedNumber = dividedNumber / 10;
                sum = (sum * 10) + lastDigit;
            }
            if (sum == number)
            {
                return true;
            }
            return false;
        }
    }
}
