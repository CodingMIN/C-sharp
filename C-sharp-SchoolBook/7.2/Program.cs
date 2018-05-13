using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class MyBaseClass
    {
        public virtual float CircleArea(float r)
        {
            Console.WriteLine("调用基类CircleArea()方法:");
            return 3.14f * r * r;
        }
        public virtual float SphereVolume(float r)
        {
            Console.WriteLine("调用基类SphereVolume()方法:");
            return 3.14f * r * r * r * 4 / 3;
        }
        public virtual String Name
        {
            get { return "调用基类的Name属性"; }
        }
    }

    class MySubClass:MyBaseClass
    {
        public override float CircleArea(float r)
        {
            Console.Write("调用派生类CircleArea()方法:");
            return 3.14159f * r * r ;
        }
        public new float SphereVolume(float r)
        {
            Console.Write("调用派生类SphereVolume()方法:");
            return 3.14159f * r * r * r * 4 / 3;
        }
        public override string Name
        {
            get { return "调用派生类的Name属性"; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass b = new MyBaseClass();
            Console.WriteLine(b.CircleArea(3));
            Console.WriteLine(b.SphereVolume(3));
            Console.WriteLine(b.Name);
            Console.WriteLine("-------------------------");
            MySubClass m = new MySubClass();
            Console.WriteLine(m.CircleArea(3));
            Console.WriteLine(m.SphereVolume(3));
            Console.WriteLine(m.Name);
            Console.WriteLine("-------------------------");
            MyBaseClass t = new MySubClass();
            Console.WriteLine(t.CircleArea(3));
            Console.WriteLine(t.SphereVolume(3));
            Console.WriteLine(t.Name);
        }
    }
}
