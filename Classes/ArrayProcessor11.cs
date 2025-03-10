using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor11
    {
        private int[] array;
        private int size = 14;

        public ArrayProcessor11()
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

        public string CalculateEvenPositiveElements()
        {
            int count = 0;
            int sum = 0;

            foreach (int num in array)
            {
                if (num > 0 && num % 2 == 0)
                {
                    count++;
                    sum += num;
                }
            }

            return $"Количество четных положительных элементов: {count}\nСумма четных положительных элементов: {sum}";
        }
    }
}
