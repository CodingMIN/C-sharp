using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11
{
    class Myclass
    {
        public void Print()
        {
            Console.WriteLine("调用了print()方法");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            my.Print();
        }
    }
}
