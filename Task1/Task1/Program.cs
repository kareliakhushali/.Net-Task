using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e;
            e = new Employee();
            Console.Write("Enter Employee ID:- ");
            e.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:- ");
            e.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Salary:- ");
            e.Salary = Convert.ToInt32(Console.ReadLine());
            if (e.Salary >= 6000 && e.Salary < 10000)
            {
                e.Bonus = e.Salary * 5 / 100;
            }
            else if (e.Salary >= 10000 && e.Salary < 20000)
            {
                e.Bonus = e.Salary * 10 / 100;
            }
            else if (e.Salary >= 20000 && e.Salary < 30000)
            {
                e.Bonus = e.Salary * 15 / 100;
            }
            else
            {
                e.Bonus = e.Salary * 17 / 100;
            }
            e.NetSalary = e.Bonus + e.Salary; Console.WriteLine("----------Record Details---------------"); Console.WriteLine($"Enployee Id:- {e.EmpId}");
            Console.WriteLine($"Employee Name:- {e.Name}");
            Console.WriteLine($"Employee Salary:- {e.Salary}");
            Console.WriteLine($"Employee Bonus:- {e.Bonus}");
            Console.WriteLine($"Employee Netsalary:- {e.NetSalary}");
            Console.Read();
        }
    }
}
    
