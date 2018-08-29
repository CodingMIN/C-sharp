using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._25
{
    class Door
    {
        public delegate void OpenDoor();  //定义委托
        public event OpenDoor OpenEvent;  //定义事件
        public void CheckDoor(int i)     //检查门是否打开
        {
            if(i==1)
            {
                Console.WriteLine("i==1,触发开门事件!");
                OpenEvent();              //触发事件
            }
            else
            {
                Console.WriteLine("i!=1,不触发开门事件!");
            }
        }
    }

    class House
    {
        private int i = 0;
        public void CountOpenAmount()
        {
            i++;
            Console.WriteLine("门被打开了{0}次!", i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            House horse = new House();
            //注册事件的方法一
            door.OpenEvent += new Door.OpenDoor(horse.CountOpenAmount);
            //注册事件的方法二
            //door.OpenEvent += horse.CountOpenAmount;
            for(int i=0;i<5;i++)
            {
                Console.Write("请输入i的值,1:触发事件,其他:不触发事件:");
                int key = int.Parse(Console.ReadLine());
                door.CheckDoor(key);    //判断是否需要触发事件
            }
        }
    }
}
