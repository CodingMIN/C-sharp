using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._16
{
    class ClassA
    {
        public virtual void Print()
        {
            Console.WriteLine("调用ClassA的print()方法");
        }
    }

    class ClassB:ClassA
    {
        public override void Print()
        {
            Console.WriteLine("调用ClassB的Print()方法");
        }
    }

    class ClassC:ClassA
    {
        public override void Print()
        {
            Console.WriteLine("调用ClassC的Print()方法");
        }
    }

    class ClassD : ClassB
    {
        public override void Print()
        {
            Console.WriteLine("调用ClassD的Print()方法");
        }
    }
    class Program
    {
        static void MainPrint(ClassA a)
        {
            a.Print();
        }
        static void Main(string[] args)
        {
            ClassA[] a = new ClassA[]
                {new ClassA(),new ClassB(),new ClassC(),new ClassD() };
            Console.WriteLine("运行时多态性:");
            for(int i=0;i<a.Length;i++)
            {
                MainPrint(a[i]);
            }
        }
    }
}
