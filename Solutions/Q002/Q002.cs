using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q002
{
    class Q002
    {
        static void Main(string[] args)
        {
            int ilkDeger = 1, ikinciDeger = 2, sonuc, ciftlerinToplami = 0;

            while (ilkDeger <= 4000000)
            {
                if ((ilkDeger % 2) == 0) ciftlerinToplami += ilkDeger;
                sonuc = ilkDeger + ikinciDeger;
                ilkDeger = ikinciDeger;
                ikinciDeger = sonuc;
            }

            Console.WriteLine(ciftlerinToplami);
            Console.ReadLine();
        }
    }
}
