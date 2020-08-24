using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (checkBox1.Checked)
                temp += temp == "" ? checkBox1.Text : "、" + checkBox1.Text;
            if (checkBox2.Checked)
                temp += temp == "" ? checkBox2.Text : "、" + checkBox2.Text;
            if (checkBox3.Checked)
                temp += temp == "" ? checkBox3.Text : "、" + checkBox3.Text;
            if (string.IsNullOrWhiteSpace(temp))
                temp = "無";

            MessageBox.Show("您的興趣是 " + temp,"興趣?");
        }
    }
}
