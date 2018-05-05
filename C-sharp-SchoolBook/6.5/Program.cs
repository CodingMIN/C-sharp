using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    class Myclass
    {
        public int x;
        public Myclass(int i)
        {
            x = i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my1, my2;
            my1 = new Myclass(10);
            my2 = new Myclass(20);
            Console.WriteLine("my1中x的值为{0}", my1.x);
            Console.WriteLine("my2中x的值为{0}", my2.x);
            my1.x = 30;
            Console.WriteLine("修改后my1中x的值为{0}", my1.x);
            Console.WriteLine("修改后my2中x的值为{0}", my2.x);

        }
    }
}
