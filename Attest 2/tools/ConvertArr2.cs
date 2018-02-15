using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ConvertArr2
    {
        public static int[,] StrToArr2(string str)
        {
            string[] Row = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (Row.Length == 0) return new int[0, 0];
            string[] Split = Row[0].Split(new char[] { ',', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int[,] arr2 = new int[Row.Length, Split.Length];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                Split = Row[i].Split(new char[] { ',', ' ', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                if (Split.Length != arr2.GetLength(1)) throw new Exception("0");
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = int.Parse(Split[j]);
                }
            }
            return arr2;
        }
        public static string Arr2ToStr(int[,] arr2)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    str.Append(arr2[i, j] + ((j != arr2.GetLength(1) - 1) ? " " : ""));
                }
                if (i != arr2.GetLength(0))
                    str.AppendLine();
            }
            return str.ToString();
        }
    }
}
