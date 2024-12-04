using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RB_G.Checked = true;
        }

        
        private void B_Matrix_Click(object sender, EventArgs e)
        {
            DGW_Matrix.Columns.Clear();
            int col = Convert.ToInt32(CB_Column.SelectedItem);
            int row = Convert.ToInt32(CB_Row.SelectedItem);
            DataGridViewColumn column;
            for (int i = 0; i < col; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column.Width = 40;
                DGW_Matrix.Columns.Add(column);

            }

            for (int i = 0; i < row; i++)
            {
                DGW_Matrix.Rows.Add();
                DGW_Matrix.Rows[i].Height = 40;
            }

        }
        
    }
}
