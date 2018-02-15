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
using ToolsGrid;

namespace _9._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(Input, 40, false, false, false, true, true,false);
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] Arr2 = DataGridViewUtils.GridToArray2<int>(Input);
                ToolsArr2 toolsArr2 = new ToolsArr2(Arr2);
                if (toolsArr2.Check())
                    Output.Text = "удволетворяет условию";
                else
                    Output.Text = "не удволетворяет условию";
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }


        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileArr2 file = new FileArr2(openFileDialog.FileName);
                    int[,] Arr2 = file.ReadArr2();
                    DataGridViewUtils.Array2ToGrid(Input, Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }
    }
}
