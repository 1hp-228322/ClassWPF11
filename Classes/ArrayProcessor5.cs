using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor5
    {
        private int[] array;
        private int size = 9;

        public ArrayProcessor5()
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

        public string SwapMaxWithMin()
        {
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;

            return "Массив после замены максимального и минимального элементов: " + string.Join(" ", array);
        }
    }
}
