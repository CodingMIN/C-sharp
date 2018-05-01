using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Myclass
    {
        public Myclass()
        {
            Console.WriteLine("调用了构造函数");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
        }
    }
}
