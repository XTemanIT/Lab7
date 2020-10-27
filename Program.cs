using System;
using System.Collections.Generic;

namespace Lab1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c0 = 0;
            int[] arr = new int[10];
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                N = Convert.ToInt32(Console.ReadLine());
                numbers.Add(N);
                if (N == 1)
                {
                    c1++;
                }
                else if (N == 2)
                {
                    c2++;
                }
                else if (N == 3)
                {
                    c3++;
                }
                else if (N == 4)
                {
                    c4++;
                }
                else if (N == 5)
                {
                    c5++;
                }
                else if (N == 6)
                {
                    c6++;
                }
                else if (N == 7)
                {
                    c7++;
                }
                else if (N == 8)
                {
                    c8++;
                }
                else if (N == 9)
                {
                    c9++;
                }
                else if (N == 0)
                {
                    c0++;
                }
            }
            arr[1] = c1;arr[2] = c2; arr[3] = c3; arr[4] = c4; arr[5] = c5; arr[6] = c6; arr[7] = c7; arr[8] = c8; arr[9] = c9; arr[0] = c0;

            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }
    }
}
