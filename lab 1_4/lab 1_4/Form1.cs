using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_4
{
    public partial class Form1 : Form
    {
        int m, s;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            m = 0;
            s = 0;
            label1.Text = "00";
            label3.Text = "00";
            label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";
                button2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m = 0;
            s = 0;
            label1.Text = "00";
            label3.Text = "00";
            label2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Visible)
            {
                if (s < 59)
                {
                    s++;
                    label3.Text = (s < 10) ? "0" + s.ToString() : s.ToString();
                }
                else
                {
                    if (m < 59)
                    {
                        m++;
                        label1.Text = (m < 10) ? "0" + m.ToString() : m.ToString();
                        s = 0;
                        label3.Text = "00";
                    }
                    else
                    {
                        m = 0;
                        label1.Text = "00";
                    }
                }
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}