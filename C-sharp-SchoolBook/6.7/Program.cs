using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _6._7
{
    class Myclass
    {
        public const int x = 10;


        //public const DataTime dt=new DataTime(2013,1,1)  //结构体不能定义为const
        public readonly int y;
        public readonly int z = DateTime.Now.Millisecond; //定义时直接为只读字段赋值
        public Myclass(int i)
        {
            y = i;         //通过构造函数为只读字段y赋值
        }
        public int GetX()    //返回常量x的值
        {
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my1, my2;
            my1 = new Myclass(30);
            my2 = new Myclass(40);
            Console.WriteLine("类的常量字段x值为{0}", Myclass.x);
            Console.WriteLine("my1常量字段y值为{0}", my1.GetX());
            Console.WriteLine("my2常量字段y值为{0}", my2.GetX());
            Console.WriteLine("my1只读字段y值为{0}", my1.y);
            Console.WriteLine("my2只读字段y值为{0}", my2.y);
            Console.WriteLine("my1只读字段z值为{0}", my1.z);
            Console.WriteLine("my2只读字段z值为{0}", my2.z);
        }
    }
}
