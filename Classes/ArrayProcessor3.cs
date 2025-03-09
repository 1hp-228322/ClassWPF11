using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor3
    {
        private int[] array;
        private int size = 11;

        public ArrayProcessor3()
        {
            array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-100, 101);
            }
        }

        public string GetArrayAsString()
        {
            return "Сгенерированный массив: " + string.Join(" ", array);
        }

        public string CalculateResult()
        {
            double average = CalculateAverage();
            int count = CountElementsAboveAverageAbsolute(average);
            return $"Среднее арифметическое: {average:F2}\nКоличество элементов, абсолютное значение которых больше среднего: {count}";
        }

        private double CalculateAverage()
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }

        private int CountElementsAboveAverageAbsolute(double average)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (Math.Abs(num) > average)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
