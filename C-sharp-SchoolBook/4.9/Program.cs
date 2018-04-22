using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
            while (i <= 100)
            {
                sum += i++;
            }
            Console.WriteLine("1+2+···+100={0}", sum);
        }
    }
}
