/*
 * @NilSinojiya
 * Write a C# code to bind data from given table to Combobox Control using DataAdapter.
    Table : Student (EnrollmentNo , Name)
    */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prg_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_masterDataSet1.bind_student' table. You can move, or remove it, as needed.
            this.bind_studentTableAdapter1.Fill(this.student_masterDataSet1.bind_student);
            // TODO: This line of code loads data into the 'student_masterDataSet.bind_student' table. You can move, or remove it, as needed.


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
