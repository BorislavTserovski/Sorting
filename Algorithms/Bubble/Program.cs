using System;


namespace BubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] inputLine = new[] { 1, 7, 6, 9, 87, 54, 32, 11, 7, 8 };
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < inputLine.Length - 1; i++)
                {
                    if (inputLine[i] > inputLine[i + 1])
                    {
                        var temp = inputLine[i + 1];
                        inputLine[i + 1] = inputLine[i];
                        inputLine[i] = temp;
                        isSorted = false;
                    }
                }
            }

            foreach (var num in inputLine)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
