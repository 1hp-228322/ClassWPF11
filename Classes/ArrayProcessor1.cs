using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor1
    {
        private int[] array;
        Random random = new Random();
        private int size = 14;

        public ArrayProcessor1()
        {
            array = new int[size];
        }


        public void InputArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-15, 15);
            }
        }

        public int ArrayLength()
        {
            return array.Length;
        }

        public int[] ArrayData()
        {
            return array;
        }

        public int CountEvenNumber()
        {
            int evenCount = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }
            return evenCount;
        }

    }
}
