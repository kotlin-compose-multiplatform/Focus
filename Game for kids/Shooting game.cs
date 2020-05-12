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
    public partial class Shooting_game : Form
    {

        Random random = new Random();
        List<string> icons = new List<string>
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z"


        };
        Label firstclick, secondclick;
        public Shooting_game()
        {
            InitializeComponent();
            assign();
        }
        private void assign()
        {
            Label label;
            int randomnumber;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomnumber = random.Next(0, icons.Count);
                label.Text = icons[randomnumber];
                icons.RemoveAt(randomnumber);


            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstclick.ForeColor = firstclick.BackColor;
            secondclick.ForeColor = secondclick.BackColor;
            firstclick = null;
            secondclick = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Shooting_game_Load(object sender, EventArgs e)
        {
            
        }

        private void Shooting_game_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label(object sender, EventArgs e)
        {
            if (firstclick != null && secondclick != null)
                return;
            Label clicklabel = sender as Label;

            if (clicklabel == null)
                return;
            if (clicklabel.ForeColor == Color.Black)
                return;
            if (firstclick == null)
            {
                firstclick = clicklabel;
                firstclick.ForeColor = Color.Black;
                return;
            }
            secondclick = clicklabel;
            secondclick.ForeColor = Color.Black;

            checkforwinner();

            if (firstclick.Text == secondclick.Text)
            {
                firstclick = null;
                secondclick = null;

            }
            else
                timer1.Start();
        }
        private void checkforwinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            MessageBox.Show("You win!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
