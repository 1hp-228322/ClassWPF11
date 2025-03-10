using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor13
    {
        private int[] array;
        private int size = 15;

        public ArrayProcessor13()
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

        public string CalculateSumAndDifference()
        {
            int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            int sum = max + min;
            int difference = max - min;

            return $"Максимальный элемент: {max}\nМинимальный элемент: {min}\nСумма максимального и минимального элементов: {sum}\nРазность максимального и минимального элементов: {difference}";
        }
    }
}
