using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class MyBaseClass
    {
        public int Add(int x,int y)
        {
            Console.WriteLine("调用基类Add()方法");
            return x + y;
        }
    }

    class MySubClass:MyBaseClass
    {
        public new int Add(int x,int y)
        {
            Console.WriteLine("调用派生类的Add()方法");
            return base.Add(x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MySubClass m = new MySubClass();
            Console.WriteLine(m.Add(3,2));
        }
    }
}
