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
    public partial class Manyly_sozler : Form
    {
        int a = 0;
        public Manyly_sozler()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            
            a--;
            pictureBox1.ImageLocation = "data\\img\\PHOTO\\img_" + a + ".jpg";
            if (a == 1)
                a = 362;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            pictureBox1.ImageLocation = "data\\img\\PHOTO\\img_" + a + ".jpg";
            if (a == 363)
                a = 1;
        }

        private void Manyly_sozler_Load(object sender, EventArgs e)
        {
            a = r.Next(10, 300);
            pictureBox1.ImageLocation = "data\\img\\PHOTO\\img_" + a + ".jpg";
        }
    }
}
