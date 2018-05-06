using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._22
{
    class MyClass
    {
        public MyClass(int length,int width,int height)
        {
            Console.WriteLine("长方体体积为{0}", length * width * height);
        }
        public MyClass(int radius)
        {
            float f = 4 * 3.14f * radius * radius * radius / 3;
            Console.WriteLine("球体积为{0}", f);
        }
        public MyClass(int radius,params int [] a)
        {
            Console.WriteLine("Hello Params");
        }
        //以下两个构造函数列表相同，仅ref和out不同，不能重载
        /*
         * public MyClass(ref int radius)
         * {
         *    Console.WriteLine("hello ref");
         *    }
         *    */
         public MyClass(out int radius)
        {
            radius = 1;
            Console.WriteLine("hello out");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass(3);
            my =new MyClass(3, 4, 5);
            my =new MyClass(3, 4, 5, 6);
           // int i;
           //my=new MyClass(ref i);
            my = new MyClass(out int i);
        }
    }
}
