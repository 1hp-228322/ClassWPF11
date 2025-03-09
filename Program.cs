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

                case 2:
                    ArrayProcessor2 class2 = new ArrayProcessor2();

                    class2.InputArray();

                    Console.WriteLine(class2.NewArray());

                    break;

                case 3:
                    ArrayProcessor3 class3 = new ArrayProcessor3();
                    Console.WriteLine(class3.GetArrayAsString());
                    Console.WriteLine(class3.CalculateResult());

                    break;

                case 4:
                    ArrayProcessor4 class4 = new ArrayProcessor4();
                    Console.WriteLine(class4.GetArrayAsString());
                    Console.WriteLine(class4.SwapMaxWithFirst());

                    break;

                case 5:
                    ArrayProcessor5 class5 = new ArrayProcessor5();
                    Console.WriteLine(class5.GetArrayAsString());
                    Console.WriteLine(class5.SwapMaxWithMin());

                    break;

                case 6:
                    ArrayProcessor6 class6 = new ArrayProcessor6();
                    Console.WriteLine(class6.GetArrayAsString());
                    Console.WriteLine(class6.CountEvenAndOdd());

                    break;

                case 7:
                    ArrayProcessor7 class7 = new ArrayProcessor7();
                    Console.WriteLine(class7.GetArrayAsString());
                    Console.WriteLine(class7.CalculateResult());

                    break;

                case 8:
                    ArrayProcessor8 class8 = new ArrayProcessor8();
                    Console.WriteLine(class8.GetArrayAsString());
                    Console.WriteLine(class8.FindMinMaxIndices());

                    break;

                case 9:
                    ArrayProcessor9 class9 = new ArrayProcessor9();
                    Console.WriteLine(class9.GetArrayAsString());
                    Console.WriteLine(class9.GetDifferenceArray());

                    break;

                case 10:
                    ArrayProcessor10 class10 = new ArrayProcessor10();
                    Console.WriteLine(class10.GetArrayAsString());
                    Console.WriteLine(class10.CalculateResult());


                    break;

                case 11:
                    ArrayProcessor11 class11 = new ArrayProcessor11();
                    Console.WriteLine(class11.GetArrayAsString());
                    Console.WriteLine(class11.CalculateEvenPositiveElements());

                    break;

                case 12:
                    ArrayProcessor12 class12 = new ArrayProcessor12();
                    Console.WriteLine(class12.GetArrayAsString());
                    Console.WriteLine(class12.SortAndCalculateSum());

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

                case 20:

                    ArrayProcessor20 class20 = new ArrayProcessor20();

                    class20.InputArray();

                    Console.WriteLine($" {class20.CountEvenNumber()}");

                    break;

                case 21:

                    ArrayProcessor21 class21 = new ArrayProcessor21();

                    class21.InputArray();

                    Console.WriteLine($" {class21.CountEvenNumber()}");

                    break;

                case 22:

                    ArrayProcessor22 class22 = new ArrayProcessor22();

                    class22.InputArray();

                    Console.WriteLine($" {class22.CountEvenNumber()}");

                    break;

                case 23:

                    ArrayProcessor23 class23 = new ArrayProcessor23();

                    class23.InputArray();

                    Console.WriteLine($" {class23.CountEvenNumber()}");

                    break;

                case 24:

                    ArrayProcessor24 class24 = new ArrayProcessor24();

                    class24.InputArray();

                    Console.WriteLine($" {class24.CountEvenNumber()}");

                    break;
            }
        }
        
    }
}
