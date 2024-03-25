using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week12Hw
{
    public class NumPalindrome
    {
        private int Num;
        public NumPalindrome(int num)
        {
            Num = num;
        }
        public static int GetPalindromeInput()
        {
            string input;
            int num;
            do
            {
                Console.WriteLine("Enter a number to check if it's a numeric palindrome - must be more than one digit: ");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !int.TryParse(input, out num) || num < 10);
            return num;
        }
        public void IsNumericPalindrome(NumPalindrome n)
        {
            int num = n.Num;
            int ogNum = num;
            int reverseNum = 0;
            int digit;
            while (num != 0)
            {
                digit = num % 10;
                reverseNum = reverseNum * 10 + digit;
                num /= 10;
            }

            if (reverseNum == ogNum)
            {
                Console.WriteLine($"{ogNum} is a numeric palindrome");
            }
            else
            {
                Console.WriteLine($"{ogNum} is not a numeric palindrome");
            }
        }
    }
}