using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q004
{  
    class Q004
    {
        static void Main(string[] args)
        {
            int deger = 999, deger2 = 999, sonuc, b, a = 0;

            for (int i = deger; i >= 100; i--)
            {
                for (int j = deger2; j >= 100; j--)
                {
                    string cevir, ters = "";
                    sonuc = i * j;
                    cevir = Convert.ToString(sonuc);
                    for (int k = cevir.Length - 1; k >= 0; k--)
                    {
                        ters += cevir[k];
                    }
                    if (cevir == ters && (b = int.Parse(cevir)) > a)
                    {
                        a = b;
                    }
                }
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
