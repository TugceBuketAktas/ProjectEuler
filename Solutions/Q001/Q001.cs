using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q001
{
    class Q001
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;

            for (int num1 = 1; num1 < 1000; num1++)
            {
                if (num1 % 3 == 0 || num1 % 5 == 0)
                {
                    sum += num1;

                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
