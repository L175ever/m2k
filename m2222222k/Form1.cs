using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m2222222k
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') !=-1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double mile;
            double km;
            try
            {
                mile = Convert.ToDouble(textBox1.Text);
                km = mile * 1.609344;
                label2.Text = km.ToString("n")
                              + " км.";
            }
            catch
            {
                textBox1.Focus();
            }
        }
        
        //////////// вторая кнопка
        
        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs n)
        {
            if ((n.KeyChar >= '0') && (n.KeyChar <= '9'))
            {
                return;
            }
            if (n.KeyChar == '.')
            {
                n.KeyChar = ',';
            }
            if (n.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    n.Handled = true;
                }
                return;
            }
            if (Char.IsControl(n.KeyChar))
            {
                if (n.KeyChar == (char)Keys.Enter)
                    button2.Focus();
                return;
            }
            n.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double mile;
            double km;
            try
            {
                km = Convert.ToDouble(textBox2.Text);
                mile = km / 1.609344;
                label4.Text = mile.ToString("n")
                              + " мили.";
            }
            catch
            {
                textBox2.Focus();
            }

        }
    }
}
