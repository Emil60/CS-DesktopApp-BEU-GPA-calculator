using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //int a = 10;
            //long b = a; //implicit conversion


            //long c = 100;
            //int d = (int)c;
            //label1.Text = d.ToString();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a;
            double ave,b;
            a = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text) +
                int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text));
            b = a * 0.1;
            b = b + int.Parse(textBox6.Text) * 0.5;
            if (b - (int)b < 0.5)
                b = (int)b;
            else
                b = (int)b + 1;
            label6.Text = b.ToString();
            a = (int.Parse(textBox7.Text) + int.Parse(textBox8.Text) +
                int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text));
            b = a * 0.1;
            b = b + int.Parse(textBox12.Text) * 0.5;
            if (b - (int)b < 0.5)
                b = (int)b;
            else
                b = (int)b + 1;
            label7.Text = b.ToString();

            a = (int.Parse(textBox13.Text) + int.Parse(textBox14.Text) +
                int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text));
            b = a * 0.1;
            b = b + int.Parse(textBox18.Text) * 0.5;
            if (b - (int)b < 0.5)
                b = (int)b;
            else
                b = (int)b + 1;
            label8.Text = b.ToString();

            a = (int.Parse(textBox19.Text) + int.Parse(textBox20.Text) +
                int.Parse(textBox21.Text) + int.Parse(textBox22.Text) + int.Parse(textBox23.Text));
            b = a * 0.1;
            b = b + int.Parse(textBox24.Text) * 0.5;
            if (b - (int)b < 0.5)
                b = (int)b;
            else
                b = (int)b + 1;
            label9.Text = b.ToString();

            a = (int.Parse(textBox25.Text) + int.Parse(textBox26.Text) +
                int.Parse(textBox27.Text) + int.Parse(textBox28.Text) + int.Parse(textBox29.Text));
            b = a * 0.1;
            b = b + int.Parse(textBox30.Text) * 0.5;
            if (b - (int)b < 0.5)
                b = (int)b;
            else
                b = (int)b + 1;
            label10.Text = b.ToString();

            ave = int.Parse(label6.Text) * 5 +
                int.Parse(label7.Text) * 6 + int.Parse(label8.Text) * 6 +
                int.Parse(label9.Text) * 6 + int.Parse(label10.Text) * 7;
            ave = (double)ave / 30;
            textBox31.Text =ave.ToString();
            ave = (94.2 + 91.57 + 90.07 + 80.2 + ave) / 5;
            textBox32.Text = ave.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
