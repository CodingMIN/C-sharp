using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._17
{
    class ClassA
    {
        public virtual void Print()
        {
            Console.WriteLine("Print From ClassA");
        }
    }

    class ClassB:ClassA
    {
        public override void Print()
        {
            Console.WriteLine("Print From ClassB");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            object o1 = new ClassA();//引用类型转换成object
            Console.WriteLine(o1.GetType().Name);
            ClassB b = new ClassB();
            ClassA a = b;//派生类向基类转换
            a.Print();
            object o2 = 12;//值类型向引用类型转换
            Console.WriteLine(o2.ToString());
        }
    }
}
