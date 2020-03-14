using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Калькулятор : Form
    {
        public int Flag;
        public Калькулятор()
        {
            InitializeComponent();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       
        private void plus_Click(object sender, EventArgs e)
        {
           
            Flag = 0;
        }
        

        private void vivod_Click(object sender, EventArgs e)
        {
            int a; double b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
          
            
            if (Flag == 0)

            {
                vivod.Text = Convert.ToString(a + b);
            }
                if (Flag==1)
            {
                    vivod.Text = Convert.ToString(a - b);
            }
            if (Flag == 2)
            {
                vivod.Text = Convert.ToString(a * b);
            }
            if (Flag == 3)
            {
                vivod.Text = Convert.ToString(a / b);
            }
        }

        private void umnogenie_Click(object sender, EventArgs e)
        {
            
            Flag = 2;

        }

        private void delenie_Click(object sender, EventArgs e)
        {
           
            Flag = 3;
        }

        private void ochistka_Click(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {
            
            Flag = 1;
        }
    }

}
