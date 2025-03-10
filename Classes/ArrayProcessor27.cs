using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor27
    {
        private int[] array;
        private int size = 19;

        public ArrayProcessor27()
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

        public string ReplaceEvenElementsWithMax()
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = max;
                }
            }

            return "Сгенерированный массив: " + string.Join(" ", array) + "\n" + 
                $"Максимальное число: {max}\n" +
                $"Массив после замены четных элементов: " + 
                string.Join(" ", array);
        }
    }
}
