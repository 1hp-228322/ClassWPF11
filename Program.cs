using ClassWPF11.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWPF11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №11");
            Console.WriteLine("Введите номер задания от 1 до 30:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {

                case 1:

                    ArrayProcessor1 class1 = new ArrayProcessor1();

                    class1.InputArray();

                    Console.WriteLine($"Кол-во четных элементов в массиве {class1.CountEvenNumber()}");

                    break;

                case 16:

                    ArrayProcessor16 class16 = new ArrayProcessor16();

                    class16.InputArray();

                    Console.WriteLine($"Чисел между минимальным и максимальным:{class16.CountEvenNumber()}");

                    break;

                case 17:

                    ArrayProcessor17 class17 = new ArrayProcessor17();

                    class17.InputArray();

                    Console.WriteLine($" {class17.CountEvenNumber()}");

                    break;

                case 18:

                    ArrayProcessor18 class18 = new ArrayProcessor18();

                    class18.InputArray();

                    Console.WriteLine($" {class18.CountEvenNumber()}");

                    break;

                case 19:

                    ArrayProcessor19 class19 = new ArrayProcessor19();

                    class19.InputArray();

                    Console.WriteLine($" {class19.CountEvenNumber()}");

                    break;
            }
        }
    }
}
