using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._26
{
    class MyEventArgs : EventArgs   //声明一个自定义的事件数据类
    {
        public int Score { get; set; }   //添加一个成绩属性
    }

    class Father
    {
        public void AttitudeToScore(object sender,MyEventArgs e)
        {
            if(e.Score>=80)
            {
                Console.WriteLine("成绩超过80分,爸爸很满意!");
            }
            else
            {
                Console.WriteLine("成绩虽然低于80分,爸爸也不生气!");
            }
        }
    }

    class Mother
    {
        public void AttitudeToScore(object sender,MyEventArgs e)
        {
            if(e.Score>=80&&e.Score<90)
            {
                Console.WriteLine("成绩只有80多分,妈妈不太满意!");
            }
            else if(e.Score<80)
            {
                Console.WriteLine("成绩低于80分,妈妈非常生气!");
            }
            else
            {
                Console.WriteLine("成绩超过90分,妈妈很满意!");
            }
        }
    }

    class Son
    {
        protected delegate void Score(object sender, MyEventArgs e);   //声明了委托
        protected event Score SendScoreMessage;             //声明了该委托类型的事件
        public Son()
        {
            Father f = new Father();
            Mother m = new Mother();
            SendScoreMessage += f.AttitudeToScore;    //注册事件的订阅者
            SendScoreMessage += m.AttitudeToScore;    //注册事件的订阅者
        }
        public void GetScoreFromTeacher(int score)
        {
            MyEventArgs e = new MyEventArgs();
            e.Score = score;
            object sender = this;
            SendScoreMessage(sender, e);               //触发事件
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Son s = new Son();
            Console.WriteLine("请输入成绩:");
            int.TryParse(Console.ReadLine(), out score);
            /*
             * int.Parse()是一种类容转换；表示将数字内容的字符串转为int类型。
               如果字符串为空，则抛出ArgumentNullException异常；
               如果字符串内容不是数字，则抛出FormatException异常；
               如果字符串内容所表示数字超出int类型可表示的范围，则抛出OverflowException异常；

               int.TryParse 与 int.Parse 又较为类似，但它不会产生异常，转换成功返回 true，转换失败返回 false。最后一个参数为输出值，如果转换失败，输出值为 0

              所以tryParse刚开始用起来真的很容易晕，首先得先明白它和 int.Parse的相似和不同，共同点操作对象都是字符串.


               Console.WriteLine("请输入圆的半径");
               int r;   //定义半径变量
               bool x = int.TryParse(Console.ReadLine(),out r); 
               判断用户的输入是否为整型的数据，如果在此处输入的不是整形数值
               此处会返回false，并赋值给x，此时r的值已经变成了0，如果此处用户输入了
               有效的数值，此处会返回true，r会保持用户输入的值待用
            */
            s.GetScoreFromTeacher(score);
        }
    }
}
