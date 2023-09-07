using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_20_03_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Parallel.For(0, 1000, i =>
            {
                int number = new Random().Next(1, 1001);
                bag.Add(number);
            }); var uniqueNumbers = bag.Distinct();
            Console.WriteLine();
            Console.WriteLine("Unique random numbers with count:");
            Parallel.ForEach(uniqueNumbers, number =>
            {
                int count = bag.Count(n => n == number);
                Console.WriteLine(number + " (" + count + ")");
            });
            Console.ReadLine();
        }
    }
}
