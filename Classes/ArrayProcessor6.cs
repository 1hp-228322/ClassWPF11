using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor6
    {
        private int[] array;
        private int size = 20;

        public ArrayProcessor6()
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

        public string CountEvenAndOdd()
        {
            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            if (evenCount > oddCount)
            {
                return "Четных элементов больше.";
            }
            else if (oddCount > evenCount)
            {
                return "Нечетных элементов больше.";
            }
            else
            {
                return "Количество четных и нечетных элементов одинаково.";
            }
        }
    }
}
