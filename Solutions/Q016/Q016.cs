using System;
using System.Numerics;

namespace ProjectEuler.Solutions.Q016
{
    class Q016
    {
        static void Main(string[] args) {

            BigInteger numericBase = 2;
            BigInteger num = 0, sum = 0;
            func();

            void func()
            {
                for (int ctr = 0; ctr <= 1000; ctr++)
                {
                    num = BigInteger.Pow(numericBase, ctr);
                }
                while (num != 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                Console.WriteLine(sum);
                Console.ReadLine();
            }
        }        
    }   
}
