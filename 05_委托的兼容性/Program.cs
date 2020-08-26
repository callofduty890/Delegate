using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_委托的兼容性
{
    //创建了两个类，一个父类一个派生的子类
    class Manmal { }
    class Dog : Manmal { }

    class Program
    {
        //定义不同的委托
        public delegate Manmal HandlerMethod();
        public delegate void HandleModthod1(Manmal m);
        public delegate void handleModthod2(Dog d);

        //委托绑定对应的方法
        public static Manmal FirstHandler()
        { Console.WriteLine("First Handler");return null; }

        public static Dog SecondHandler()
        { Console.WriteLine("Second Handler");return null; }

        public static void ThirdHandler(Manmal m)
        { Console.WriteLine("Third Handler"); }

        static void Main(string[] args)
        {
        }
    }
}
