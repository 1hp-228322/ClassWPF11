using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor22
    {
        private int[] array;
        Random random = new Random();
        private int size = 12;

        public ArrayProcessor22()
        {
            array = new int[size];
        }


        public void InputArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-30, 30);
            }
        }

        public string CountEvenNumber()
        {
            int[] reversedArray = array.Reverse().ToArray();
            return $"Неизмененный массив: {string.Join(" ,", array)} Измененный массив : {string.Join(" ,", reversedArray)}";
        }
    }
}
