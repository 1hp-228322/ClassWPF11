using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor8
    {
        private double[] array;
        private int size = 16;

        public ArrayProcessor8()
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

        public string FindMinMaxIndices()
        {
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return $"Индекс минимального элемента: {minIndex}\nИндекс максимального элемента: {maxIndex}";
        }
    }
}
