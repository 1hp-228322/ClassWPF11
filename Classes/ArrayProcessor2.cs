using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    internal class ArrayProcessor2
    {
        private int[] array;
        Random random = new Random();
        private int size = 12;

        public ArrayProcessor2()
        {
            array = new int[size];
        }

        public string InputArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-15, 15);
            }

            return $"{array}";
        }

        public string NewArray()
        {
            int summofnumber = 0;
            foreach (int i in array)
            {
                summofnumber += i;
            }
            int average = summofnumber / array.Length;
            array[6] = average;

            return $"Старый массив {InputArray()}\nНовый массив: {array} ";
        }
    }
}

/*public double CalculateAverageOfNegativModuls()
{
    int sumOfModuls = 0;
    int countOfNegatives = 0;

    foreach (int number in array)
    {
        if (number < 0)
        {
            sumOfModuls += Math.Abs(number);
            countOfNegatives++;
        }
    }

    return countOfNegatives > 0 ? (double)sumOfModuls / countOfNegatives : 0;
}
*/