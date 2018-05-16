using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6
{
    interface IMyInterface
    {
        int Add(int x, int y);
        string Name
        {
            get;
            set;
        }
        int this[int index]
        {
            get;
            set;
        }
    }

    class MyClass:IMyInterface
    {
        private int[] a = new int[10];
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }
        public string Name
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.Name = "hello interface";
            for(int i=0;i<10;i++)
            {
                m[i] = i;
            }
            Console.WriteLine(m.Name);
            Console.WriteLine(m.Add(3, 2));
            for(int i=0;i<10;i++)
            {
                Console.Write(m[i]);
            }
            Console.WriteLine();
        }
    }
}
