using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double h = double.Parse(textBoxH.Text);

            double volume = a * b * h;
            labelResult.Text = "Объём: " + volume;
        }
    }
}
