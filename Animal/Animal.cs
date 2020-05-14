using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal
{
    public class Animal
    {
        //字典类型变量  键-值
        private Dictionary<string, int> indexer1 = new Dictionary<string, int>();

        //字符串类型的数组
        private string[] indexer2 = new string[10];

        //索引器的重载

        //设计索引器- indexer1
        public int this[string index]
        {
            get
            {
                //查找是否有此索引
                if (indexer1.ContainsKey(index))
                {
                    return indexer1[index];
                }
                else
                {
                    throw new Exception("未找到相应的值");
                }
            }
            set
            {
                //判断是否找到当前的索引值
                if (indexer1.ContainsKey(index))
                {
                    indexer1[index] = value;
                }
                else
                {
                    //添加对应的键与值
                    indexer1.Add(index, value);
                }
            }
        }

        //设计索引器 - indexer2
        public string this[int index]
        {
            get
            {
                return indexer2[index];
            }
            set
            {
                indexer2[index] = value;
            }
        }


    }
}
