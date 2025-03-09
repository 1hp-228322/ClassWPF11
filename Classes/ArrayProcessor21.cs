using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor21
    {
        int Min;
        int Max;
        private int[] array;
        private int[] array2;
        Random random = new Random();
        private int size = 12;

        public ArrayProcessor21()
        {
            array = new int[size];
            array2 = new int[size];
            array2 = array;
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
            int Minnumber = array[0];
            int MinIndex = 0;
            int S = -1;
            for (int i = 1; i < array.Length; i++)
            {
                Minnumber = Math.Min(Minnumber, array[i]);
            }

            foreach ( int numbers in array)
            {
                S++;
                if ( numbers == Minnumber )
                {
                    MinIndex = S;
                }
            }
            array[MinIndex] = array[11];
            array[11] = Minnumber * 3;
            return $"Измененный массив: {string.Join(" ,", array)}";
        }
    }
}
