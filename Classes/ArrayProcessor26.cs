using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor26
    {
        private double[] array;
        private int size = 15;

        public ArrayProcessor26()
        {
            array = new double[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-100, 101);
            }
        }


        public string CalculateDifference()
        {
            double productOfPositives = 1.0;
            double productOfNegatives = 1.0;

            foreach (double num in array)
            {
                if (num > 0)
                {
                    productOfPositives *= num;
                }
                else if (num < 0)
                {
                    productOfNegatives *= Math.Abs(num);
                }
            }

            double difference = productOfPositives - productOfNegatives;

            return "Сгенерированный массив: " + string.Join(" ", array.Select(x => x.ToString("F2")))+ "\n" + $"Произведение положительных элементов: {productOfPositives:F2}\n" +
                   $"Произведение модулей отрицательных элементов: {productOfNegatives:F2}\n" +
                   $"Разность: {difference:F2}";
        }
    }
}
