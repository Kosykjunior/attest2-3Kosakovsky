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
using static tools.StudentConvert;
namespace _10._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(Input, 70, false, false, true, true, false, false);
            Input.ColumnCount = 4;
            Input.Columns[0].Width = 259;
            Input.Columns[0].HeaderText = "ФИО";
            Input.Columns[1].HeaderText = "русский";
            Input.Columns[2].HeaderText = "математика";
            Input.Columns[3].HeaderText = "физика";
            DataGridViewUtils.InitGridForArr(Output, 70, true, false, true, false, false, false);
            Output.ColumnCount = 4;
            Output.Columns[0].Width = 259;
            Output.Columns[0].HeaderText = "ФИО";
            Output.Columns[1].HeaderText = "русский";
            Output.Columns[2].HeaderText = "математика";
            Output.Columns[3].HeaderText = "физика";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[,] Arr2 = StudentsToArr2(StrToStudents(FileStr.ReadStr(openFileDialog.FileName)));
                    DataGridViewUtils.Array2ToGrid(Input, Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStr.WriteStr(StudentsToString(Arr2ToStudents(DataGridViewUtils.GridToArray2<string>(Output))),saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = (List<Student>)Arr2ToStudents(DataGridViewUtils.GridToArray2<string>(Input));
                students.Sort();
                List<Student> newStudents = new List<Student>();
                for (int i = 0; i < Math.Min(GetN.Value, students.Count); i++)
                {
                    newStudents.Add(students[i]);
                }
                DataGridViewUtils.Array2ToGrid(Output, StudentsToArr2(newStudents));
                save.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
