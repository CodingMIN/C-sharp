using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 10;
            int? b = null;
            a++;
            Console.WriteLine("a:{0}", a);
            a = a + 10;
            Console.WriteLine("a:{0}", a);
            a = a - b;
            Console.WriteLine("a:{0}", a);
            a = a / 2;
            Console.WriteLine("a:{0}", a);
        }
    }
}
