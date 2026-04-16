using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
double r1 = double.Parse(textBox1.Text);
double r2 = double.Parse(textBox2.Text);


double s = 3.14 * (r1 * r1 - r2 * r2);


label4.Text = Math.Abs(s).ToString();

    }
}
