using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_委托有返回值
{
    //创建委托
    delegate int MyDel();//声明有返回值的方法

    //创建类
    class MyClass
    {
        int IntValue = 5;
        public int Add2() { IntValue += 2;return IntValue;}
        public int Add3() { IntValue += 3; return IntValue; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyDel mDel = mc.Add2;//创建并初始化委托
            mDel += mc.Add3;        //增加方法
            mDel += mc.Add2;        //增加方法
            //输出结果
            Console.WriteLine("Value:{0}", mDel());
            mDel -= mc.Add3;
            Console.WriteLine("Value:{0}", mDel());

        }
    }
}
