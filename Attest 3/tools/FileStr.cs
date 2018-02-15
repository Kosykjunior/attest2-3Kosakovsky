using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tools
{
    public static class FileStr
    {
        public static void WriteStr(string str, string Path) => File.WriteAllText(Path, str);
        public static string ReadStr(string Path) => File.ReadAllText(Path);
    }
}
