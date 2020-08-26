using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_事件的声明_引发_订阅和取消
{
    //定义了一个妈妈类
    public class Mon
    {
        //定义一个事件 event 是事件的关键帧 Action委托(系统预定义) 
        public event Action Eat;
        public void Cook()
        {
            Console.WriteLine("妈妈：饭做好了! 开发拉！");
            //饭好了，发布吃饭的消息
            Eat.Invoke();//事件的发布
        }
    }
    //定义爸爸去吃放
    public class Dad
    {
        public void Eat()
        {
            Console.WriteLine("爸爸:我过来吃饭了");
        }
    }
    //定义一个孩子类
    public class Child
    {
        public void Eat()
        {
            Console.WriteLine("孩子:妈妈等会再吃，我再玩多一会");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //实例化对象
            Mon mom = new Mon();
            Dad dad = new Dad();
            Child child = new Child();

            //订阅妈妈开发的消息
            mom.Eat += dad.Eat;
            mom.Eat += child.Eat;

            //调用妈妈的Cook事件
            mom.Cook();

            Console.ReadKey();

        }
    }
}
