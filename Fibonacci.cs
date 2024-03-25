using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week12Hw
{
    public class Fibonacci
    {
        private int FibNum;
        public Fibonacci(int validatedInput)
        {
            FibNum = validatedInput;
        }
        public static int GetValidInput()
        {
            string fibNumInput;
            int num;
            do
            {
                Console.WriteLine("Enter a number to recieve its position in the Fibonacci Sequence: ");
                fibNumInput = Console.ReadLine();
            }
            while (!int.TryParse(fibNumInput, out num) || string.IsNullOrEmpty(fibNumInput));
            return num;
        }
        public void IsFibonacci(Fibonacci f)
        {
            if (f.FibNum == 0)
            { Console.WriteLine("fib(0)"); return; }
            else if (f.FibNum == 1) { Console.WriteLine("fib(1) and fib(2)"); return; }
            int first = 1;
            int next = 1;
            int fibNum;
            for (int i = 3; i != 0; i++)
            {
                fibNum = first + next;
                if (f.FibNum == fibNum)
                {
                    Console.WriteLine($"fib({i})");
                    return;
                }
                else if (f.FibNum < fibNum)
                {
                    Console.WriteLine("Number is not in the Fibonacci Sequence");
                    return;
                }
                first = next;
                next = fibNum;
            }
        }
    }
}
