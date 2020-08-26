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
        public delegate void HandleModthod2(Dog d);

        //准备委托绑定对应的方法
        public static Manmal FirstHandler()
        { Console.WriteLine("First Handler");return null; }

        public static Dog SecondHandler()
        { Console.WriteLine("Second Handler");return null; }

        public static void ThirdHandler(Manmal m)
        { Console.WriteLine("Third Handler"); }

        static void Main(string[] args)
        {
            //正常的匹配 返回父类 输入形参:无
            HandlerMethod handler1 = FirstHandler;
            handler1();
            //协变 返回值Dog默认转换为Mammal(父类中装子类)
            HandlerMethod handler2 = SecondHandler;
            handler2();

            //创建父类的对象
            Manmal m = new Manmal();
            //正常匹配 无返回值，输入的形参为父类
            HandleModthod1 handler11 = ThirdHandler;
            handler11(m);


            //创建子类的对象
            Dog d = new Dog();
            //逆变，参数Dog默认可以转换成为Mammal
            HandleModthod2 handle33 = ThirdHandler;
            handle33(d);




        }
    }
}
