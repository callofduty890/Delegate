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

        static void Main(string[] args)
        {
        }
    }
}
