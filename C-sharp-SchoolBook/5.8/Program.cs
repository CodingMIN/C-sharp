using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < 5; i++)
            {
                ht.Add(i, (char)(65 + i));//依次以整数0、1 、2 、3 、4为key，以字符'A'、'B'、'C'、'D'、'E'为value
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine("键:{0} 值:{1}", d.Key, d.Value);
            }
            Console.Write("请输入Hashtable的键(输入x表示结束):");
            string s = Console.ReadLine();
            while(s!="x")
            {
                int key = -1;
                int.TryParse(s, out key);
                if (ht.ContainsKey(key))
                    Console.WriteLine("对应的值为:{0}", ht[key]);
                else
                    Console.WriteLine("该键不存在!");
                Console.Write("请输入Hashtable的键(输入x表示结束):");
                s = Console.ReadLine();
            }
        }
    }
}
