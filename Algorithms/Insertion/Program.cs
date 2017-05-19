using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main()
        {
            int[] input = new[] { 1, 32, 34, 42, 2, 3, 5, 65, 74, 45, 32 };
            Console.WriteLine("Unsorted - {0}", string.Join(", ", input));

            for (int i = 1; i < input.Length; i++)
            {
                int current = input[i];
                int j = i - 1;
                for (; j >= 0 && current < input[j]; j--)
                {
                    input[j + 1] = input[j];
                }
                input[j + 1] = current;

            }
            Console.WriteLine("Sorted - {0}", string.Join(", ", input));
        }
    }
}
