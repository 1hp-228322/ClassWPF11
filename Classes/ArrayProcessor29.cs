using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    internal class ArrayProcessor29
    {
        private double[] array;
        private int size = 18;

        public ArrayProcessor29()
        {
            array = new double[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.NextDouble() * 200 - 100;
            }
        }

        public string GetArrayAsString()
        {
            return "Сгенерированный массив: " + string.Join(" ", array.Select(x => x.ToString("F2")));
        }

        public string CalculateQuotient()
        {
            double productOfPositives = 1.0;
            double sumOfNegatives = 0.0;

            foreach (double num in array)
            {
                if (num > 0)
                {
                    productOfPositives *= num;
                }
                else if (num < 0)
                {
                    sumOfNegatives += Math.Abs(num);
                }
            }

            double quotient = sumOfNegatives == 0 ? 0 : productOfPositives / sumOfNegatives;

            return "Сгенерированный массив: " + string.Join(" ", array.Select(x => x.ToString("F2"))) + "\n" +
                   $"Произведение положительных элементов: {productOfPositives:F2}\n" +
                   $"Сумма модулей отрицательных элементов: {sumOfNegatives:F2}\n" +
                   $"Частное: {quotient:F2}";
        }
    }
}
