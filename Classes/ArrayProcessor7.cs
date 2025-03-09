using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor7
    {
        private double[] array;
        private int size = 15;

        public ArrayProcessor7()
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

        public string CalculateResult()
        {
            double firstElement = array[0];
            int count = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > firstElement)
                {
                    count++;
                }
            }

            return $"Первый элемент: {firstElement:F2}\nКоличество элементов, значения которых больше первого: {count}";
        }
    }
}
