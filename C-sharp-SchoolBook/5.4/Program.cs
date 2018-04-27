using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> sk1 = new Stack<int>();
            Stack <int>sk2 = new Stack<int>();
            for(int i=1;i<5;i++)
            {
                sk1.Push(i);            //入栈
                sk2.Push(i);
            }
            //遍历（后进先出)
            Console.Write("栈sk1和sk2的初始元素:");
            foreach (int i in sk1)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            sk1.Pop();         //出栈
            sk1.Pop();
            Console.Write("栈sk1调用2次Pop()方法后剩余的元素:");
            foreach(int i in sk1)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            sk2.Peek();            //返回位于sk2顶部的对象，但不删除
            Console.Write("栈sk2调用1次Peek()方法后剩余的元素:");
            foreach (int i in sk2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            }
        }
    }
