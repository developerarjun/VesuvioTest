using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static int calPoints(String[] ops)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var op in ops)
            {
                switch (op)
                {
                    case "+":
                        int x = stack.Pop();
                        int y = stack.Pop();
                        stack.Push(y);
                        stack.Push(x);
                        stack.Push(x + y);
                        break;
                    case "D":
                        stack.Push(stack.Peek() * 2);
                        break;
                    case "C":
                        stack.Pop();
                        break;
                    default:
                       stack.Push(Int32.Parse(op));
                        break;
                }
            }

            int sum = 0;
            while (!(stack.Count == 0))
            {
                sum += stack.Pop();
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string[] ops = { "5", "-2", "4", "C", "D","9","+","+" };

            Console.WriteLine(calPoints(ops));

        }
    }
}
