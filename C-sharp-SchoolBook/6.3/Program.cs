using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Myclass
    {
        public Myclass(int i) {
            Console.WriteLine("调用了构造函数");
            Console.WriteLine("传递的值为{0}", i);
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass(100);
        }
    }
}
