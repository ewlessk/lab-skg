using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_8
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

            if (a + b >= 180)
            {
                labelResult.Text = "Ошибка: сумма углов >= 180°";
                return;
            }

            double c = 180 - a - b;
            labelResult.Text = "Третий угол: " + c + "°";
        }
    }
    }
