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
    public partial class Picture : Form
    {
        
        string berlen;
        string h;
        int a,hasap=0;
        public Picture()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void Picture_Load(object sender, EventArgs e)
        {
            a = r.Next(1, 40);
            if (a == 1)
                h = "stadium";
            if (a == 2)
                h = "earth";
            if (a == 3)
                h = "grass";
            if (a == 4)
                h = "doctor";
            if (a == 5)
                h = "robot";
            if (a == 6)
                h = "airplane";
            if (a == 7)
                h = "teacher";
            if (a == 8)
                h = "pupil";
            if (a == 9)
                h = "math";
            if (a == 10)
                h = "run";
            if (a == 11)
                h = "heart";
            if (a == 12)
                h = "google";
            if (a == 13)
                h = "star";
            if (a == 14)
                h = "mole";
            if (a == 15)
                h = "book";
            if (a == 16)
                h = "wikipedia";
            if (a == 17)
                h = "school";
            if (a == 18)
                h = "coin";
            if (a == 19)
                h = "youtube";
            if (a == 20)
                h = "copy";
            if (a == 21)
                h = "excel";
            if (a == 22)
                h = "virus";
            if (a == 23)
                h = "scientist";
            if (a == 24)
                h = "rain";
            if (a == 25)
                h = "sell";
            if (a == 26)
                h = "brick";

            if (a == 27)
                h = "baby";
            if (a == 28)
                h = "computer";
            if (a == 29)
                h = "like";

            if (a == 30)
                h = "cat";
            if (a == 31)
                h = "horse";
            if (a == 32)
                h = "dog";
            if (a == 33)
                h = "pencil";
            if (a == 34)
                h = "pen";
            if (a == 35)
                h = "phone";
            if (a == 36)
                h = "ball";
            if (a == 37)
                h = "map";
            if (a == 38)
                h = "notebook";
            if (a == 39)
                h = "door";
            if (a == 40)
                h = "seasons";
            pictureBox1.ImageLocation = "data\\img\\" + a + ".jpg";
            label3.Text = "Score: " + hasap;
            label4.Text = h.Length + " letter";
            textBox1.Text = h[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            berlen = textBox1.Text.ToLower();
            if (a == 1)
                h = "stadium";
            if (a == 2)
                h = "earth";
            if (a == 3)
                h = "grass";
            if (a == 4)
                h = "doctor";
            if (a == 5)
                h = "robot";
            if (a == 6)
                h = "airplane";
            if (a == 7)
                h = "teacher";
            if (a == 8)
                h = "pupil";
            if (a == 9)
                h = "math";
            if (a == 10)
                h = "run";
            if (a == 11)
                h = "heart";
            if (a == 12)
                h = "google";
            if (a == 13)
                h = "star";
            if (a == 14)
                h = "mole";
            if (a == 15)
                h = "book";
            if (a == 16)
                h = "wikipedia";
            if (a == 17)
                h = "school";
            if (a == 18)
                h = "coin";
            if (a == 19)
                h = "youtube";
            if (a == 20)
                h = "copy";
            if (a == 21)
                h = "excel";
            if (a == 22)
                h = "virus";
            if (a == 23)
                h = "scientist";
            if (a == 24)
                h = "rain";
            if (a == 25)
                h = "sell";
            if (a == 26)
                h = "brick";

            if (a == 27)
                h = "baby";
            if (a == 28)
                h = "computer";
            if (a == 29)
                h = "like";

            if (a == 30)
                h = "cat";
            if (a == 31)
                h = "horse";
            if (a == 32)
                h = "dog";
            if (a == 33)
                h = "pencil";
            if (a == 34)
                h = "pen";
            if (a == 35)
                h = "phone";
            if (a == 36)
                h = "ball";
            if (a == 37)
                h = "map";
            if (a == 38)
                h = "notebook";
            if (a == 39)
                h = "door";
            if (a == 40)
                h = "seasons";
            if (berlen != h)
            {
                falseimg.Visible = true;
                trueimg.Visible = false;
                label4.Text = h.Length + " letter";
                textBox1.Text = h[0].ToString();
            }
            else
                if (berlen == h)
                {
                    hasap++;
                    falseimg.Visible = false;
                    trueimg.Visible = true;
                    a = r.Next(1, 40);
                    pictureBox1.ImageLocation = "data\\img\\" + a + ".jpg";
                    label3.Text = "Score: " + hasap;



                }
            
            if (a == 1)
                h = "stadium";
            if (a == 2)
                h = "earth";
            if (a == 3)
                h = "grass";
            if (a == 4)
                h = "doctor";
            if (a == 5)
                h = "robot";
            if (a == 6)
                h = "airplane";
            if (a == 7)
                h = "teacher";
            if (a == 8)
                h = "pupil";
            if (a == 9)
                h = "math";
            if (a == 10)
                h = "run";
            if (a == 11)
                h = "heart";
            if (a == 12)
                h = "google";
            if (a == 13)
                h = "star";
            if (a == 14)
                h = "mole";
            if (a == 15)
                h = "book";
            if (a == 16)
                h = "wikipedia";
            if (a == 17)
                h = "school";
            if (a == 18)
                h = "coin";
            if (a == 19)
                h = "youtube";
            if (a == 20)
                h = "copy";
            if (a == 21)
                h = "excel";
            if (a == 22)
                h = "virus";
            if (a == 23)
                h = "scientist";
            if (a == 24)
                h = "rain";
            if (a == 25)
                h = "sell";
            if (a == 26)
                h = "brick";

            if (a == 27)
                h = "baby";
            if (a == 28)
                h = "computer";
            if (a == 29)
                h = "like";

            if (a == 30)
                h = "cat";
            if (a == 31)
                h = "horse";
            if (a == 32)
                h = "dog";
            if (a == 33)
                h = "pencil";
            if (a == 34)
                h = "pen";
            if (a == 35)
                h = "phone";
            if (a == 36)
                h = "ball";
            if (a == 37)
                h = "map";
            if (a == 38)
                h = "notebook";
            if (a == 39)
                h = "door";
            if (a == 40)
                h = "seasons";

            label4.Text = h.Length + " letter";
            textBox1.Text = h[0].ToString();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            falseimg.Visible = false;
            trueimg.Visible = false;
        }
    }
}
