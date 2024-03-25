using System;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using Week12Hw;
namespace HappyArray
{
    class Week12
    {
        public static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci(Fibonacci.GetValidInput());
            fib.IsFibonacci(fib);
            Console.WriteLine();
            UniqueWords uni = new UniqueWords(UniqueWords.GetTextInput(), UniqueWords.GetUniqWordsInput());
            uni.CountUniqueWords(uni);
            Console.WriteLine();
            NumPalindrome pal = new NumPalindrome(NumPalindrome.GetPalindromeInput());
            pal.IsNumericPalindrome(pal);
        }
    }
}