using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETack7_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число для выполнения действий:");
            double a1;
            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число для выполнения действий:");
            double a2;
            a2 = double.Parse(Console.ReadLine());
            double sak;
            sak = (Math.Pow(a1, 2) + Math.Pow(a2, 2))/2;
            double sam;
            //sam = (Math.Pow(Math.Abs(a1), 2) + Math.Pow(Math.Abs(a2), 2)) / 2;
            sam = (Math.Abs(a1) + Math.Abs(a2))/2;
            Console.WriteLine("Среднее арифметическое квадратов {0} , Среднее арифметическое модулей чисел {1}", Math.Round(sak,3), Math.Round(sam, 3));
            Console.ReadKey();
        }
    }
}
