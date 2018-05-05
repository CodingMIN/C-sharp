using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    class Myclass
    {
        public static int x = 10;
        public Myclass(int i)
        {
            x = i;          //通过构造函数为静态字段x赋值
        }
        public int GetX()            //获取静态字段x的值
        {
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my1, my2;
            Console.WriteLine("类静态字段值为{0}", Myclass.x);
            my1 = new Myclass(20);
            Console.WriteLine("my1静态字段值为{0}", my1.GetX());
            Console.WriteLine("类静态字段值为{0}", Myclass.x);
            my2 = new Myclass(30);
            Console.WriteLine("my1静态字段值为{0}", my1.GetX());
            Console.WriteLine("my2静态字段值为{0}", my2.GetX());
            Console.WriteLine("类静态字段为{0}", Myclass.x);
        }
    }
}
