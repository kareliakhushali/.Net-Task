using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Employee
    {
        private int _empId;
        private string _empName;
        private int _salary; public Employee(int eid)
        {
            _empId = eid;
            _empName = string.Empty;
            _salary = 0;
        }
        public Employee(int eid, string Name, int salary)
        {
            this._empId = eid;
            this._empName = Name;
            this._salary = salary;
        }
        public bool input(Employee other)
        {
            Console.WriteLine("What Do You Want To Compare(empid,empname,salary and All):- ");
            var data = Console.ReadLine(); if (data == "empid")
            {
                if (_empId == other._empId)
                {
                    Console.WriteLine($"Employee Id:- {_empId}");
                    return true;
                }
            }
            else if (data == "empname")
            {
                if (_empName.ToLower() == other._empName.ToLower())
                {
                    Console.WriteLine($"Employee Name:- {_empName}");
                    return true;
                }
            }
            else if (data == "salary")
            {
                if (_salary == other._salary)
                {
                    Console.WriteLine($"Employee Salary:- {_salary}");
                    return true;
                }
                else if (_salary > other._salary)
                {
                    Console.WriteLine("Max:- " + _salary);
                    Console.WriteLine("Min:- " + other._salary);
                }
                else
                {
                    Console.WriteLine("Max:- " + other._salary);
                    Console.WriteLine("Min:- " + _salary);
                }
            }
            else
            {
                if (_empId == other._empId && _empName.ToLower() == other._empName.ToLower() && _salary == other._salary)
                    return true;
            }
            return false;
        }
        public void Input()
        {
            Console.WriteLine($"Enter Employee ID:-  ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Employee Name:-  ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter Salary:- ");
            int salary = Convert.ToInt32(Console.ReadLine()); Console.WriteLine($"Enter Employee ID:-  ");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter Employee Name:-  ");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Enter Salary:- ");
            int salary1 = Convert.ToInt32(Console.ReadLine()); Employee e = new Employee(id, name, salary);
            Employee e1 = new Employee(id1, name1, salary1); if (e.input(e1))
            {
                Console.WriteLine("Both are Same Object");
            }
            else
            {
                Console.WriteLine("Not Same");
            }
        }
    }
}
