using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ConvertList
    {
        public static List<int> StrToList(string str)
        {
            List<int> list = new List<int>();
            string[] split = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < split.Length; i++)
            {
                list.Add(int.Parse(split[i]));
            }
            return list;
        }
        public static string ListToStr<T>(IList<T> list,string sep)
        {
            return string.Join(sep, list);
        }
    }
}
