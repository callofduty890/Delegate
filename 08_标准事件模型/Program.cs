using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_标准事件模型
{
    //步骤1:声明提供事件数据的类
    public class NameListEventArgs:EventArgs
    {
        public string Name { get; set; }
        public int Count { get; set; }
        //构造函数
        public NameListEventArgs(string name,int count)
        {
            this.Name = name;
            this.Count = count;
        }
    }
    //步骤2:声明事件处理委托
    public delegate void NameListEventHandler(object source, NameListEventArgs args);
    //步骤3:声明应发事件的类 (事件生产类) 妈妈类
    public class NameList
    {
        ArrayList list;
        //步骤4：在事件生产类中,声明事件  (妈妈类的事件)
        public event NameListEventHandler nameListEvent;
        public NameList()
        {
            list = new ArrayList();
        }
        //添加使用的功能函数，(等于:妈妈做好饭)
        public void Add(string Name)
        {
            list.Add(Name);
            //步骤5:在事件生成类中,实现产生事件的代码
            if (nameListEvent !=null )
            {
                nameListEvent(this, new NameListEventArgs(Name, list.Count));
            }
        } 
    }

     //步骤6:声明处理事件的类 (事件消费类)
    class Program
    {
       //步骤7: 在事件消费类中,声明事件处理方法
       public static void Method1(object sourc,NameListEventArgs args)
       {
            Console.WriteLine("列表中增加了项目:{0}", args.Name);
        }
        public static void Method2(object sourc, NameListEventArgs args)
        {
            Console.WriteLine("列表中的项目数:{0}", args.Count);
        }
        static void Main(string[] args)
        {
            

        }
    }
}
