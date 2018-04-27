using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr= new int[3, 6];     //定义3*6的二维数组
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                { 
                    arr[i, j] = (i + 1)*10+j+1;  //对数组元素赋初值
                }
            }
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write("{0} ", arr[i, j]);  //遍历输出数组的每个元素值
                }
                Console.WriteLine();
            }
            foreach(int a in arr)
            {
                Console.Write("{0} ", a);
            }
        }
    }
}
