using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9
{
    abstract class MyAbstractClass
    {
         public int[] a = new int[10];
        public int Add(int x, int y)
        {
            return x + y;
        }
        public abstract int Sub(int x, int y);
        public abstract int this[int index]
        {
            get;
            set;
        }
    }
    class MyClass:MyAbstractClass
    {
        public override int Sub(int x, int y)
        {
            return x - y;
        }
        public override int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            Console.WriteLine(m.Add(3, 2));
            Console.WriteLine(m.Sub(3, 2));
            MyAbstractClass n = new MyClass();
            Console.WriteLine(n.Add(30, 20));
            Console.WriteLine(n.Sub(30, 20));
        }
    }
}
