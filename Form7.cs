using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Flag;
        public double a, b; // сохранить a-первый аргумент, b-второйprivate void textBox1_TextChanged(object sender, EventArgs e)
        
        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            Flag = 0;
            label1.Text = "+";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "+";// сложение
        }

        private void umnogenie_Click(object sender, EventArgs e)
        {
            Flag = 2;
            label1.Text = "*";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "*"; //умножение
        }

        private void delenie_Click(object sender, EventArgs e)
        {
            Flag = 3;
            label1.Text = "/";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "/"; //деление
        }

        private void ochistka_Click(object sender, EventArgs e)
        {
            tb.Text = " ";
            a = 0;
            b = 0; //стереть содержимое памяти
        }

        private void odin_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "1"; //клавиша 1
        }

        private void dva_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "2";//клавиша 2
        }

        private void tri_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "3";//клавиша 3
        }

        private void chetiri_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "4";//клавиша 4
        }

        private void pat_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "5";//клавиша 5
        }

        private void chest_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "6";//клавиша 6
        }

        private void sem_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "7";//клавиша 7
        }

        private void vosem_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "8";//клавиша 8
        }

        private void devet_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "9";//клавиша 9
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Flag = 1;
            label1.Text = "-";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "-"; //вычитание
        }

        private void nul_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "0"; //клавиша 0
        }

        private void cos_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Cos(Convert.ToDouble(tb.Text)).ToString();
        }

        private void koren_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Sqrt(Convert.ToDouble(tb.Text)).ToString();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Tan(Convert.ToDouble(tb.Text)).ToString();

        }

        private void sin_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Sin(Convert.ToDouble(tb.Text)).ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Log(Convert.ToDouble(tb.Text)).ToString();
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            tb.Text = (1 / Math.Tan(Convert.ToDouble(tb.Text))).ToString();
        }

        private void stepen_Click(object sender, EventArgs e)
        {
            Math.Pow(Convert.ToDouble(3), Convert.ToDouble(2)).ToString();

        }

        private void exsponenta_Click(object sender, EventArgs e)
        {
            Math.Exp(Convert.ToDouble(2));
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(tb.Text); if (Flag == 0)
            {
                tb.Text = Convert.ToString(a + b); //действия функций}
                if (Flag == 1)
                {
                    tb.Text = Convert.ToString(a - b);
                }
                if (Flag == 2)
                {
                    tb.Text = Convert.ToString(a * b);
                }
                if (Flag == 3)
                {
                    tb.Text = Convert.ToString(a / b);
                }


            }
        }
    }
}

