using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor14
    {
        private int[] array;
        private int size = 17;

        public ArrayProcessor14()
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

        public string ReplaceMultiplesOfThree()
        {
            int sumOfOddElements = 0;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sumOfOddElements += num;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    array[i] = sumOfOddElements;
                }
            }

            return $"Сумма нечетных элементов: {sumOfOddElements}\nМассив после замены: " + string.Join(" ", array);
        }
    }
}
