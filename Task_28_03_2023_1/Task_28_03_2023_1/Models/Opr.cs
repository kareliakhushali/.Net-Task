using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_28_03_2023_1.Models
{
    public class Opr
    {
        public static int Add(int no1, int no2)
        {
            return no1 + no2;
        }
        public static int Sub(int no1, int no2)
        {
            int ans = no1 - no2;
            return Math.Abs(ans);
        }
        public static int Mul(int no1, int no2)
        {
            return no1 * no2;
        }
        public static float Div(int no1, int no2)
        {
            return no1 / no2;
        }
        public static double Pow(int no1, int no2)
        {
            double ans = Math.Pow(no1, no2);
            return ans;
        }
        public static string tolower(string data)
        {
            string ans = data.ToLower();
            return ans;
        }
        public static string toupper(string data)
        {
            string ans = data.ToUpper();
            return ans;
        }
        public static string count(string data)
        {
            string ans = data.Length.ToString();
            return ans;
        }
    }
}
