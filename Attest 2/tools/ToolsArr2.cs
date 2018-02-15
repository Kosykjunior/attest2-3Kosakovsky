using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsArr2
    { 
        public int[,] Arr2 { get; set; }
        public ToolsArr2(int[,] arr2)
        {
            Arr2 = arr2;
        }
        public bool Check()
        {
            for (int i = 0; i < Arr2.GetLength(1); i++)
            {
                if(i%2==0)
                {
                    if (i > 0 && Arr2[0, i - 1] > Arr2[0, i])
                        return false;
                    for (int j = 1; j < Arr2.GetLength(0); j++)
                    {
                        if (Arr2[j - 1, i] > Arr2[j, i])
                            return false;
                    }
                }
                else
                {
                    if (Arr2[Arr2.GetLength(0)-1, i - 1] > Arr2[Arr2.GetLength(0) - 1, i])
                        return false;
                    for (int j = 1; j < Arr2.GetLength(0); j++)
                    {
                        if (Arr2[j, i] > Arr2[j - 1, i])
                            return false;
                    }
                }
            }
            return true;
        }
        public IList<Row> GetRowsSum()
        {
            if (Arr2.GetLength(0) != Arr2.GetLength(1))
                throw new Exception();
            List<Row> rows = new List<Row>();
            for (int i = 0; i < Arr2.GetLength(0); i++)
            {
                if (Arr2[i, i] == 0)
                    rows.Add(new Row(Arr2, i));
            }
            return rows;
        }
    }
    public class Row
    {
        public int Index { get; private set; }
        public int Sum { get; private set; }
        public Row(int[,] Arr2, int Row)
        {
            Sum = 0;
            for (int i = 0; i < Arr2.GetLength(1); i++)
                Sum += Arr2[Row, i];
            Index = Row;
        }
        public override string ToString()
        {
            return Index + " - " + Sum;
        }
        public static string GetStrings(IList<Row> rows)
        {
            return string.Join("\n", rows);
        }
    }
}
