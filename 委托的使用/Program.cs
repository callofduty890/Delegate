using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 委托的使用
{
    class Program
    {
        //定义委托
        delegate void D(int x);

        class C
        {
            //类的静态方法
            public static void M1(int i)
            {
                Console.WriteLine("C.M1" + i);
            }
            public static void M2(int i)
            {
                Console.WriteLine("C.M2" + i);
            }
            //类的非静态方法-需要实例化
            public void M3(int i)
            {
                Console.WriteLine("C.M3" + i);
            }
        }

        static void Main(string[] args)
        {
            //使用new关键字,创建委托对象，指向静态方法
            D d1 = new D(C.M1);
            //调用M1;
            d1(-1);

            //使用赋值符号进行创建委托
            D d2 = C.M2;
            d2(-2);

            //使用new关键字创建委托对象
            C obj = new C();
            D d3 = new D(obj.M3);
            //调用
            d3(-3);

        }
    }
}
