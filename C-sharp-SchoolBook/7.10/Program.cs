using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._10
{
    interface IMyInterface
    {
        int Add(int a, int b);
    }
    abstract class MyAbstractClass
    {
        public abstract int Sub(int a, int b);
    }
    class MyBaseClass
    {
        public int RectangleArea(int a,int b)
        {
            return a * b;
        }
    }
    class MyClass:MyBaseClass,IMyInterface
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
    class YourClass:MyAbstractClass,IMyInterface
    {
        public int Add(int a, int b)
        {
            return (a + b) * 2;
        }
        public override int Sub(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            Console.WriteLine(m.Add(3, 2));
            Console.WriteLine(m.RectangleArea(3, 2));
            YourClass y = new YourClass();
            Console.WriteLine(y.Add(3, 2));
            Console.WriteLine(y.Sub(3, 2));
        }
    }
}
