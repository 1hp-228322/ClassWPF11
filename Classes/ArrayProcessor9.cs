using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor9
    {
        private int[] array;
        private int size = 15;

        public ArrayProcessor9()
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

        public string GetDifferenceArray()
        {
            double average = CalculateAverage();
            double[] differenceArray = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                differenceArray[i] = array[i] - average;
            }

            return "Новый массив (разность между элементами исходного массива и его среднего арифметического): " + string.Join(" ", differenceArray);
        }

        private double CalculateAverage()
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }
    }
}
