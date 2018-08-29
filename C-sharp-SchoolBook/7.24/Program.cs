using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._24
{
    class ClassA
    {
        public string SayHello(string s)
        {
            return "Hello " + s;
        }
    }
    class Program
    {
        delegate string Say(string s); //定义委托
        public static string SayBye(string s)
        {
            return "Bye " + s;
        }
        static void Main(string[] args)
        {
            Say say = SayBye;  //用方法SayBye()实例化委托say
            string s = say("John"); //调用委托
            Console.WriteLine(s);
            ClassA a = new ClassA();
            say = a.SayHello; //用类ClassA中的方法SayHello()重新实例化委托say
            s = say("John");  //调用委托
            Console.WriteLine(s);
        }
    }
}
