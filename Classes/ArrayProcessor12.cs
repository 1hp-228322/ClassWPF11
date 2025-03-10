using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor12
    {
        private double[] array;
        private int size = 12;

        public ArrayProcessor12()
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

        public string SortAndCalculateSum()
        {

            Array.Sort(array);
            Array.Reverse(array);

            double max = array[0];
            double min = array[array.Length - 1];
            double sum = max + min;

            return $"Отсортированный массив (по убыванию): " + string.Join(" ", array.Select(x => x.ToString("F2"))) +
                   $"\nМаксимальный элемент: {max:F2}" +
                   $"\nМинимальный элемент: {min:F2}" +
                   $"\nСумма максимального и минимального элементов: {sum:F2}";
        }
    }
}
