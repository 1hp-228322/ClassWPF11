using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor25
    {
        int Summ = 0;
        int P = 1;
        private int[] array;
        Random random = new Random();
        private int size = 15;

        public ArrayProcessor25()
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
            foreach (int i in array)
            {
                if (i > 2)
                {
                    Summ = Summ + i;
                }

            }
            return $"Сумма четных: {Summ} Сумма нечетных : {P}";
        }
    }
}
