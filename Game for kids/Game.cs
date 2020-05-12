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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
               


            }
          
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
