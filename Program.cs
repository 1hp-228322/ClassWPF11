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
            }
        }
    }
}
