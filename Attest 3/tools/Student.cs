using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class Student:IComparable
    {
        public string FIO { get; private set; }
        public int R { get; private set; }
        public int M { get; private set; }
        public int P { get; private set; }

        public Student(string FIO, int r, int m, int p)
        {
            this.FIO = FIO;
            R = r;
            M = m;
            P = p;
        }

        public int CompareTo(object obj)
        {
            Student st = (Student)obj;
            if (st.R + st.M + st.P > R + M + P)
                return 1;
            if (st.R + st.M + st.P < R + M + P)
                return -1;
            if (st.M > M)
                return 1;
            if (st.M < M)
                return -1;
            if (st.P > P)
                return 1;
            if (st.P < P)
                return -1;
            if (st.R > R)
                return 1;
            if (st.R < R)
                return -1;
            return 0;
        }
        public override string ToString()
        {
            return FIO + " " + R + " " + M + " " + P;
        }
    }
}
