using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor17
    {
        int Summ = 0;
        int P = 1;
        int Zero = 0;
        private double[] array;
        Random random = new Random();
        private int size = 15;

        public ArrayProcessor17()
        {
            array = new double[size];
        }


        public void InputArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-15, 15);
            }
        }

        public string CountEvenNumber()
        {
            foreach (int i in array)
            {
                if (i> 0)
                {
                    Summ++;
                }
                if (i> 0)
                {
                    P = P * i;
                }
                if (i == 0)
                {
                    Zero++;
                }
                
            }
            List<int> list = new List<int>();
            list.Add(Summ);
            list.Add(Zero);
            list.Add(P);
            return $"Ответ: 1 число сумма положительных чисел, 2 число сумма нулей, 3 число произведение отрицательных чисел {string.Join(" ",list)}";
        }
    }
}
