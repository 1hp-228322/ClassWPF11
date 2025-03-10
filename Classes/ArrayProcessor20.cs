using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor20
    {    
            private int[] array;
            Random random = new Random();
            private int size = 16;

            public ArrayProcessor20()
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
            int Index =-1;
            int S = 0;
                foreach (int i in array)
                {
                    Index++;
                    if (i % 3 == 0)
                    {
                    array[Index] = 0;
                    }

                }
                return $"Все числа в массиве, кратные трем, заменены нулями: {string.Join(" ,",array)}";
            }
        
            
        
    }
}
