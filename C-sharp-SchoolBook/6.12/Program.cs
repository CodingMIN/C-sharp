using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._12
{
    class Myclass
    {
        public void SquareVal(int i)
        {
            Console.WriteLine("方法调用中形参i的初始值为{0}", i);
            i = i * i;
            Console.WriteLine("方法调用中形参i修改后的值为{0}", i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            int x = 3;
            Console.WriteLine("方法调用前实参x的值为{0}", x);
            my.SquareVal(x);
            Console.WriteLine("方法调用后实参x的值为{0}", x);
        }
    }
}
