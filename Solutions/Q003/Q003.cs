using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q003
{
    class Q003
    {
        static void Main(string[] args)
        {
            long deger = 600851475143, enBuyukBolen = 0, carpim = 1;
            for (long i = 2; i <= deger; i++)
            {
                if ((deger % i) == 0)
                {
                    enBuyukBolen = i;
                    carpim *= enBuyukBolen;
                    if ((deger / carpim) == 1)
                    {

                        Console.WriteLine(enBuyukBolen);
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
