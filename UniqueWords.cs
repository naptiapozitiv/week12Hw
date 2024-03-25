using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Week12Hw
{
    public class UniqueWords
    {
        public string Text { get; set; }
        public string UniqWords { get; set; }
        public UniqueWords(string text, string uniqWords)
        {
            Text = text;
            UniqWords = uniqWords;
        }
        public static string GetTextInput()
        {
            string text;
            do
            {
                Console.WriteLine("Please enter text (100 character max): ");
                text = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(text) || text.Length > 100);
            return text;
        }
        public static string GetUniqWordsInput()
        {
            string uniqWords;
            do
            {
                Console.WriteLine("Enter unique words to find in the text (seperate with commas, no spaces) ");
                uniqWords = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(uniqWords) || uniqWords.Length > 100);
            return uniqWords;
        }
        public void CountUniqueWords(UniqueWords uni)
        {
            var ignore = @"[?,.:;'!-()]";
            string text = Regex.Replace(uni.Text, ignore, "").ToLower();
            string[] TextWords = text.Split(' ');
            string[] uniqueWords = uni.UniqWords.ToLower().Split(',');
            int[] totalUnique = new int[uniqueWords.Length];
            int total;
            int i = 0;
            foreach (string UWord in uniqueWords)
            {
                total = 0;
                foreach (string TWord in TextWords)
                {
                    if (UWord == TWord)
                    {
                        total++;
                    }
                }
                totalUnique[i] = total;
                i++;
            }
            for (int j = 0; j < totalUnique.Length; j++)
            {
                Console.WriteLine($"{uniqueWords[j]} occurrs {totalUnique[j]} time(s) in the given text");
            }
        }
    }
}