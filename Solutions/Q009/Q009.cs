using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Solutions.Q009
{
    class Q009
    {
        static void Main(string[] args)
        {
            int b = 0, c = 0;

            for (int a = 0; a < 333; a++)
            {
                for (b = (a + 1); b < 500; b++)
                {
                    c = 1000 - a - b;

                    if ((c * c) == (b * b) + (a * a))
                    {
                        Console.WriteLine(a * b * c);
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}

