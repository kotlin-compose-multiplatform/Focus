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
    public partial class Quetus : Form
    {
        int a = 0;
        public Quetus()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            pictureBox1.ImageLocation = "data\\img\\facts\\bg1 ("+a+").jpg";
            if (a == 149)
                a = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a--;
            pictureBox1.ImageLocation = "data\\img\\facts\\bg1 (" + a + ").jpg";
            if (a == 1)
                a = 148;
        }

        private void Quetus_Load(object sender, EventArgs e)
        {
            a = r.Next(10, 100);
            pictureBox1.ImageLocation = "data\\img\\facts\\bg1 (" + a + ").jpg";
        }
    }
}
