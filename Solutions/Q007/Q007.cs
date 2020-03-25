using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q007
{
    class Q007
    {
        static void Main(string[] args)
        {
            int asalSayıcım = 1, degerim = 3, bolenSayi;
            for (int a = 1; a <= 500001; a++)
            {
                bolenSayi = 0;
                for (int i = 2; i <= degerim; i++)
                {
                    if (degerim % i == 0)
                    {
                        bolenSayi++;
                        if (bolenSayi > 1)
                            continue;
                        if (asalSayıcım == 10001)
                        {
                            Console.WriteLine(degerim - 2);
                            Console.ReadLine();
                            break;
                        }
                    }
                }
                if (bolenSayi == 1)
                {
                    asalSayıcım++;
                }
                degerim += 2;
            }
        }
    }
}
