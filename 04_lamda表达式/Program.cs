using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_lamda表达式
{
    delegate int Del(int x);//创建委托
    delegate int MyDel(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //一个传入参数列表
            Del del = delegate (int x) { return x + 1; };//匿名委托
        
            Del del1 = (int x) => { return x + 1; };//Lamda表达式
            Del del2 = (x) => { return x + 1; };//Lamda表达式
            Del del3 = x => { return x + 1; };//Lamda表达式
            Del del4 = x =>  x + 1;//Lamda表达式

            //两个传入参数列表
            MyDel myDel= delegate (int x,int y) { return x + y; };

            MyDel myDel1=(int x, int y) => { return x + y; };
            MyDel myDel2 = (x, y) => { return x + y; };
            MyDel myDel4 = (x, y) =>  x + y;

            //输出结果
            Console.WriteLine("{0}", del(0));
            Console.WriteLine("{0}", del1(1));
            Console.WriteLine("{0}", del2(2));
            Console.WriteLine("{0}", del3(3));
            Console.WriteLine("{0}", del4(4));
        }
    }
}
