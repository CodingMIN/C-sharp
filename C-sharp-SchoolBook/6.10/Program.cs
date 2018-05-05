using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10
{
    class Myclass
    {
        public string[] name = new string[3] { "张三", "李四", "王五" };
        int[,] score = new int[3, 2] { { 80, 90 }, { 81, 91 }, { 82, 92 } };//学生语文和数学成绩
        public int this[int a,int b]
        {
            get { return score[a, b]; }
            set { score[a, b] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass my = new Myclass();
            Console.WriteLine("{0}的语文成绩是{1}", my.name[0], my[0, 0]);
            Console.WriteLine("{0}的数学成绩是{1}", my.name[1], my[1, 1]);
        }
    }
}
