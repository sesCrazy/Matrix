using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матрица
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Matr.ZeroMatr(dataGridView1, numericUpDown1)) textBox1.Text = "Нулевая";
            else if (Matr.UnitMatr(dataGridView1, numericUpDown1)) textBox1.Text = "Единичная";
            else if (Matr.DiagonalMatr(dataGridView1, numericUpDown1)) textBox1.Text = "Диагональная";
            else textBox1.Text = "Не является нулевой, единичной или диагональной";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
