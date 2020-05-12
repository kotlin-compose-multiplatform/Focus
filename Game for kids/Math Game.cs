using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_for_kids
{
    public partial class Math_Game : Form
    {
        int a, b, jogap,c,berlen,tru=0;
        string alam;
        public Math_Game()
        {
            InitializeComponent();
        }
        Random r = new Random();

        private void Math_Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
            a = r.Next(1, 25);
            b = r.Next(1, 25);
            c = r.Next(1, 4);
            san1.Text = a.ToString();
            san2.Text = b.ToString();
            if (c == 1)
            {
                alam = "+";
                alamat.Text = alam;
                jogap = a + b;
            }
            if (c == 2)
            {
                alam = "-";
                alamat.Text = alam;
                jogap = a - b;
            }
            if (c == 3)
            {
                alam = "*";
                alamat.Text = alam;
                jogap = a * b;
            }
            if (c == 4)
            {
                alam = "/";
                alamat.Text = alam;
                jogap = a / b;
            }
            if (berlen == jogap)
            {
                tru++;
                label1.Text = "Score: " + tru;

                textBox1.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = r.Next(1, 25);
            b = r.Next(1, 25);
            c = r.Next(1, 4);
            san1.Text = a.ToString();
            san2.Text = b.ToString();
            if (c == 1)
            {
                alam = "+";
                alamat.Text = alam;
                jogap = a + b;
            }
            if (c == 2)
            {
                alam = "-";
                alamat.Text = alam;
                jogap = a - b;
            }
            if (c == 3)
            {
                alam = "*";
                alamat.Text = alam;
                jogap = a * b;
            }
            if (c == 4)
            {
                alam = "/";
                alamat.Text = alam;
                jogap = a / b;
            }
            if (berlen == jogap)
            {
                tru++;
                label1.Text = "Score: " + tru;

            }
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                berlen = int.Parse(textBox1.Text);
                if (berlen == jogap)
                {
                    tru++;
                    
                }
                label1.Text = "Score: " + tru;
                textBox1.Clear();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
                textBox1.Clear();
            }
        }
    }
}
