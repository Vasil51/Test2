using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETack3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите зарплату сотрудника-r,процент налога за месяц и за полгода соответственно равны- t%,s%");

            double r;
            r= double.Parse(Console.ReadLine());
            double t;

            t = double.Parse(Console.ReadLine());
            double s;
            s= 6*t;
            double z1;
            double z6;

            z1 = r * (1-t/100);
            z6 =   r * (6 - s / 100);

            Console.WriteLine("z1 = {0}; z6={1}", z1, z6);

             Console.ReadKey();

        }
    }
}
