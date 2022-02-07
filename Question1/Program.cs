using System;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            int sum = 0;
            for (int i = 0; true; i++)
            {
                Console.WriteLine($"Enter a positive integer at index[{i}]: ");
                var input = Console.ReadLine();
                var inputs = int.TryParse(input, out int fgh);
                    
                if(inputs == true && int.Parse(input) < 0)
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
                    sum += int.Parse(input);
                }
            }
                Console.WriteLine($"The sum of the sequence is {sum} and the average is {sum/2}");
            Console.ReadKey();
        }
    }
}
