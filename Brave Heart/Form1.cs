using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_Project
{
    public partial class Game : Form
    {
        Label[] arr1 = new Label[10];
        Label[] arr2 = new Label[10];
        List<Tuple<int, string>> scores = new List<Tuple<int, string>>();

       

        public Game()
        {
            InitializeComponent();
            arr1[0] = label1;
            arr1[1] = label2;
            arr1[2] = label3;
            arr1[3] = label4;
            arr1[4] = label5;
            arr1[5] = label6;
            arr1[6] = label7;
            arr1[7] = label8;
            arr1[8] = label9;
            arr1[9] = label10;
            //<<<<<<<<<<<<<<<<<<<<

            arr2[9] = label11;
            arr2[8] = label12;
            arr2[7] = label13;
            arr2[6] = label14;
            arr2[5] = label15;
            arr2[4] = label16;
            arr2[3] = label17;
            arr2[2] = label18;
            arr2[1] = label19;
            arr2[0] = label20;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream("score.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            scores.Sort();
            scores.Reverse();
            
             for(int i=0;i<scores.Count&&i<10;i++)
            {

                sw.WriteLine(scores[i].Item2+','+scores[i].Item1);

            }
            sw.Close();

            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ScoreBoard_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < scores.Count; i++)
            {
                arr1[i].Text = scores[i].Item2;
                arr2[i].Text = scores[i].Item1.ToString();
            }
            Score_Board.Visible = true;
            ManiMenu.Visible = false;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Score_Board.Visible = false;
            ManiMenu.Visible = true;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
         
            panel1.Visible = true;
            ManiMenu.Visible = true;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox35_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("score.txt", FileMode.OpenOrCreate);
            StreamReader rs = new StreamReader(fs);
            int i = 0;
            while (rs.Peek() != -1)
            {
                string line = rs.ReadLine();
                string[] arr = line.Split(',');

                scores.Add(new Tuple<int, string>(int.Parse(arr[1]), arr[0]));
                i++;
            }
            rs.Close();
        }

        private void pictureBox96_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("asfhfh");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
