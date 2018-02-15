using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tools;
using ToolsConsole;
using static tools.StudentConvert;

namespace _10._19_console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    List<Student> students = (List<Student>)StrToStudents(ToolsConsoleArr2.Read());
                    students.Sort();
                    List<Student> newStudents = new List<Student>();
                    int N = 0;
                    do
                    {
                        Console.Write("введите количество мест");
                    } while (!int.TryParse(Console.ReadLine(),out N));
                    for (int i = 0; i < Math.Min(N, students.Count); i++)
                    {
                        newStudents.Add(students[i]);
                    }
                    ToolsConsoleArr2.Output(StudentsToString(newStudents));
                }
                catch (Exception)
                {
                    Console.WriteLine("ошибка ввода");
                }
            }
        }
    }
}
