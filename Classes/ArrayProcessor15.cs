using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor15
    {
        private double[] array;
        private int size = 14;

        public ArrayProcessor15()
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

        public string SortArray()
        {
            Array.Sort(array, 0, 7);    
            Array.Sort(array, 7, 7);
            Array.Reverse(array, 7, 7);

            return "Массив после сортировки: " + string.Join(" ", array.Select(x => x.ToString("F2")));
        }
    }
}
