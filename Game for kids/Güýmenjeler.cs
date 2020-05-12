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
    public partial class Güýmenjeler : Form
    {
        public Güýmenjeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Shooting_game shot = new Shooting_game();
            shot.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Racing raci = new Racing();
            raci.Show();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Math_Game mat = new Math_Game();
            mat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Picture df = new Picture();
            df.Show();
        }

    }
}
