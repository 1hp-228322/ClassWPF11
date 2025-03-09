using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor10
    {
        private int[] array;
        private int size = 17;

        public ArrayProcessor10()
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
            double averageOfNegativeModules = CalculateAverageOfNegativeModules();
            int sum = SumElementsAboveAverage(averageOfNegativeModules);
            return $"Среднее арифметическое модулей отрицательных элементов: {averageOfNegativeModules:F2}\nСумма элементов, абсолютное значение которых больше среднего: {sum}";
        }

        private double CalculateAverageOfNegativeModules()
        {
            int sum = 0;
            int count = 0;

            foreach (int num in array)
            {
                if (num < 0)
                {
                    sum += Math.Abs(num);
                    count++;
                }
            }

            return count == 0 ? 0 : (double)sum / count;
        }

        private int SumElementsAboveAverage(double average)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (Math.Abs(num) > average)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
