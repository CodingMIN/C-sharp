using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass1 = MySpaceOne.MyClass;
using MyClass2 = MySpaceTwo.MyClass;
namespace MySpaceOne
{
    class MyClass
    {
        public void Print()
        {
            Console.WriteLine("MySpaceOne.MyClass中的Print方法");
        }
    }
}
namespace MySpaceTwo
{
    class MyClass
    {
        public void Print()
        {
            Console.WriteLine("MySpaceTwo.MyClass中的Print方法");
        }
    }
}

namespace _6._32
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 my1 = new MyClass1();
            MyClass2 my2 = new MyClass2();
            my1.Print();
            my2.Print();
        }
    }
}
