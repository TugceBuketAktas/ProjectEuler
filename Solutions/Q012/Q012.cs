using System;

namespace ProjectEuler.Solutions.Q012
{
    class Q012
    {
        static void Main (string[] args)
        {
            var j = 1;
            var kosul = true;
            
            while (kosul)
            {
                var deger = j * (j + 1) / 2;
                var sayac = 0;
                for (var i = 1; i <= Math.Sqrt(deger); i++)
                {
                    if (deger % i == 0)
                    {
                        sayac+=2;
                    }

                }                   
                if (sayac >= 500)
                {
                    Console.WriteLine(deger);
                    Console.ReadLine();
                    kosul = false;
                }
                j++;
            }
        }
           
    }
    
}
