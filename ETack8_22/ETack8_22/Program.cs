using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETack8_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорости первого и второго автомобилей - v1.v2.Время -T. Расстояние между автомобилями в начале движения S");
            double v1;
            v1 = double.Parse(Console.ReadLine());
            double v2;
            v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите время и путь в начале движения ");
            double T;
            T = double.Parse(Console.ReadLine());
            double S;
            S = double.Parse(Console.ReadLine());
            double s;
            s = S + v1 * T + v2 * T; 
            
            Console.WriteLine("Расстояние между автомобилями через T часов {0}:", s);
            Console.ReadKey();
        }
    }
}
