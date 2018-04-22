using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 2;
            Console.WriteLine(1 + a++);           //计算1+2=3
            Console.WriteLine("a={0}", a);        //输出a的值
            Console.WriteLine(++b + 1);           //计算3+1=4
            Console.WriteLine("b={0}", b);        //输出b的值
        }
    }
}
