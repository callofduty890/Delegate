using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_委托的参数列表ref
{
    delegate void MyDel(ref int x);//声明有返回值的方法

    class MyClass
    {
        public void Add2(ref int x) { x += 2;}
        public void Add3(ref int x) { x += 3; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //实例化对象并绑定方法
            MyClass mc = new MyClass();

            //
            MyDel myDel = mc.Add2;
            myDel += mc.Add3;
            myDel += mc.Add2;
            //
            int x = 5;
            myDel(ref x);
            //
            Console.WriteLine("Value:{0}", x);
             
        }
    }
}
