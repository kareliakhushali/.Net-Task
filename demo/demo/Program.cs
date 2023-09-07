using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string output = "";

        foreach (char c in input)
        {
            int asciiValue = (int)c;
            asciiValue += 3;
            output += (char)asciiValue;
        }

        Console.WriteLine("Output: " + output);
    }
}

