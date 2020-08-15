using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETack3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите розничную стоимость костюма-R,оптовая цена - С, наценка -T%");
            double R;
            R = double.Parse(Console.ReadLine());
            double T;

            T = double.Parse(Console.ReadLine());
            double C;

            C = R / (1 + T / 100);
                
            Console.WriteLine("C = {0}", C);

            Console.ReadKey();
        }
    }
}
