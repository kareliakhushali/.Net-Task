using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class AcceptNumbers
    {
        private int[] numbers;
        public AcceptNumbers(int[] numbers)
        {
            this.numbers = numbers;
        }
        public int[] GetNumbers()
        {
            return this.numbers;
        }
        public int GetSum()
        {
            int sum = 0;
            foreach (int number in this.numbers)
            {
                sum += number;
            }
            return sum;
        }
        public double GetAverage()
        {
            int sum = GetSum();
            return (double)sum / this.numbers.Length;
        }
        public int GetMaximum()
        {
            int maximum = this.numbers[0];
            for (int i = 1; i < this.numbers.Length; i++)
            {
                if (this.numbers[i] > maximum)
                {
                    maximum = this.numbers[i];
                }
            }
            return maximum;
        }
        public int GetMinimum()
        {
            int minimum = this.numbers[0];
            for (int i = 1; i < this.numbers.Length; i++)
            {
                if (this.numbers[i] < minimum)
                {
                    minimum = this.numbers[i];
                }
            }
            return minimum;
        }
    }
}
