using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frazione_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2 = Fraction.Parse(textBox2.Text);

             Fraction f3=f1.Somma(f2);
            label1.Text= f3.ToString();

            textBox1.Text= f1.ToString();
            textBox2.Text= f2.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction f =Fraction.Parse(textBox3.Text);
            textBox3.Text= f.ToString();
            listBox1.Items.Add(f);
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction s = new Fraction(0, 2);

            foreach ( Fraction f in listBox1.Items )
            {

                s = f.Somma(s);

            }
            label2.Text = s.ToString();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
