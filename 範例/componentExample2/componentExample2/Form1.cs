using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                pictureBox1.Size = new Size(105, 65);
            else if (radioButton2.Checked)
                pictureBox1.Size = new Size(158, 98);
            else
                pictureBox1.Size = new Size(210, 130);
        }
    }
}
