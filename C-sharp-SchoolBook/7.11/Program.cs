using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 30;
            string s = "abc";
            Hashtable t=new Hashtable();
            Console.WriteLine(i is int);
            Console.WriteLine(s is string);
            Console.WriteLine(s is object);
            Console.WriteLine(t is ICollection);
            Console.WriteLine(t is IList);
        }
    }
}
