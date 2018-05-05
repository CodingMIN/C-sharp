using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    class Myclass
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 10 || value > 60)
                    value = 0;
                age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            my.Age = 35;
            Console.WriteLine("my对象中age字段值为{0}", my.Age);
            my.Age = 350;
            Console.WriteLine("my对象中age字段值为{0}", my.Age);
        }
    }
}
