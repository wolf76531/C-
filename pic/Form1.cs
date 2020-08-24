using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pic
{
    public partial class Form1 : Form
    {
        private int count=0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                
                filePath = folderBrowserDialog1.SelectedPath;
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("名稱") });
                //DataRow dr = dt.NewRow();

                string[] file = Directory.GetFileSystemEntries(filePath, "*.jpg");

                foreach (string fname in file)
                {
                    DataRow dr = dt.NewRow();
                    dr["名稱"] = fname;
                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;
                pictureBox1.Image = new Bitmap(file[0]);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked && checkBox2.Checked) || (checkBox1.Checked && checkBox3.Checked) || (checkBox2.Checked && checkBox3.Checked))
            {
                MessageBox.Show("不要亂玩");
                return;
            }

            if(checkBox1.Checked)
            {
                timer1.Interval = 1000; //1 second
                //MessageBox.Show("設定 1 秒");
            }
            else if(checkBox2.Checked)
            {
                timer1.Interval = 1000 * 2;
                //MessageBox.Show("設定 2 秒");
            }
            else if(checkBox3.Checked)
            {
                timer1.Interval = 1000 * 3;
                //MessageBox.Show("設定 3 秒");
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count > dataGridView1.Rows.Count-1)
            {
                count = 0;
            }
            else 
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[count].Cells[0];
                //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                pictureBox1.Image = new Bitmap(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                count++;
            }
            
        }
    }
}
