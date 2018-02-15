using System;
using System.IO;
using System.Text;
using tools;

namespace ToolsConsole
{
    public class ToolsConsoleArr2
    {
        public static string Read()
        {
            Console.Write("Считать данные из файла ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                if ((key.KeyChar == 'y') || (key.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            return FileRead(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((key.KeyChar == 'n') || (key.KeyChar == 'N'))
                {
                    while (true)
                    {
                        Console.WriteLine("введите данные ");
                        try
                        {
                            return ConsoleRead();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
        static string ConsoleRead()
        {
            StringBuilder str = new StringBuilder();
            string line;
            line = Console.ReadLine();
            while (line != "")
            {
                str.AppendLine(line);
                line = Console.ReadLine();
            }
            return str.ToString();
        }
        static string FileRead(string Path)
        {
            return FileStr.ReadStr(Path);
        }
        static void FileWrite(string str, string Path)
        {
            FileStr.WriteStr(str,Path);
        }
        static void ConsoleWrite(string str)
        {
            Console.WriteLine(str);
        }
        public static void Output(string str)
        {
            Console.Write("записать данные в файл ? (y/n)");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            FileWrite(str, Console.ReadLine());
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    ConsoleWrite(str);
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
