using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tools;

namespace _7._50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalcBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int[] arr = ConvertArr.StrToArray<int>(ArrInput.Text);
                ToolsArr toolsArr = new ToolsArr(arr);
                if (toolsArr.NewSubArr(out int index, out int count))
                {
                    int[] ArrNew = toolsArr.SubArr(index, count);
                    output.Text = ConvertArr.ArrayToStr(ArrNew);
                }
                else
                {
                    output.Text = "последовательность не найдена";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
