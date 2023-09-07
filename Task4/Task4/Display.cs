using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Display : AcceptNumbers
    {
        public Display(int[] numbers) : base(numbers)
        { }
        public void Print()
        {
            int[] numbers = GetNumbers();
            Console.WriteLine("Entered Numbers:- ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the numbers: " + GetSum());
            Console.WriteLine("Average of the numbers: " + GetAverage());
            Console.WriteLine("Maximum of the numbers: " + GetMaximum());
            Console.WriteLine("Minimum of the numbers: " + GetMinimum());
        }
    }
}

