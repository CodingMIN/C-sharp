using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9
{
    class Myclass
    {
        public int Age
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            my.Age = 35;
            Console.WriteLine("my对象的自动属性Age的值为{0}", my.Age);
        }
    }
}
