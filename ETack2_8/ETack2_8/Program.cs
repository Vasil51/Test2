using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETack2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите cумму денег положенную на депозит и процент начисления : сумма вклада-d ,p-процент начисления, сумма полученная -s");
           double d ;
            d = double.Parse(Console.ReadLine());
            double p ;

            p = double.Parse(Console.ReadLine());
            double s ;
                        
            s =d* Math.Pow(p, 4);
             
            Console.WriteLine("s = {0}", s);
           

            Console.ReadKey();
        }
    }
}             


        
