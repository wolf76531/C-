using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentExample6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn boxColumn = new DataGridViewTextBoxColumn();
            boxColumn.Name = "Column1";
            boxColumn.HeaderText = "Value";
            dataGridView1.Columns.Add(boxColumn);
        }

        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[count].Cells[0].Value = textBox1.Text;
            count++;
            textBox1.Text = "";
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否刪除該筆資料", "確認",
                                                  MessageBoxButtons.YesNo, 
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                DataGridView cntDataGridView = ((DataGridView)sender);
                e.Cancel = true;
            }
        }
    }
}
