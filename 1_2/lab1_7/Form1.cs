using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBoxR.Text);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            labelResult.Text = "Объём шара: " + Math.Round(volume, 4);
        }
    }
}
