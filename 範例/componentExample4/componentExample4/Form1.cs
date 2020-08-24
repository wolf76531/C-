using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentExample4
{
    public partial class Form1 : Form
    {
        Font defaultFont = new Font("新細明體", 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox2.SelectedIndex < 0 || listBox3.SelectedIndex < 0)
                label1.Font = defaultFont;
            else
            {
                string fontFamily = listBox1.Text;
                FontStyle fontStyle; 
                switch (listBox2.Text)
                {
                    case "標準":
                        fontStyle = FontStyle.Regular;
                        break;
                    case "傾斜":
                        fontStyle = FontStyle.Italic;
                        break;
                    case "粗體":
                        fontStyle = FontStyle.Bold;
                        break;
                    case "粗斜體":
                        fontStyle = FontStyle.Bold | FontStyle.Italic;
                        break;
                    default:
                        fontStyle = FontStyle.Regular;
                        break;
                }
                float fontSize = float.Parse(listBox3.Text);
                label1.Font = new Font(fontFamily, fontSize, fontStyle);
            }

        }
    }
}
