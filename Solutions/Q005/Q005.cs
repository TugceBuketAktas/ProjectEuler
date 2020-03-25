using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q005
{
    class Q005
    {
        static void Main(string[] args)
        {
            int deger = 0;
            for (int sayi = 1; sayi < 1000000000; sayi++)
            {
                int sayac = 0;
                for (int j = 1; j <= 20; j++)
                {
                    if ((sayi % j) == 0)
                    {
                        deger = sayi;
                        if (sayi < deger)
                        {
                            deger = sayi;
                        }
                        sayac++;
                    }
                }
                if (sayac == 20)
                {
                    Console.WriteLine(deger);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
