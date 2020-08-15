using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETack2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числа a,b,c,d,e,f каждое в новой строке");
            double a = 0;
            a = double.Parse(Console.ReadLine());
            double b = 0;
            b = double.Parse(Console.ReadLine());
            double c = 0;
            c = double.Parse(Console.ReadLine());
            double d = 0;
            d = double.Parse(Console.ReadLine());
            double e = 0;
            e = double.Parse(Console.ReadLine());
            double f = 0;
            f = double.Parse(Console.ReadLine());
            double delta;
            delta = 0;
            delta = (a * d - c * b);
            double k;

           

            Console.WriteLine("delta = {0}", delta);
            if (delta != 0)
            {
                double x;
                double y;
                x = (e * d - f * b) / delta;

                y = (a * f - c * e) / delta;
                Console.WriteLine("x = {0}; y= {1};", x, y);
            } else 
            {
               
                Console.WriteLine("любое число, если a/c=b/d=e/f или нет решений, если a/c=b/d!=e/f");
                }
            
               Console.ReadKey();
        }
    }   
}             
