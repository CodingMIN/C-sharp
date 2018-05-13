using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{   class MyBaseClass
    {
        int[] a = new int[10];
        public int Add(int x, int y)
        {
            return x + y;
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

    class MySubClass:MyBaseClass
    {
        public int Sub(int x,int y)
        {
            return x-y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MySubClass m = new MySubClass();
            m.Name = "hello inherited from base class";
            for(int i=0;i<10;i++)
            {
                m[i] = i;    //通过索引器给m对象中的数组a的元素赋值
            }
            Console.WriteLine(m.Name);
            Console.WriteLine(m.Add(3, 2));
            Console.WriteLine(m.Sub(3, 2));
            for(int i=0;i<10;i++)
            {
                Console.Write(m[i]);
            }
            Console.WriteLine();
        }
    }
}
