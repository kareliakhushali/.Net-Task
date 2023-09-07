using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10, b = 5;

            Addition(a, b);
            Subtraction(a, b);*/
            Console.WriteLine("=========Methods are called Synchronously ");
            Demo01();
            Console.WriteLine();

             Console.WriteLine("=========Methods are called Asynchronously");
             Demo02();
             Console.WriteLine();
           
            Console.Read();
            
        }
        public static void Addition(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("-------addition() called on Thread: {0}",
                Thread.CurrentThread.ManagedThreadId);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine($"Addition of two {a} and {b} is {result}");
        }
        public static void Subtraction (int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtraction of {a} and {b} is {result}");
            Console.WriteLine("-------Subtraction() called on Thread: {0}",
                         Thread.CurrentThread.ManagedThreadId);
            System.Threading.Thread.Sleep(5000);
        }
        private static void Demo01()
        {
            System.Diagnostics.Stopwatch stopwatch
                = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            Console.WriteLine("calling Addition() from thread : {0}",
            Thread.CurrentThread.ManagedThreadId);
            Addition(10,5);

            Console.WriteLine("calling Subtraction() from thread : {0}",
              Thread.CurrentThread.ManagedThreadId);
            Subtraction(10,5);

            stopwatch.Stop();
            Console.WriteLine("Total Time Taken : {0} milliseconds",
                stopwatch.ElapsedMilliseconds);

        }

        private static void Demo02()
        {
            System.Diagnostics.Stopwatch stopwatch =
                new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            Console.WriteLine("calling Addition() from Thread:{0} Asynchronously",
                Thread.CurrentThread.ManagedThreadId);
            Thread additionThread = new Thread(() => Addition(10, 5));
            additionThread.Start();

            Console.WriteLine("calling Subtraction() from Thread:{0} Asynchronously",
                Thread.CurrentThread.ManagedThreadId);
            Thread subtractionThread = new Thread(() => Subtraction(10, 5));
            subtractionThread.Start();
           
            additionThread.Join();
            subtractionThread.Join();
            stopwatch.Stop();
            Console.WriteLine("Total Time Taken : {0} milliseconds ",
                stopwatch.ElapsedMilliseconds);


        }


    }
}
