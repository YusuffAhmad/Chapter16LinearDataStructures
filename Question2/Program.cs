using System;
using System.Collections.Generic;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            int numberLenght = 6;
            for (int i = 0; i < numberLenght; i++)
            {
                Console.WriteLine($"Enter the integer at index {i+1} of a list of 6 numbers: ");
                var input = int.Parse(Console.ReadLine());
                myStack.Push(input);
            }
            Console.WriteLine($"The reverse order of the input is ");
            foreach (var item in myStack)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
