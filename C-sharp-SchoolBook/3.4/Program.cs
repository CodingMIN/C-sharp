using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2;
            if (a > b && a++ > b--)
                Console.WriteLine("a={0} b={1}", a, b);
            if (a > b || a-- > b++)
                Console.WriteLine("a={0} b={1}", a, b);
        }
    }
}
