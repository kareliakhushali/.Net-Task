using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // CountParams(42, 3.14f, "hello", 'c', 123, "world", 3.14159f, 'd');
            CountParams(42, 3.14f, "hello", 'c', 123, "world", 3.14159f, 'd');
            int result = SumOfOddNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(result); // Output: 25
            int res = SumOfEvenNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(res); // Output: 20
            string output = Concatenate("khu", "sha", "li", "", "abc", null);
            Console.WriteLine(output);
            FindBlankParams(null, "", "hello", null, "world");
            string maxString = FindMaxStringLength("Hello, world!", "This is a test", "Longest string here", "A shorter string");
            Console.WriteLine("Max string: " + maxString);
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Find the minimum value in each row
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] < min)
                    {
                        min = jaggedArray[i][j];
                    }
                }
                Console.WriteLine("Min value in row " + i + ": " + min);
            }
            int[][] jaggedArray1 = new int[3][];
            jaggedArray1[0] = new int[] { 1, 2, 3 };
            jaggedArray1[1] = new int[] { 4, 5 };
            jaggedArray1[2] = new int[] { 6, 7, 8, 9 };

            // Find the maximum value in each column

            int maxCol = jaggedArray1[0].Length;
            for (int i = 1; i < jaggedArray1.Length; i++)
            {
                if (jaggedArray1[i].Length > maxCol)
                {
                    maxCol = jaggedArray1[i].Length;
                }
            }

            for (int i = 0; i < maxCol; i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < jaggedArray1.Length; j++)
                {
                    if (i < jaggedArray1[j].Length && jaggedArray1[j][i] > max)
                    {
                        max = jaggedArray1[j][i];
                    }
                }
                Console.WriteLine("Max value in column " + i + ": " + max);
            }
            int[][] jaggedArray2 = new int[3][];
            jaggedArray2[0] = new int[] { 1, 2, 3 };
            jaggedArray2[1] = new int[] { 4, 5 };
            jaggedArray2[2] = new int[] { 6, 7, 8, 9 };

            // Find the maximum column size among all rows
            int maxCol1 = jaggedArray2[0].Length;
            for (int i = 1; i < jaggedArray2.Length; i++)
            {
                if (jaggedArray2[i].Length > maxCol1)
                {
                    maxCol1 = jaggedArray2[i].Length;
                }
            }

            // Find the minimum value in each column
            for (int i = 0; i < maxCol1; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < jaggedArray2.Length; j++)
                {
                    if (i < jaggedArray2[j].Length && jaggedArray2[j][i] < min)
                    {
                        min = jaggedArray2[j][i];
                    }
                }
                Console.WriteLine("Min value in column " + i + ": " + min);
            }

            Console.Read();
        }
        // total count
        public static void CountParams(params object[] parameters)// params keyword accepts any no of args aswell as 0 arguments
        {
            int intCount = 0;
            int floatCount = 0;
            int stringCount = 0;
            int charCount = 0;

            foreach (object param in parameters)
            {
                if (param.GetType() == typeof(int))
                {
                    intCount++;
                }
                else if (param.GetType() == typeof(float))
                {
                    floatCount++;
                }
                else if (param.GetType() == typeof(char))
                {
                    charCount++;

                }
                else if (param.GetType() == typeof(string))
                {
                    stringCount++;
                }
            }
            Console.WriteLine("Integer count: " + intCount);
            Console.WriteLine("Float count: " + floatCount);
            Console.WriteLine("String count: " + stringCount);
            Console.WriteLine("Char count: " + charCount);
        }
        // sum of odd nos
        public static int SumOfOddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum;

        }
        //sum of even nos
        public static int SumOfEvenNumbers(params int[] nos)
        {
            int sum = 0;
            foreach (int no in nos)
            {
                if (no % 2 == 0)
                {
                    sum += no;
                }
            }
            return sum;

        }
        //string concatenate
        public static string Concatenate(params string[] strings)
        {
            string output = "";
            foreach (var s in strings)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    output = output + s;
                }
            }
            return output;

        }
        public static void FindBlankParams(params object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == null || parameters[i].ToString() == "")
                {
                    Console.WriteLine($"Parameter {i} is blank.");
                }
            }
        }
        public static string FindMaxStringLength(params string[] strings)
        {
            string maxString = null;
            int maxLength = 0;

            foreach (string s in strings)
            {
                int length = s.Replace(" ", "").Length;
                if (length > maxLength)
                {
                    maxString = s;
                    maxLength = length;
                }
            }

            return maxString;
        }

       

    
   




    }
}
