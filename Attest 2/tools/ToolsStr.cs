using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsStr
    {
        public string Str { get; set; }
        public ToolsStr(string str)
        {
            Str = str;
        }
        public bool CheckOn(char a, char b, out int aCount, out int bCount)
        {
            aCount = 0;
            bCount = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == a) aCount++;
                if (Str[i] == b) bCount++;
            }
            return (aCount > 0 && bCount > 0);
        }
    }
}
