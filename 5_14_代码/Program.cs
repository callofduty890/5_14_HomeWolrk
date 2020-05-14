using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Person;
using Animal;

namespace _5_14_代码
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 索引器使用方法一
            //Person.Person p = new Person.Person();

            ////使用索引器的方式给两个属性赋值
            //p[0] = "callofduty"; //账号赋值
            //p[1] = "123456";     //密码赋值
            ////获取属性的值
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p.Password);
            ////通过索引器取值
            //Console.WriteLine(p[0]);
            //Console.WriteLine(p[1]);
            #endregion

            Animal.Animal an = new Animal.Animal();
            //使用第一个索引
            an["Fish"] = 20;
            an["Tiger"] = 30;
            an["Mouse"] = 5;

            Console.WriteLine(an["Fish"]);
            Console.WriteLine(an["Tiger"]);
            Console.WriteLine(an["Tiger"]);

            Console.WriteLine("=========================");

            //第二个索引器
            an[1] = "dog";
            an[2] = "cat";
            an[3] = "bird";

            Console.WriteLine(an[1]);
            Console.WriteLine(an[2]);
            Console.WriteLine(an[3]);

            Console.ReadKey();
        }
    }
}
