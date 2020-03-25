using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q010
{
    class Q010
    {
        static void Main(string[] args)
        {
            long toplam = 2;

            for (int deger = 3; deger < 2000000; deger += 2)
            {
                int sayac = 1;
                for (int i = 2; i <= Math.Sqrt(deger); i++)
                {
                    if (deger % i == 0)
                    {
                        sayac++;
                        break;
                    }
                }
                if (sayac == 1)
                    toplam += deger;
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
