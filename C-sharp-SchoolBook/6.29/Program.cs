using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._29
{
    partial class MyClass
    {
        public void Add(int x,int y)
        {
            int t = x + y;
            Console.WriteLine("结果t={0}", t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.Add(3, 5);
            my.Add(3, 4, 5);
        }
    }
}
