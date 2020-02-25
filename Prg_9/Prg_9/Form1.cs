/*
 * @Nil_Sinojiya
 * Write a C# program which creates windows form with one Button,Textbox.
When button is clicked it should display Color Dialog Box. When a color is
selected from the dialog box, it should be set as background color of the text
box.*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }
    }
}
