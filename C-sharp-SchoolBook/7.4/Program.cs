using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    class MyBaseClass
    {
        int[] a;
        public MyBaseClass()
        {
            a = new int[10];
            Console.WriteLine("调用基类MyBaseClass第一个构造函数");
        }
        public MyBaseClass(int count)
        {
            a = new int[count];
            Console.WriteLine("调用基类MyBaseClass第二个构造函数");
        }
        public int Add(int x,int y)
        {
            return x + y;
        }
        ~MyBaseClass()
        {
            Console.WriteLine("调用基类MyBaseClass的析构函数");
        }
    }

    class MySubClass:MyBaseClass
    {
        int x;
        public MySubClass()           //默认会调用基类的不带参数的构造函数
        {
            x = 0;
            Console.WriteLine("调用派生类MySubClass第一个构造函数");
        }
        public MySubClass(int count)
            :base(count)            //显示调用基类构造函数
        {
            x = count;
            Console.WriteLine("调用派生类MySubClass第二个构造函数");
        }
        public int Sub(int x,int y)
        {
            return x - y;
        }
        ~MySubClass()
        {
            Console.WriteLine("调用派生类MySubClass的析构函数");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MySubClass m = new MySubClass();
            Console.WriteLine(m.Add(3, 2));
            Console.WriteLine(m.Sub(3, 2));
            MySubClass n = new MySubClass(10);
        }
    }
}
