using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._15
{
    class ClassA
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y, double z)
        {
            return x + y + z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4;
            double c = 3.1, d = 4.1, e = 5.1;
            Console.WriteLine("编译时多态性:");
            ClassA obj = new ClassA();
            Console.WriteLine(obj.Add(a, b));
            Console.WriteLine(obj.Add(c, d, e));
        }
    }
}
