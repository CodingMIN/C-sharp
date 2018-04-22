using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            while(s!="0")
            {
                Console.WriteLine("请输入一个字符串:");
                s=Console.ReadLine();
                Console.WriteLine("您输入的是:" + s);
            }
        }
    }
}
