using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public  class ArrayProcessor28
    {
        private int[] array;
        private int size = 17;

        public ArrayProcessor28()
        {
            array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-100, 101);
            }
        }

        public string CalculateSumAndCount()
        {
            double averageOfPositives = CalculateAverageOfPositives();

            int sum = 0;
            int count = 0;

            foreach (int num in array)
            {
                if (Math.Abs(num) > averageOfPositives)
                {
                    sum += num;
                    count++;
                }
            }

            return "Сгенерированный массив: " + string.Join(" ", array) + "\n" +
                   $"Среднее арифметическое положительных элементов: {averageOfPositives:F2}\n" +
                   $"Сумма элементов, абсолютное значение которых больше среднего: {sum}\n" +
                   $"Количество таких элементов: {count}";
        }

        private double CalculateAverageOfPositives()
        {
            int sum = 0;
            int count = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    sum += num;
                    count++;
                }
            }

            return count == 0 ? 0 : (double)sum / count;
        }
    }
}
