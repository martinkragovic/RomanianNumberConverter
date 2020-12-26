using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,suma=0;
            string txt = TB1.Text;
            int brojac = txt.Length;
            
            for(i=0;i<brojac;i++)
            {
                if (txt[i] == 'I')
                    suma++;
                else if (txt[i] == 'V')
                    suma += 5;
                else if (txt[i] == 'X')
                    suma += 10;
                else if (txt[i] == 'L')
                    suma += 50;
                else if (txt[i] == 'C')
                    suma += 100;
                else if (txt[i] == 'D')
                    suma += 500;
                else if (txt[i] == 'M')
                    suma += 1000;
            }
            string suma1 = Convert.ToString(suma);
            TB2.Text = suma1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
