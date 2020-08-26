using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace _06_委托的异步调用
{
    //声明委托 返回值1 形参输入两个int|out int 返回值
    public delegate int MyDelegate(int op1, int op2, out int Result);

    class Program
    {
        public static int Add(int op1,int op2,out int result)
        {
            //1秒=1000毫秒
            Thread.Sleep(5000);//休眠5秒
            return (result = op1 + op2);
        }

        static void Main(string[] args)
        {
            int result;
            //往委托列表中添加方法
            MyDelegate d = Add;
            //调用BeginInvoke 方法用于启动异步调用
            Console.WriteLine("异步调用MyDelegate 开始");
            //接受异步调用后的结果
            IAsyncResult iar = d.BeginInvoke(123, 456, out result, null, null);
            //循环模拟其他操作，每隔500MS打一个 . 号
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine("等待");
            //使用IAsyncResult.AsyncWaitHandle获取WaitHandle
            //使用WaitOne方法执行 阻塞等待
            //异步调用完成时会发出WaitHandle信号,可通过WaitOne等待
            iar.AsyncWaitHandle.WaitOne();
            Console.WriteLine("异步调用 Add()方法");
            //使用EndInvoke方法检索异步调用结果
            //EndInvoke方法：若异步调用未完成，EndInvoke将阻塞到异步调用完成
            d.EndInvoke(out result,iar);
            //等待调用完成，输出结果
            Console.WriteLine("异步调用 Add结果:{0}", result);

        }
    }
}
