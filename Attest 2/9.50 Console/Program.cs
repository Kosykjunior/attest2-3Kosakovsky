using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tools;
using ToolsConsole;

namespace _9._50_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int[,] Arr2 = ToolsConsoleArr2.ReadArr2();
                if (Arr2.GetLength(0) != Arr2.GetLength(1))
                    Console.WriteLine("не квадратная матрица");
                else
                {
                    ToolsArr2 toolsArr2 = new ToolsArr2(Arr2);
                    IList<Row> list = toolsArr2.GetRowsSum();
                    ToolsConsoleArr2.OutputStr(ConvertList.ListToStr(list, "\r\n"));
                }
            }
        }
    }
}
