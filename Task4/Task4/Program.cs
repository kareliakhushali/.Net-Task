using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter ten Numbers:-");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Display display = new Display(numbers);
            display.Print();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Current current = new Current("khushali Karelia", 123456789, 1000000);
            current.Deposit(200000);
            current.DisplayBalance();
            current.Withdraw(200000);
            current.DisplayBalance(); 
            Savings saving = new Savings("khushi Patel",123456789, 2000000);
            saving.Deposit(200000);
            saving.DisplayBalance();
            Console.Read();
        }

        

       
    }
    
}
