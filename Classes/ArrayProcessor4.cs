using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor4
    {
        private int[] array;
        private int size = 10;

        public ArrayProcessor4()
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

        public string SwapMaxWithFirst()
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;

            return "Массив после замены максимального и первого элементов: " + string.Join(" ", array);
        }
    }
}
