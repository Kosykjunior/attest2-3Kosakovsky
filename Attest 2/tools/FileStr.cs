using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tools
{
    public class FileStr
    {
        public string Path { get; set; }

        public FileStr(string path)
        {
            Path = path;
        }
        public void WriteStr(string str)
        {
            File.WriteAllText(Path, str);
        }
    }
}
