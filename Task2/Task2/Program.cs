using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee();
            e.Input();
            e1.Input();
            int a = 5;
            int b = 10;
            string s = "123";
            float f = 0.12f;
            GetObjectType(a, b);
            GetObjectType("abc", s);
            GetObjectType(a, s);
            GetObjectType('c', "abc");
            GetObjectType("abc", f);
            GetObjectType(0.01f, f);
            GetObjectType(12, f);
            Console.Read();

        }
        public static void GetObjectType(object o1,object o2)
        {
            if (o1 is int && o2 is string)
            {
                Console.WriteLine("Integer");
            }
            else if (o1 is string && o2 is string)
            {
                Console.WriteLine("String");

            }
            else if (o1 is int && o2 is string)
            {
                Console.WriteLine("String");

            }
            else if(o1 is char && o2 is string)
            {
                Console.WriteLine("String");
            }
            else if (o1 is string && o2 is float)
            {
                Console.WriteLine("String");
            }
            else if (o1 is float && o2 is float)
            {
                Console.WriteLine("Float");
            }
            else if (o1 is int && o2 is float)
            {
                Console.WriteLine("Float");
            }
        }


    }
}
