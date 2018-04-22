using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入6个字符:");
            string str = Console.ReadLine();
            if (str.Length != 6)
                Console.WriteLine("您输入的字符位数不正确!");
        }
    }
}
