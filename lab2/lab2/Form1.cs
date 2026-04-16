using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color brushColor = Color.Green; // Цвет по умолчанию


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Graphics g = CreateGraphics();
            Pen pn = new Pen(colorDialog1.Color, 5);
            Brush br = new SolidBrush(brushColor);
            g.Clear(SystemColors.Control);
            switch (listBox1.SelectedIndex)
            {
                case 0: g.DrawLine(pn, 150, 40, 350, 180); break;
                case 1: g.DrawRectangle(pn, 150, 30, 250, 150); break;
                case 2: g.FillRectangle(br, 150, 30, 250, 150); break;
                case 3: g.DrawEllipse(pn, 150, 30, 250, 150); break;
                case 4: g.FillEllipse(br, 150, 30, 250, 150); break;
                case 5: g.DrawPie(pn, 150, 30, 200, 200, 180, 225); break;
                case 6: g.FillPie(br, 150, 30, 150, 150, 0, 45); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(SystemColors.Control);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                brushColor = colorDialog2.Color;
            }
        }

    }
}

