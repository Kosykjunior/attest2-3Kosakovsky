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

namespace _6._50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            try
            {
                double X = double.Parse(InputX.Text);
                double E = double.Parse(InputE.Text);
                ToolsMath toolsMath = new ToolsMath(X, E);
                OutputX1.Text = toolsMath.Left().ToString();
                OutputX2.Text = toolsMath.Right(out int n).ToString();
                OutputN.Text = n.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
