using System;
using System.Collections.Generic;

namespace ProjectEuler.Solutions.Q017
{
    class Q017
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            List<int> rakam = new List<int> { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4};
            int on = 70;
            List<int> onluk = new List<int> {0, 0, 6, 6, 5, 5, 5, 7, 6, 6 };
            int yuz = 7;
            int and = 3;
            int bin = 11 ;

            for (int i = 1; i < 1000; i++)
            {
                if (i < 10)
                {
                    toplam += rakam[i];
                }
                else if (i > 9 && i < 20)
                {
                    toplam += on;
                    i = 19;
                }
                else if (i > 19 && i < 100)
                {
                    
                    toplam += rakam[i % 10];
                    toplam += onluk[i / 10];
                   
                }
                else if (i == 100)
                {
                    
                    toplam = toplam * 10;
                    toplam += 9 * 99 * and;
                    toplam += 9 * 100 * yuz;
                    toplam += 100 * 36;
                    toplam += bin;
                }
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}