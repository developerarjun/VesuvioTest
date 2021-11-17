using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int countInput(int[] arr)
        {
            int count = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int x = arr[i];
                int add = x + 1;
                bool istrue = false;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == add)
                    {
                        istrue = true;
                        break;
                    }
                }
                for (int k = i - 1;
                    !istrue && k >= 0; k--)
                {
                    if (arr[k] == add)
                    {
                        istrue = true;
                        break;
                    }
                }
                if (istrue == true)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(countInput(arr));
        }
    }
}
