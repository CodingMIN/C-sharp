using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._28
{
    static class MyClass
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("结果z={0}", z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass my = new MyClass();
            // my.add(3, 5);  //不能通过实例名访问静态方法
            MyClass.Add(3, 5); //只能通过类名访问静态方法
        }
    }
}
