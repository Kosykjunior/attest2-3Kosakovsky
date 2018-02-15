using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsArr
    {
        public int[] Arr { get; set; }
        public ToolsArr(int[] arr)
        {
            Arr = arr;
        }
        private int GetMaxSeriesCount(out int Length)
        {
            Length = 1;
            int Count = 1;
            int LengthT = 1;
            for (int i = 1; i < Arr.Length; i++)
            {
                if(Arr[i] == Arr[i-1])
                {
                    LengthT++;
                }
                else
                {
                    if (LengthT == Length)
                    {
                        LengthT = 1;
                        Count++;
                    }
                    else if (LengthT > Length)
                    {
                        Length = LengthT;
                        Count = 1;
                        LengthT = 1;
                    }
                    else
                        LengthT = 1;
                }
            }
            if (LengthT == Length)
            {
                Count++;
            }
            else if (LengthT > Length)
            {
                Length = LengthT;
                Count = 1;
            }
            return Count;
        }
        public int[] OneAdd(bool first)
        {
             int[] newArr = new int[Arr.Length + 1];
            int Count = GetMaxSeriesCount(out int Length);
            bool was = false;
            int c = 1;
            int CountT = 1;
            newArr[0] = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (c == Length && !was)
                {
                    if(CountT++ == Count||first)
                    {
                        was = true;
                        newArr[i] = Arr[i-1];
                    }
                }
                newArr[i + (was ? 1 : 0)] = Arr[i];
                if (Arr[i] == Arr[i - 1])
                    c++;
                else
                    c = 1;
            }
            if (c == Length && !was)
            {
                newArr[newArr.Length - 1] = Arr[Arr.Length - 1];
            }
            return newArr;
        }
        public int[] AllAdd()
        {
            int Count = GetMaxSeriesCount(out int Lenght);
            int[] newArr = new int[Arr.Length + Count];
            int c = 1;
            int index = 1;
            newArr[0] = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if(c == Lenght)
                {
                    newArr[index++] = Arr[i - 1];
                }
                newArr[index++] = Arr[i];
                if (Arr[i] == Arr[i - 1])
                    c++;
                else
                    c = 1;
            }
            if (c == Lenght)
            {
                newArr[index++] = Arr[Arr.Length-1];
            }
            return newArr;
        }

        bool ChekSubArr(int index, int Length)
        {
            int[] t = new int[Length];
            Array.Copy(Arr, index, t, 0, Length);
            Array.Sort(t);
            bool a = true, b = true, c = true;
            for (int i = 1; i < Length-2; i++)
            {
                if(t[i] != t[i-1])
                {
                    a = false;
                    break;
                }
            }
            for (int i = 2; i < Length - 1; i++)
            {
                if (t[i] != t[i - 1])
                {
                    b = false;
                    break;
                }
            }
            for (int i = 3; i < Length; i++)
            {
                if (t[i] != t[i - 1])
                {
                    c = false;
                    break;
                }
            }
            return (a && t[Length - 1] != t[Length - 2] && t[Length - 3] != t[Length - 2]) || (b && t[0] != t[1] && t[Length - 1] != t[Length - 2]) || (c && t[0] != t[1] && t[1] != t[2]);
        }
        public bool NewSubArr(out int index, out int count)
        {
            index = -1; count = -1;
            if (Arr.Length < 3) return false;
            for (int i = 0; i < Arr.Length-2; i++)
            {
                for (int j = i+2; j < Arr.Length; j++)
                {
                    if(ChekSubArr(i,j-i+1) && j - i + 1 >count)
                    {
                        count = j - i + 1;
                        index = i;
                    }
                }
            }
            if (count == -1) return false;
            return true;
        }
        public int[] SubArr(int index, int count)
        {
            int[] ArrNew = new int[count];
            Array.Copy(Arr, index, ArrNew, 0, count);
            return ArrNew;
        }
    }
}
