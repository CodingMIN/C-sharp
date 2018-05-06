using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._26
{
    class MyClass
    {
        public static int x;
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public static int Age
        {
            get;
            set;
        }
        static MyClass()
        {
            x = -1;          //为静态字段x赋值
            //y = 20;        //静态成员内部不能访问非静态成员
            Console.WriteLine("调用静态构造函数，为静态变量赋值x={0}", x);
        }
        public MyClass()
        {
            x = 20;
            Console.WriteLine("调用实例构造函数，为静态变量赋值x={0}", x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass.x = 10;   //自动调用静态构造函数
            //Console.WriteLine("为静态变量赋值后x的值为:{0}", MyClass.x);
            MyClass m = new MyClass();   //前面已调用过静态函数，这里不再调用
            Console.WriteLine("创建实例对象m后静态变量x的值为:{0}", MyClass.x);
            MyClass.Age = 30;   //调用静态属性
            m.Y = 50;  //调用非静态属性
        }
    }
}
