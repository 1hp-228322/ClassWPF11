using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11.Classes
{
    public class ArrayProcessor18
    {
            private int[] array;
            Random random = new Random();
            private int size = 12;

            public ArrayProcessor18()
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

            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }
            List<int> list = new List<int>();
            list.Add(min);
            list.Add(max);
            return $"Интервал: ({string.Join(",", list)})";
            }
        
            
        
    }
}
