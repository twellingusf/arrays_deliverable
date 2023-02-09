using System;

namespace arrays_deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = (25);
            int[] fibonacci = new int[input];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 0; i < input; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }   
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
                  while (i == 46368)
                    {
                        break;
                    }
            }
        }
    }
}