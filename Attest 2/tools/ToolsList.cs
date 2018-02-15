using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsList
    {
        public IList<int> list { get; set; }
        public ToolsList(IList<int> list)
        {
            this.list = list;
        }
        public IList<int> Process(int n)
        {
            IList<int> ListNew = Copy();
            n %= ListNew.Count;
            if (n < 0)
                n = ListNew.Count + n;
            for (int i = 0; i < n; i++)
            {
                Shift(ListNew);
            }
            return ListNew;
        }
        void Shift(IList<int> list)
        {
            int t = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, t);
        }

        private IList<int> Copy()
        {
            List<int> ListNew = new List<int>();
            foreach (int item in list)
            {
                ListNew.Add(item);
            }
            return ListNew;
        }
    }
}
