using _7._13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._13
{
    class ClassA
    {
        public virtual void SayHello()
        {
            Console.WriteLine("hello:ClassA");
        }
        public virtual void SayBye()
        {
            Console.WriteLine("Bye:ClassA");
        }
    }

    class ClassB : ClassA
    {
        public override void SayHello()
        {
            Console.WriteLine("hello:ClassB");
        }
        public sealed override void SayBye()
        {
            Console.WriteLine("Bye:ClassB");
        } 
    }
    
    class ClassC:ClassB
    {
        public override void SayHello()
        {
            Console.WriteLine("hello:ClassC");
        }
        /*public override void SayBye()         //该方法在ClassB中是密封的,不能被重写
        {
            Console.WriteLine("Bye:ClassC");
        }*/
        }
    }
    class Program
    {
      static void Main(string[] args)
      {
        ClassA a = new ClassA();
        a.SayHello();
        a.SayBye();
        ClassB b = new ClassB();
        b.SayHello();
        b.SayBye();
        ClassC c = new ClassC();
        c.SayHello();
        c.SayBye();
        }
    }

