using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            do
            {
                if (s != null) Console.WriteLine("您输入的是:" + s);
                Console.WriteLine("请输入字符串，输入0表示结束:");
                s = Console.ReadLine();
            } while (s != "0");
        }
    }
}
