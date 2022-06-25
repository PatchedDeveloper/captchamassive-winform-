using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] mass = new int [4];
            int i;
           int ch = 1;
            Random rand = new Random();
            for(i=0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(5);
                if (mass[i]>0 && mass[i]<5)
                {
                    ch = mass[i];
                }
            }
           string c = Convert.ToString(ch);
            label2.Text = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == label2.Text)
            {
                MessageBox.Show("Вы успешно прошли капчу!");
            }
            else
                MessageBox.Show("Не верная капча!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == label2.Text)
            {
                MessageBox.Show("Вы успешно прошли капчу!");
            }
            else
                MessageBox.Show("Не верная капча!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == label2.Text)
            {
                MessageBox.Show("Вы успешно прошли капчу!");
            }
            else
                MessageBox.Show("Не верная капча!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == label2.Text)
            {
                MessageBox.Show("Вы успешно прошли капчу!");
            }
            else
                MessageBox.Show("Не верная капча!");
        }
    }
}
