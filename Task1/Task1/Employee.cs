using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee
    {
        private int _empId;//private field 
        public int EmpId
        //The public properties EmpId, NetSalary, and Bonus use getter and setter methods
        //to access the private fields _empId, _netSalary, and _bonus.
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public string Name { get; set; }
        public int Salary { get; set; }
        private int _netSalary;
        public int NetSalary
        {
            get { return _netSalary; }
            set { _netSalary = value; }
        }
        private int _bonus;
        public int Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
    }
}
