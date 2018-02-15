using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public static class StudentConvert
    {
        public static Student StrToStudent(string str)
        {
            string[] t = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (t.Length < 4) throw new Exception();
            StringBuilder FIO = new StringBuilder();
            FIO.Append(t[0]);
            for (int i = 1; i < t.Length - 3; i++)
            {
                FIO.Append(" " + t[i]);
            }
            return new Student(FIO.ToString(), int.Parse(t[t.Length - 3]), int.Parse(t[t.Length - 2]), int.Parse(t[t.Length - 1]));
        }
        public static IList<Student> StrToStudents(string str)
        {
            string[] t = str.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<Student> students = new List<Student>();
            foreach (string item in t)
            {
                students.Add(StrToStudent(item));
            }
            return students;
        }
        public static IList<Student> Arr2ToStudents(string[,] Arr2)
        {
            if (Arr2.GetLength(1) != 4) throw new Exception();
            List<Student> students = new List<Student>();
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                students.Add(new Student(Arr2[i, 0], int.Parse(Arr2[i, 1]), int.Parse(Arr2[i, 2]), int.Parse(Arr2[i, 3])));
            }
            return students;
        }
        public static string[,] StudentsToArr2(IList<Student> students)
        {
            string[,] Arr2 = new string[students.Count, 4];
            for (int i = 0; i < students.Count; i++)
            {
                Arr2[i, 0] = students[i].FIO;
                Arr2[i, 1] = students[i].R.ToString();
                Arr2[i, 2] = students[i].M.ToString();
                Arr2[i, 3] = students[i].P.ToString();
            }
            return Arr2;
        }
        public static string StudentsToString(IList<Student> students)
        {
            return string.Join("\r\n", students);
        }
    }
}
