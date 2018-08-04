using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._18
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
            object[] o = new object[] { new ClassA(), new ClassB(), 12 };
            for(int i=0;i<o.Length;i++)
            {
                Console.WriteLine(o[i].GetType().Name);
                if(o[i] is ClassA)
                {
                    ClassA a = (ClassA)o[i];//object类型显式转换成引用类型
                    a.Print();
                }
                else if(o[i] is ClassB)
                {
                    ClassB b = (ClassB)o[i];//object类型显式转换成引用类型
                    b.Print();
                }
                else if(o[i] is Int32)
                {
                    int t = (int)o[i];//引用类型转换成值类型
                    Console.WriteLine(t);
                }
            }
        }
    }
}
