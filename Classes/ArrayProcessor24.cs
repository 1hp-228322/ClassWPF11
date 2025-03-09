using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor24
    {
        int Summ = 0;
        int Quantity = 0;
        private int[] array;
        Random random = new Random();
        private int size = 12;

        public ArrayProcessor24()
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
                if (i < array[11])
                {
                    Summ = Summ + i;
                    Quantity++;
                }

            }
            return $"Сумма меньших последнему значению: {Summ} и их количество : {Quantity}";
        }
    }
}
