using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> qu1 = new Queue<int>();
            Queue<int> qu2 = new Queue<int>();
            for(int i=1;i<5;i++)
            {
                qu1.Enqueue(i);
                qu2.Enqueue(i); //入队
            }
            Console.Write("队列qu1和qu2的初始元素:");
            foreach(int i in qu1)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            qu1.Dequeue();           //出队
            qu1.Dequeue();
            Console.Write("队列sq1调用2次Dequeue()方法后剩余的元素:");
            foreach(int i in qu1)
            {
                Console.Write("{0} ", i);     
            }
            Console.WriteLine(); 
            qu2.Peek();         //返回位于Queue开始处的对象，但不将其移除
            Console.Write("队列sq2调用1次Peek()方法后剩余的元素:");
            foreach(int i in qu2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
