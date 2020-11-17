using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticZadatka5
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0;
            int karta;
            Console.WriteLine("Unesite brojeve karta (1-13): ");

            do
            {
                karta = Convert.ToInt32(Console.ReadLine());
                if (karta > 0 && karta < 14)
                {
                    zbroj = zbroj + karta;

                }
                else
                {
                    Console.WriteLine("x");
                }
            } while (zbroj < 31);
            if(zbroj == 31)
            {
                Console.WriteLine("Pobijedili ste ");

            }
            else
            {
                Console.WriteLine("Izgubili ste");
                Console.ReadKey();
            }
        }
    }
}
