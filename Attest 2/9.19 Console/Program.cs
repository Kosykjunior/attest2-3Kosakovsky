using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsConsole;
using tools;

namespace _9._19_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[,] Arr2 = ToolsConsoleArr2.ReadArr2();
                ToolsArr2 toolsArr2 = new ToolsArr2(Arr2);
                if (toolsArr2.Check())
                    Console.WriteLine("удволетворяет условию");
                else
                    Console.WriteLine("не удволетворяет условию");
            }
        }
    }
}
