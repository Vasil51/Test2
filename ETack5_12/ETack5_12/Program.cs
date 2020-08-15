using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETack5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите объемы воды -v1,v2;температуры t1,t2");
            double v1 = 0;
            v1 = double.Parse(Console.ReadLine());
            double v2 = 0;
            v2 = double.Parse(Console.ReadLine());
            double t1 = 0;
            t1 = double.Parse(Console.ReadLine());
            double t2 = 0;
            t2 = double.Parse(Console.ReadLine());
            double v = 0;
            v = v1 + v2;
            double t = 0;
            t = (v1 * t1 + v2 * t2)/(v1+v2);
            
                Console.WriteLine("v = {0}; t= {1};", v, t);
            

            Console.ReadKey();






        }
    }
}
