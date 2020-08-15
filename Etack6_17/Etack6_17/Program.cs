using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etack6_17
{
    class Program
    {
         

        static void Main(string[] args)
        {
            Console.WriteLine("Площадь фигуры состоит из площади круга и двух криволинейных треугольников. Введите длину стороны квадрата d, площадь круга -s, площадь криволинейного треугольника-т ");
            double d;
            d = double.Parse(Console.ReadLine());
            double s;
            s = Math.Pow(d/2, 2) * Math.PI ;

            double ar;
            ar= (Math.Pow(d, 2) - s) / 2;
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}", d/2, Math.Round(s, 2));

            Console.WriteLine("Площадь фигуры равна {0}", Math.Round(ar, 2));

             Console.ReadKey();



        }
    }
}
