using System;
using System.Collections;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            for (int i = 0; true; i++)
            {
                Console.WriteLine($"Enter a positive integer at index[{i}]: ");
                var input = Console.ReadLine();
                var inputs = int.TryParse(input, out int fgh);

                if (inputs == true && int.Parse(input) < 0)
                {
                    Console.WriteLine("Input must be a positive integer");
                }
                else if (inputs == false || input == " ")
                {
                    Console.WriteLine("End of input");
                    break;
                }
                else if (!inputs == false || input == " ")
                {
                    myList.Add(int.Parse(input));
                }
            }
            Console.Write($"The sequence after being sorted in ascending order is: ");
            myList.Sort();
            foreach (var item in myList)
            {
                Console.Write(item + " ");  
            }
            Console.ReadKey();
        }
    }
}
