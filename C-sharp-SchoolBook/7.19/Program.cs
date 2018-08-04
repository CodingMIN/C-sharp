using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string s;
            Console.Write("请输入一个除数:");
            s = Console.ReadLine();
            a = int.Parse(s);
            Console.Write("请输入一个被除数:");
            s = Console.ReadLine();
            b = int.Parse(s);
            Console.WriteLine("商为{0}", a / b);
        }
    }
}
