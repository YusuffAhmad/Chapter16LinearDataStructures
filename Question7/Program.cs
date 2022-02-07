using System;
using System.Collections;
using System.Collections.Generic;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int[] array = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item] = (int)keyValuePairs[item] + 1;
                }
                else
                {
                    keyValuePairs.Add(item, count);
                }
            }
            foreach (var item in keyValuePairs)
            {
                Console.Write($"{item.Key} --> {item.Value} times");
            }
            Console.ReadKey();
        }
    }
}
