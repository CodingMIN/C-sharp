using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
            for (; ; )
            {
                sum += i;
                i++;
               // if (i > 100) break;
            }
            Console.WriteLine("1+2+···+100={0}", sum);
        }
    }
}
