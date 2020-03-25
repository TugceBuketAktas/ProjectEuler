using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q006
{
    class Q006
    {
        static void Main(string[] args)
        {
            int sum = 0, square = 0, different;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                square += i * i;
            }
            different = (sum * sum) - square;
            Console.Write(different);
            Console.ReadLine();
        }
    }

}
