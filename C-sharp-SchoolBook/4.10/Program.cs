using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for (i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("1+2+···+100={0}", sum);
        }
    }
}
