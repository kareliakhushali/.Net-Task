
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the size of the elements: ");
            int size = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.ResetColor();
                    i--;
                }
                else
                {
                    numbers.Add(number);
                }
            }


            // find the upper sum
            int upperSum = numbers[0] + numbers[1];
            // to find lower sum
            int lowerSum = numbers[numbers.Count - 1] + numbers[numbers.Count - 2];
            //sum of all elements
            int sum = numbers.Sum();
            foreach (int number in numbers)
            {
                sum += number;
            }

            // to find the maximum value among the upper and lower sum
            int max = Math.Max(upperSum, lowerSum);

            // to find the minimum value among the upper and lower sum
            int min = Math.Min(upperSum, lowerSum);

            
            Console.WriteLine("Upper Sum = {0}", upperSum);
            Console.WriteLine("Lower Sum = {0}", lowerSum);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Maximum Value = {0}", max);
            Console.WriteLine("Minimum Value = {0}", min);
            Console.ReadLine();
        }
    }
    }

