using System;

namespace ProjectEuler.Solutions.Q021
{
    class Q021
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i=2; i<10000; i++ )
            {

                int armicable = Divisors(i);
                if (armicable != i && Divisors(armicable) == i)
                {                    
                        total += i;
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }


        static int Divisors(int i)
        {
            int sum = 0;
            for(int j=1; j<i; j++)
            {
                if (i % j == 0)
                    sum += j;

            }
           
            return sum;
        }
    }
}
