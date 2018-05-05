using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._15
{
    class A
    {
        public int x = 20;
    }
    class Program
    {
        static void ChangeA(A t1,ref A t2)
        {
            t1 = new A();
            t2 = new A();
            t1.x = 50;
            t2.x = 50;
        }
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            Console.WriteLine("方法调用前实参对象a1中实例字段x的值为:{0}", a1.x);
            Console.WriteLine("方法调用前实参对象a2中实例字段x的值为:{0}", a2.x);
            ChangeA(a1, ref a2);
            Console.WriteLine("方法调用后实参对象a1中实例字段x的值为:{0}", a1.x);
            Console.WriteLine("方法调用后实参对象a2中实例字段x的值为i:{0}", a2.x);
   
        }
    }
}
