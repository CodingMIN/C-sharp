using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, count = 1;          
            //Console.Write(2+"\t");      //注释原语句
            for(n=3;n<=100;n+=2)
            {
                Console.WriteLine("n:{0}", n);       //增加的输出语句
                for(t=2;t<=(int)Math.Sqrt(n);t++)
                {
                    Console.Write(" t:{0}", t);   //增加的输出语句
                    Console.Write("\t{0}%{1}={2}", n, t, n % t);   //增加的输出语句
                    if(n%t!=0)
                    {
                        count++;
                        Console.WriteLine("\tcount:{0}", count);  //增加的输出语句
                        //Console.Write(n+"\t");
                        //if(count%5==0) Console.WriteLine(); //注释原语句
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
