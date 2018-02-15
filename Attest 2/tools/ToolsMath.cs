using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsMath
    {
        public double X { get; set; }
        public double E { get; set; }
        public ToolsMath(double x, double e)
        {
            X = x;
            E = e;
        }
        public double Left()
        {
            return Math.Cos(X);
        }
        public double GetAn(double a, int n)
        {
            if (n == 1)
                return 1;
            return -a * X * X / ((n - 1) * 2 * ((n - 1) * 2 - 1));
        }
        public double Right(out int n)
        {
            n = 0;
            double a = 1;
            double sum = 0;
            while (Math.Abs(a)>E)
            {
                a = GetAn(a, ++n);
                sum += a;
            }
            return sum;
        }
    }
}
