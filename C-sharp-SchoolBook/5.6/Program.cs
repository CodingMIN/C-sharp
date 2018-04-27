using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arrList = new System.Collections.ArrayList(5);
            for (int i = 0; i < 4; i++)
            {
                arrList.Add(i);
            }
            Console.WriteLine("arrList的元素个数:{0} 容量:{1}", arrList.Count, arrList.Capacity);
            arrList.Insert(1, "a");             //在索引为1的位置插入字符串a
            arrList.Insert(3, "b");             //在索引为3的位置插入字符串b
            Console.WriteLine("添加两个元素后，arrList的元素个数:{0} 容量:{1}", arrList.Count, arrList.Capacity);
            Console.WriteLine("用foreach语句输出arrList中的所有元素:");
            foreach (object o in arrList)
            {
                Console.Write("{0} ", o);
            }
            Console.WriteLine("\n用for语句输出arrList中的所有元素:");
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.Write("{0} ", arrList[i]);
            }
            Console.WriteLine();
        }
    }
}
