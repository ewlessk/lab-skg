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
            try
            {
                // Считываем значения из текстовых полей
                double r1 = double.Parse(textBox1.Text);
                double r2 = double.Parse(textBox2.Text);

                // Считаем площадь кольца: S = π * |R1² - R2²|
                double area = Math.PI * Math.Abs(Math.Pow(r1, 2) - Math.Pow(r2, 2));

                // Выводим результат, округлив до 2 знаков после запятой
                label4.Text = $"Площадь : {area:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("некорректные значения");
            }

        }
    }
}
