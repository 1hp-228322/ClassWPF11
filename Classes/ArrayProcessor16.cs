using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor16
    {
        
            private double[] array;
            Random random = new Random();
            private int size = 12;

            public ArrayProcessor16()
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

            public int CountEvenNumber()
            {
            return array.Length - 2;
            }

        
    }
}
