using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    public class Person
    {
        //定义两个字段
        private string _name;
        private string _password;

        //属性：1,用户名 2.密码
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //定义索引器
        public string this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Name;
                }
                else if (index == 1)
                {
                    return Password;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index == 0)
                {
                    Name = value;
                }
                else if (index == 1)
                {
                    Password = value;
                }
            }
        }
    }
}
