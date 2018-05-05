using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._13
{
    class Myclass
    {
        public int x = 20;
    }

    class Program
    {
        static void Change(Myclass t)
        {
            Console.WriteLine("形参对象t中实例字段x的初始值为:{0}", t.x);
            t.x = t.x + 30;
            Console.WriteLine("形参对象t中实例字段x修改后的值为:{0}", t.x);
        }
        static void Main(string[] args)
        {
            Myclass a = new Myclass();
            Console.WriteLine("方法调用前实参对象a中实例字段x的值为:{0}", a.x);
            Change(a);
            Console.WriteLine("方法调用后实参对象a中实例字段x的值为:{0}", a.x);
        }
    }
}
