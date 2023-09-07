using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of flags to keep track of prime numbers
            bool[] primeFlags = new bool[1001];
            for (int i = 2; i <= 1000; i++)
            {
                primeFlags[i] = true;
            }

            // Use parallel library to find all prime numbers
            Parallel.For(2, 1001, i => {
                if (primeFlags[i])
                {
                    for (int j = i * 2; j <= 1000; j += i)
                    {
                        primeFlags[j] = false;
                    }
                }
            });

            // Print all prime numbers
            Console.WriteLine("Prime numbers between 1 to 1000:");
            for (int i = 2; i <= 1000; i++)
            {
                if (primeFlags[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
