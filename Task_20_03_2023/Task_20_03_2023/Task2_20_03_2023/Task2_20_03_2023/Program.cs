using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_20_03_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array to store the result
            int[] results = new int[1000 / 7];// 1000/7 becuase it is divisible by 7
            //using parallel library

            Parallel.For(1, 1000 / 7, i => //parallel.for will start the multiple tasks and iterate 
            // from 1 to 1000 numbers and will check that are multiples of 7
                {

                    int num = i * 7;//multiples of 7
                    if(num<=1000 && num%7==0)// it will check if it is less than or equal to 1000 and divisible by 7
                    {
                        results[i - 1] = num;//stores that number which satisfies the above condition in the result array
                    }
                });
            // printing the output 
            foreach(int num in results)
            {

                if(num!=0)//allows only non zero values
                {

                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();

        }
    }
}
