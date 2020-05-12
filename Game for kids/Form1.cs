using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_for_kids
{
    public partial class Form1 : Form
    {
        int x, y,x1,y1;
        int tt = 0;
        int soragsany = 0;
        int umumysoarag = 15;
        int jk = 0;
        int yyldyz = 0, coin = 0,money=0, sha=0,k=0;
        int umumyyyldyz;
        int yalnysh = 0;
        string[] srg = new string[10000];
        string[] ajogap = new string[10000];
        string[] bjogap = new string[10000];
        string[] cjogap = new string[10000];
        string[] djogap = new string[10000];
        string[] jogap = new string[10000];
        string saylananjogap;
        int[] cykansoraglar = new int[301];
        public Form1()
        {
            InitializeComponent();
        }
        Random ran = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = pictureBox3.Location.X;
            y = pictureBox3.Location.Y;
            x = x + 10;
            x1 = pictureBox1.Location.X;
            y1 = pictureBox1.Location.Y;
            x1= x1 + 10;
            if (x >= 1936)
            {

                x = -10;
            }
            if (x1 >= 1950)
            {

                x1 = -10;
            }
            pictureBox3.Location = new Point(x, y);
            pictureBox1.Location = new Point(x1, y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game qwerty = new Game();
            qwerty.ShowDialog();
            level1fun();
            timer1.Start();
            level2loc.Visible = false;
            level3loc.Visible = false;
            level4loc.Visible = false;
            level5loc.Visible = false;
            level6loc.Visible = false;
            level7loc.Visible = false;
            level8loc.Visible = false;
            level9loc.Visible = false;
            level10loc.Visible = false;
            comboBox1.SelectedIndex = 0;
            StreamReader sr = File.OpenText("data\\data.dll");
            money = int.Parse(sr.ReadLine());
            umumyyyldyz = int.Parse(sr.ReadLine());
            sr.Close();
            
            coinlbl.Text = "Hasap: " + money;
            starlbl.Text = "Ýyldyz: " + umumyyyldyz;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox20.Image;
                
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox19.Image;
                
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            play();
            timer2.Start();
        }
        private void play()
        {
            guymenjelerlbl.Visible = false;
            playlbl.Visible = false;
            factslbl.Visible = false;
            pictureBox22.Visible = false;
            button4.Visible = false;
            coinlbl.Visible = true;
            coinpicture.Visible = true;
            starlbl.Visible = true;
            starpicture.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            BackgroundImage = null;
            label1.Visible = true;
            level1.Visible = true;
            level2.Visible = true;
            level3.Visible = true;
            level4.Visible = true;
            level5.Visible = true;
            level6.Visible = true;
            level7.Visible = true;
            level8.Visible = true;
            level9.Visible = true;
            level10.Visible = true;
            button3.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox1.Visible = false;
            //pictureBox6.Visible = false;
            //pictureBox5.Visible = false;
            //pictureBox7.Visible = false;
            level2loc.Visible = true;
            level3loc.Visible = true;
            level4loc.Visible = true;
            level5loc.Visible = true;
            level6loc.Visible = true;
            level7loc.Visible = true;
            level8loc.Visible = true;
            level9loc.Visible = true;
            level10loc.Visible = true;
            axWindowsMediaPlayer1.URL = "";
            label2.Visible = true;
            comboBox1.Visible = true;
            BackColor = Color.White;
            
        }
        private void yza()
        {
            pictureBox22.Visible = true;
            guymenjelerlbl.Visible = true;
            playlbl.Visible = true;
            factslbl.Visible = true;
            button4.Visible = true;
            label2.Visible = false;
            comboBox1.Visible = false;
            coinlbl.Visible = false;
            coinpicture.Visible = false;
            starlbl.Visible = false;
            starpicture.Visible = false;
            label1.Visible = false;
            level1.Visible = false;
            level2.Visible = false;
            level3.Visible = false;
            level4.Visible = false;
            level5.Visible = false;
            level6.Visible = false;
            level7.Visible = false;
            level8.Visible = false;
            level9.Visible = false;
            level10.Visible = false;
            button3.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox1.Visible = true;
            //pictureBox6.Visible = true;
            //pictureBox5.Visible = true;
            //pictureBox7.Visible = true;
            level2loc.Visible = false;
            level3loc.Visible = false;
            level4loc.Visible = false;
            level5loc.Visible = false;
            level6loc.Visible = false;
            level7loc.Visible = false;
            level8loc.Visible = false;
            level9loc.Visible = false;
            level10loc.Visible = false;
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
            yza();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Lime;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void level1_Click(object sender, EventArgs e)
        {
            level1fun();
            sha=1;
            tt = ran.Next(0, 150);
            soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k]=tt;
            groupBox1.Visible = true;
            bashla();
        }
        private void level1fun()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i <= jk; i++)
                {
                    srg[i] = "";
                    ajogap[i] = "";
                    bjogap[i] = "";
                    cjogap[i] = "";
                    djogap[i] = "";
                    jogap[i] = "";


                }
                string baglan = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection con = new OleDbConnection(baglan);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select Sorag from test", con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "table");
                DataTable datatable = ds.Tables["table"];
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    srg[i] = (string)datatable.Rows[i].ItemArray[0];
                }
                con.Close();
                string baglana = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection cona = new OleDbConnection(baglana);
                OleDbDataAdapter dataAdaptera = new OleDbDataAdapter("select a from test", cona);
                DataSet dsa = new DataSet();
                dataAdaptera.Fill(dsa, "table");
                DataTable datatablea = dsa.Tables["table"];
                for (int i = 0; i < datatablea.Rows.Count; i++)
                {
                    ajogap[i] = (string)datatablea.Rows[i].ItemArray[0];
                }
                cona.Close();
                string baglanas = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conas = new OleDbConnection(baglanas);
                OleDbDataAdapter dataAdapteras = new OleDbDataAdapter("select b from test", conas);
                DataSet dsas = new DataSet();
                dataAdapteras.Fill(dsas, "table");
                DataTable datatableas = dsas.Tables["table"];
                for (int i = 0; i < datatableas.Rows.Count; i++)
                {
                    bjogap[i] = (string)datatableas.Rows[i].ItemArray[0];
                }
                conas.Close();


                string baglanak = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conak = new OleDbConnection(baglanak);
                OleDbDataAdapter dataAdapterak = new OleDbDataAdapter("select c from test", conak);
                DataSet dsak = new DataSet();
                dataAdapterak.Fill(dsak, "table");
                DataTable datatableak = dsak.Tables["table"];
                for (int i = 0; i < datatableak.Rows.Count; i++)
                {
                    cjogap[i] = (string)datatableak.Rows[i].ItemArray[0];
                }
                conak.Close();
                string baglanasd = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conasd = new OleDbConnection(baglanasd);
                OleDbDataAdapter dataAdapterasd = new OleDbDataAdapter("select d from test", conasd);
                DataSet dsasd = new DataSet();
                dataAdapterasd.Fill(dsasd, "table");
                DataTable datatableasd = dsasd.Tables["table"];
                for (int i = 0; i < datatableasd.Rows.Count; i++)
                {
                    djogap[i] = (string)datatableasd.Rows[i].ItemArray[0];
                }
                conasd.Close();

                string baglanasdj = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conasdj = new OleDbConnection(baglanasdj);
                OleDbDataAdapter dataAdapterasdj = new OleDbDataAdapter("select jogap from test", conasdj);
                DataSet dsasdj = new DataSet();
                dataAdapterasdj.Fill(dsasdj, "table");
                DataTable datatableasdj = dsasdj.Tables["table"];
                for (int i = 0; i < datatableasdj.Rows.Count; i++)
                {
                    jogap[i] = (string)datatableasdj.Rows[i].ItemArray[0];
                    jk = i;
                }
                conasdj.Close();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                for (int i = 0; i <= jk; i++)
                {
                    srg[i] = "";
                    ajogap[i] = "";
                    bjogap[i] = "";
                    cjogap[i] = "";
                    djogap[i] = "";
                    jogap[i] = "";


                }
                string baglan = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection con = new OleDbConnection(baglan);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select Sorag from en", con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "table");
                DataTable datatable = ds.Tables["table"];
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    srg[i] = (string)datatable.Rows[i].ItemArray[0];
                }
                con.Close();
                string baglana = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection cona = new OleDbConnection(baglana);
                OleDbDataAdapter dataAdaptera = new OleDbDataAdapter("select a from en", cona);
                DataSet dsa = new DataSet();
                dataAdaptera.Fill(dsa, "table");
                DataTable datatablea = dsa.Tables["table"];
                for (int i = 0; i < datatablea.Rows.Count; i++)
                {
                    ajogap[i] = (string)datatablea.Rows[i].ItemArray[0];
                }
                cona.Close();
                string baglanas = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conas = new OleDbConnection(baglanas);
                OleDbDataAdapter dataAdapteras = new OleDbDataAdapter("select b from en", conas);
                DataSet dsas = new DataSet();
                dataAdapteras.Fill(dsas, "table");
                DataTable datatableas = dsas.Tables["table"];
                for (int i = 0; i < datatableas.Rows.Count; i++)
                {
                    bjogap[i] = (string)datatableas.Rows[i].ItemArray[0];
                }
                conas.Close();


                string baglanak = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conak = new OleDbConnection(baglanak);
                OleDbDataAdapter dataAdapterak = new OleDbDataAdapter("select c from en", conak);
                DataSet dsak = new DataSet();
                dataAdapterak.Fill(dsak, "table");
                DataTable datatableak = dsak.Tables["table"];
                for (int i = 0; i < datatableak.Rows.Count; i++)
                {
                    cjogap[i] = (string)datatableak.Rows[i].ItemArray[0];
                }
                conak.Close();
                string baglanasd = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conasd = new OleDbConnection(baglanasd);
                OleDbDataAdapter dataAdapterasd = new OleDbDataAdapter("select d from en", conasd);
                DataSet dsasd = new DataSet();
                dataAdapterasd.Fill(dsasd, "table");
                DataTable datatableasd = dsasd.Tables["table"];
                for (int i = 0; i < datatableasd.Rows.Count; i++)
                {
                    djogap[i] = (string)datatableasd.Rows[i].ItemArray[0];
                }
                conasd.Close();

                string baglanasdj = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=test.mdb";

                OleDbConnection conasdj = new OleDbConnection(baglanasdj);
                OleDbDataAdapter dataAdapterasdj = new OleDbDataAdapter("select jogap from en", conasdj);
                DataSet dsasdj = new DataSet();
                dataAdapterasdj.Fill(dsasdj, "table");
                DataTable datatableasdj = dsasdj.Tables["table"];
                for (int i = 0; i < datatableasdj.Rows.Count; i++)
                {
                    jogap[i] = (string)datatableasdj.Rows[i].ItemArray[0];
                    jk = i;
                }
                conasdj.Close();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void level2_Click(object sender, EventArgs e)
        {
            sha = 2; tt = ran.Next(0, 150);
            groupBox1.Visible = true; bashla();
            ok(); level1fun();
            soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }
        private void ok()
        {
            tt = ran.Next(0, 150);
            soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (money >= 10)
            {
                level2loc.Visible = false;
                level2.Enabled = true;


            }
            if (money >= 20)
            {
                level3loc.Visible = false;
                level3.Enabled = true;


            }
            if (money >= 30)
            {
                level4loc.Visible = false;
                level4.Enabled = true;


            }
            if (money >= 40)
            {
                level5loc.Visible = false;
                level5.Enabled = true;


            }
            if (money >= 50)
            {
                level6loc.Visible = false;
                level6.Enabled = true;


            }
            if (money >= 60)
            {
                level7loc.Visible = false;
                level7.Enabled = true;


            }
            if (money >= 70)
            {
                level8loc.Visible = false;
                level8.Enabled = true;


            }
            if (money >= 80)
            {
                level9loc.Visible = false;
                level9.Enabled = true;


            }
            if (money >= 90)
            {
                level10loc.Visible = false;
                level10.Enabled = true;


            }






          
           
        }

        private void level3_Click(object sender, EventArgs e)
        {
            sha = 3; tt = ran.Next(0, 150); bashla();
            groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }

        private void level4_Click(object sender, EventArgs e)
        {
            sha = 4; tt = ran.Next(0, 150); bashla(); groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }

        private void level5_Click(object sender, EventArgs e)
        {
            sha = 5; tt = ran.Next(0, 150); bashla(); groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }

        private void level6_Click(object sender, EventArgs e)
        {
            sha = 6; tt = ran.Next(0, 150); bashla(); groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }

        private void level7_Click(object sender, EventArgs e)
        {
            sha = 7; tt = ran.Next(0, 150); bashla(); groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }

        private void level8_Click(object sender, EventArgs e)
        {
            sha = 8; tt = ran.Next(0, 150); bashla(); groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;

        }

        private void level9_Click(object sender, EventArgs e)
        {
            sha = 9; tt = ran.Next(0, 150); bashla(); groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }

        private void level10_Click(object sender, EventArgs e)
        {
            sha = 10; tt = ran.Next(0, 150); bashla(); groupBox1.Visible = true; ok(); level1fun(); soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
        }

        private void level11_Click(object sender, EventArgs e)
        {
            sha = 11; tt = ran.Next(0, 300);
        }

        private void level12_Click(object sender, EventArgs e)
        {
            sha = 12; tt = ran.Next(0, 300);
        }

        private void level13_Click(object sender, EventArgs e)
        {
            sha = 13; tt = ran.Next(0, 300);
        }

        private void level14_Click(object sender, EventArgs e)
        {
            sha = 14; tt = ran.Next(0, 300);
        }

        private void level15_Click(object sender, EventArgs e)
        {
            sha = 15; tt = ran.Next(0, 300);
        }

        private void level16_Click(object sender, EventArgs e)
        {
            sha = 16; tt = ran.Next(0, 300);
        }

        private void level17_Click(object sender, EventArgs e)
        {
            sha = 17; tt = ran.Next(0, 300);
        }

        private void level18_Click(object sender, EventArgs e)
        {
            sha = 18; tt = ran.Next(0, 300);
        }

        private void level19_Click(object sender, EventArgs e)
        {
            sha = 19; tt = ran.Next(0, 300);
        }

        private void level20_Click(object sender, EventArgs e)
        {
            sha = 20; tt = ran.Next(0, 300);
        }

        private void level21_Click(object sender, EventArgs e)
        {
            sha = 21; tt = ran.Next(0, 300);
        }

        private void level22_Click(object sender, EventArgs e)
        {
            sha = 22; tt = ran.Next(0, 300);
        }

        private void level23_Click(object sender, EventArgs e)
        {
            sha = 23; tt = ran.Next(0, 300);
        }

        private void level24_Click(object sender, EventArgs e)
        {
            sha = 24; tt = ran.Next(0, 300);
        }

        private void level25_Click(object sender, EventArgs e)
        {
            sha = 25; tt = ran.Next(0, 300);
        }

        private void level26_Click(object sender, EventArgs e)
        {
            sha = 26; tt = ran.Next(0, 300);
        }

        private void level27_Click(object sender, EventArgs e)
        {
            sha = 27; tt = ran.Next(0, 300);
        }

        private void level28_Click(object sender, EventArgs e)
        {
            sha = 28; tt = ran.Next(0, 300);
        }

        private void level29_Click(object sender, EventArgs e)
        {
            sha = 29; tt = ran.Next(0, 300);
        }

        private void level30_Click(object sender, EventArgs e)
        {
            sha = 30; tt = ran.Next(0, 300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soragsany++;
            umumysoarag--;
            if (awariant.Checked)
                saylananjogap = awariant.Text;
            if (bwariant.Checked)
                saylananjogap = bwariant.Text;
            if (cwariant.Checked)
                saylananjogap = cwariant.Text;
            if (dwariant.Checked)
                saylananjogap = dwariant.Text;
            if (saylananjogap == jogap[tt])
            {
                coin++;
                money++;
                resultimg.Image = trueimg.Image;
                timer3.Start();

            }
            else
            {
                yalnysh++;
                resultimg.Image = falseimg.Image;
                timer3.Start();
            }
            
            tt = ran.Next(0, 150);
            for (int i = 0; i <= k; i++)
            {
                if (tt == cykansoraglar[i])
                    tt = ran.Next(0, 150);
                else
                    tt = tt;
            }
            k++;

            if (comboBox1.SelectedIndex == 1)
            {
                coinlbl.Text = "Coin: " + money;
                starlbl.Text = "Star: " + umumyyyldyz;
                soargsanylbl.Text = "Number of questions: " + umumysoarag;
                dogry.Text = "True: " + coin;
                yalnyshlbl.Text = "False: " + yalnysh;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                coinlbl.Text = "Hasap: " + money;
                starlbl.Text = "Ýyldyz: " + umumyyyldyz;
                soargsanylbl.Text = "Soraglaryň sany: " + umumysoarag;
                dogry.Text = "Dogry: " + coin;
                yalnyshlbl.Text = "Ýalňyş: " + yalnysh;
            }
            soraglbl.Text = srg[tt];
            awariant.Text = ajogap[tt];
            bwariant.Text = bjogap[tt];
            cwariant.Text = cjogap[tt];
            dwariant.Text = djogap[tt];
            cykansoraglar[k] = tt;
            awariant.Checked = false;
            bwariant.Checked = false;
            cwariant.Checked = false;
            dwariant.Checked = false;
            panel2.Visible = true;
            if (soragsany == 15)
            {
                if (coin >= 3 && coin<8)
                    yyldyz = 1;
                else
                    if (coin >=8 && coin < 13)
                        yyldyz = 2;
                    else
                        if (coin >= 13 && coin <= 15)
                            yyldyz = 3;
                umumyyyldyz = umumyyyldyz + yyldyz;
                StreamWriter sw = File.CreateText("data\\data.dll");
                sw.WriteLine(money);
                sw.WriteLine(umumyyyldyz);
                sw.Close();
                if (comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Hasap: " + coin + "\nÝyldyz: " + yyldyz, "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (comboBox1.SelectedIndex == 1)
                {
                    MessageBox.Show("Coin: " + coin + "\nStar: " + yyldyz,"!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    coinlbl.Text = "Coin: " + money;
                    starlbl.Text = "Star: " + umumyyyldyz;
                    soargsanylbl.Text = "Soraglaryň sany: ";
                    dogry.Text = "True: ";
                    yalnyshlbl.Text = "False: ";
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    coinlbl.Text = "Hasap: " + money;
                    starlbl.Text = "Ýyldyz: " + umumyyyldyz;
                    soargsanylbl.Text = "Soraglaryň sany: ";
                    dogry.Text = "Dogry: ";
                    yalnyshlbl.Text = "Ýalňyş: ";
                }
                groupBox1.Visible = false;
                soragsany = 0;
                coin = 0;
                play();
                umumysoarag = 15;
                yalnysh = 0;
                if (comboBox1.SelectedIndex == 1)
                {
                    coinlbl.Text = "Coin: " + money;
                    starlbl.Text = "Star: " + umumyyyldyz;
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    coinlbl.Text = "Hasap: " + money;
                    starlbl.Text = "Ýyldyz: " + umumyyyldyz;
                }
            }
            if (tt > 150)
                tt = 0;

            if (sha == 1)
            {





            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "<<YZA";
                label2.Text = "Dili:";
                coinlbl.Text = "Hasap:" + money;
                starlbl.Text = "Ýyldyz:" + umumyyyldyz;
                button2.Text = "Indiki";
                button1.Text = "Bes etmek";
                button3.Text = "Oýuny täzeden başlat";
                button4.Text = "Güýmenjeler";
                soargsanylbl.Text = "Soraglaryň sany: ";
                playlbl.Text = "Test Levels";
                guymenjelerlbl.Text = "Güýmenjeler";
                factslbl.Text = "Manyly sozler";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                playlbl.Text = "Test Levels";
                guymenjelerlbl.Text = "Pastime";
                factslbl.Text = "Facts/Quotes";
                button4.Text = "Pastime";
                label1.Text = "<<Back";
                label2.Text = "Lang:";
                coinlbl.Text = "Coin:" + money;
                starlbl.Text = "Star:" + umumyyyldyz;
                button2.Text = "Next";
                button1.Text = "Cancel";
                button3.Text = "Restart Game";
                soargsanylbl.Text = "Number of questions: ";
            }
        }
        private void bashla()
        {
            button4.Visible = false;
           this.BackgroundImage = bg.Image;
            comboBox1.Visible = false;
            starlbl.Visible = false;
            starpicture.Visible = false;
            coinlbl.Visible = false;
            coinpicture.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            level2loc.Visible = false;
            level3loc.Visible = false;
            level4loc.Visible = false;
            level5loc.Visible = false;
            level6loc.Visible = false;
            level7loc.Visible = false;
            level8loc.Visible = false;
            level9loc.Visible = false;
            level10loc.Visible = false;
            label1.Visible = false;
            level1.Visible = false;
            level2.Visible = false;
            level3.Visible = false;
            level4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            level5.Visible = false;
            level6.Visible = false;
            level7.Visible = false;
            level8.Visible = false;
            level9.Visible = false;
            level10.Visible = false;
            button3.Visible = false;
            BackColor = Color.White;
            
            axWindowsMediaPlayer1.URL = "data\\music.mp3";
            if (comboBox1.SelectedIndex == 1)
            {
                coinlbl.Text = "Coin: " + money;
                starlbl.Text = "Star: " + umumyyyldyz;
                soargsanylbl.Text = "Number of questions: " + umumysoarag;
                dogry.Text = "True: ";
                yalnyshlbl.Text = "False: ";
            }
            if (comboBox1.SelectedIndex == 0)
            {
                coinlbl.Text = "Hasap: " + money;
                starlbl.Text = "Ýyldyz: " + umumyyyldyz;
                soargsanylbl.Text = "Soraglaryň sany: ";
                dogry.Text = "Dogry: ";
                yalnyshlbl.Text = "Ýalňyş: ";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            play();
            groupBox1.Visible = false;
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                var wr = MessageBox.Show("Seniň ähli alan ýyldyzlaryň we teňňeleriň öçüriler!\nSen razymy?", "Üns beriň!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (wr.ToString() == "No")
            {



            }
            else
            {
                StreamWriter sw = File.CreateText("data\\data.dll");
                sw.WriteLine(0);
                sw.WriteLine(0);
                sw.Close();
                Application.Restart();
            }
            }
            if (comboBox1.SelectedIndex == 1)
            {
               var wr = MessageBox.Show("All your stars and coins going to removed!\nAre you accept this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (wr.ToString() == "No")
                {



                }
                else
                {
                    StreamWriter sw = File.CreateText("data\\data.dll");
                    sw.WriteLine(0);
                    sw.WriteLine(0);
                    sw.Close();
                    Application.Restart();
                }
            } 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Güýmenjeler guy = new Güýmenjeler();
            guy.Show();
        }

        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void resultimg_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void pictureBox22_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Quetus fact = new Quetus();
                fact.Show();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                Manyly_sozler manyly = new Manyly_sozler();
                manyly.Show();
            }

        }

        private void factslbl_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Quetus fact = new Quetus();
                fact.Show();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                Manyly_sozler manyly = new Manyly_sozler();
                manyly.Show();
            }
        }

        private void guymenjelerlbl_Click(object sender, EventArgs e)
        {
            Güýmenjeler guy = new Güýmenjeler();
            guy.Show();
        }

        private void playlbl_Click(object sender, EventArgs e)
        {

        }

        private void factslbl_MouseEnter(object sender, EventArgs e)
        {
            factslbl.ForeColor = Color.Lime;
            pictureBox22.Width += 10;
            pictureBox22.Height += 10;
        }

        private void factslbl_MouseLeave(object sender, EventArgs e)
        {
            factslbl.ForeColor = Color.Black;
            pictureBox22.Height -= 10;
            pictureBox22.Width -= 10;
        }

        private void guymenjelerlbl_MouseEnter(object sender, EventArgs e)
        {
            guymenjelerlbl.ForeColor = Color.Lime;
            button4.Width += 10;
            button4.Height += 10;

        }

        private void guymenjelerlbl_MouseLeave(object sender, EventArgs e)
        {
            guymenjelerlbl.ForeColor = Color.Black;
            button4.Height -= 10;
            button4.Width -= 10;
        }

        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.Width += 10;
            pictureBox22.Height += 10;
            factslbl.ForeColor = Color.Lime;
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Height -= 10;
            pictureBox22.Width -= 10;
            factslbl.ForeColor = Color.Black;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Width += 10;
            button4.Height += 10;
            guymenjelerlbl.ForeColor = Color.Lime;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Height -= 10;
            button4.Width -= 10;
            guymenjelerlbl.ForeColor = Color.Black;
        }
    }
}
