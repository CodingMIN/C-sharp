using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("下列四项运动中，您最感兴趣的是(输入A、B、C或者D):\n" +
                "A.读书\nB.听音乐\nC.玩游戏\nD.体育运动 ");
            string answer = Console.ReadLine();
            switch(answer.ToUpper())  //ToUpper转换成大写
            {
                case "A":Console.WriteLine("新时代的好学生！");break;
                case "B":Console.WriteLine("有音乐细胞!");break;
                case "C":Console.WriteLine("不能过度噢，有没忘了吃饭?");break;
                case "D":Console.WriteLine("身体是革命的本钱!");break;
                default:Console.WriteLine("选错啦!");break;
            }
        }
    }
}
