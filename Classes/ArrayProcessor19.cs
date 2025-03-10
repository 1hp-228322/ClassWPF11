using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor19
    {
        private int[] array;
        Random random = new Random();
        private int size = 19;

        public ArrayProcessor19()
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
            int S = 1;
            foreach (int i in array)
            {
                if (i > 0)
                {
                    S = S * i ;
                }
                if ( i < 0)
                {
                    break;
                }
            }
            return $"Произведение чисел до первого отрицательного: {S}";
        }
    }
}
