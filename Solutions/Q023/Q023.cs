using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Solutions.Q023
{
    class Q023
    {
        static void Main(string[] args)
        {
            int artikMi;
            int tamBolunenlerinToplami = 0;
            List<int> ikiArtikDegerinToplami = new List<int>();
            ArrayList arrayList = new ArrayList();
            List<int> intArray = new List<int>();
            int toplam = 0, sınır = 28123;
            int toplam2 = 66; // 1+2+..+11 toplamları
            int[] array = new int[7000]; //6964

            for (int i = 12; i<sınır; i++)
            {
                tamBolunenlerinToplami = 0;
                artikMi = i;
                for (int j = 1; j < artikMi; j++)
                {
                    if(artikMi % j == 0) tamBolunenlerinToplami += j;
                    
                }
                if (tamBolunenlerinToplami > artikMi)
                {
                    arrayList.Add(artikMi);
                    arrayList.CopyTo(array);
                  
                }

                toplam2 += i;

            }

            for(int t = 0; t < arrayList.Count; t++)
            {
                for (int k = 0; k < arrayList.Count; k++)
                {
                    int deger = (int)arrayList[t] + array[k];
                    if (deger < 28123) intArray.Add(deger);                                    
                }
               
            }

            ikiArtikDegerinToplami = intArray.Distinct().ToList();

            foreach (var item in ikiArtikDegerinToplami)
            {
                toplam += item;
            }
    
            Console.WriteLine(toplam2 - toplam);   
            Console.ReadLine();

        }
    }
}
