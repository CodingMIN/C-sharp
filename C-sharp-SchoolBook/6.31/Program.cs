
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySpace;
namespace MySpace
{


    class MyClassAdd
    {
        public void Add(int x, int y)
        {
            int t = x + y;
            Console.WriteLine("加法结果t={0}", t);
        }
    }
    class MyClassSub
    {
        public void Sub(int x, int y)
        {
            int t = x - y;
            Console.WriteLine("减法结果t={0}", t);
        }
    }
}
namespace _6._31
{

    class Program
    {
        static void Main(string[] args)
        {
            MyClassAdd my1 = new MyClassAdd();
            my1.Add(3, 5);
            MySpace.MyClassSub my2 = new MySpace.MyClassSub();
            my2.Sub(3, 5);
        }
    }
}
