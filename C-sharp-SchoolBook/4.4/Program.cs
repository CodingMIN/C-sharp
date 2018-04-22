using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine("您输入的不是一个正整数");
            else if (n <= 10)
                Console.WriteLine("您输入的是一个一位数");
            else if (n <= 100)
                Console.WriteLine("您输入的是一个二位数");
            else if (n <= 1000)
                Console.WriteLine("您输入的是一个三位数");
            else
                Console.WriteLine("您输入的是一个四位或四位以上的数");
        }
    }
}
