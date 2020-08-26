using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_匿名方法
{
    class Program
    {
        delegate int OtherDel(int InParam);
        public static int Add10(int x)
        {
            return x + 10;
        }

        static void Main(string[] args)
        {
            //OtherDel del = Add10;
            OtherDel del = delegate (int x) { return x + 10;};
            Console.WriteLine("{0}", del(5));
            Console.WriteLine("{0}", del(10));

        }
    }
}
