using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Person;
namespace _5_14_代码
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Person p = new Person.Person();

            //使用索引器的方式给两个属性赋值
            p[0] = "callofduty"; //账号赋值
            p[1] = "123456";     //密码赋值
            //获取属性的值
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Password);
            //通过索引器取值
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.ReadKey();
        }
    }
}
