using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _6._4
{
    class Myclass
    {
        public Myclass()
        {
            Console.WriteLine("调用了构造函数");
        }
        ~Myclass()
        {
            Console.WriteLine("调用了析构函数");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            for(int i=0;i<10;i++)
            {
                my = null;    //my所引用的对象变成无用对象，系统可以销毁该对象
                GC.Collect(); //强制进行垃圾回收，销毁对象
                Console.WriteLine("my=null,应调用第{0}次析构函数", i);
                Thread.Sleep(100);  //让运行Main()方法的线程睡眠100ms
                my = new Myclass(); //重新再创建一个新的对象
            }
        }
    }
}
