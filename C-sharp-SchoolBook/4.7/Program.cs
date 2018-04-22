using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
            do
            {
                sum += i;
                i++;
            } while (i <= 100);
            Console.WriteLine("1+2+3+···+100={0}", sum);
        }
    }
}
