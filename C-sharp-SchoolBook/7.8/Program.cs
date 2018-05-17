using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8
{
    abstract class MyAbstractClass
    {
        int[] a = new int[10];
        public abstract int Add(int x, int y);
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public string Name
        {
            get;
            set;
        }
        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
