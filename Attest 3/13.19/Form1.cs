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

namespace _13._19
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                DGV.Rows[i].Height = 70;
            }
            game = new Game();
            UpdateColors();
        }
        void UpdateColors()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    switch (game.Pole[i,j])
                    {
                        case Colors.yellow:
                            DGV[j, i].Style.BackColor = Color.Yellow;
                            break;
                        case Colors.red:
                            DGV[j, i].Style.BackColor = Color.Red;
                            break;
                        case Colors.green:
                            DGV[j, i].Style.BackColor = Color.Green;
                            break;
                        case Colors.blue:
                            DGV[j, i].Style.BackColor = Color.Blue;
                            break;
                        case Colors.pink:
                            DGV[j, i].Style.BackColor = Color.Pink;
                            break;
                    }
                }
            }
        }

        private void DGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.PaintBackground(e.CellBounds, false);
            e.Handled = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            game.NewGame((int)Level.Value);
            UpdateColors();
            label.Visible = false;
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(game.Click(true, e.RowIndex, e.ColumnIndex))
                label.Visible = true;
            UpdateColors();
        }
    }
}
