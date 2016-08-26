using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form3 : Form
    {
        int[] a = new int[10] { 2,2,2,2,2,2,2,2,2,2};
        int flag = 0, score1 = 0, score2 = 0, tie = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }
        public void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Show();
            if (flag == 0)
            {
                label1.Text = "O";
                flag = 1;
                a[1] = 0;
            }
            else
            {
                label1.Text = "X";
                a[1] = 1;
                flag = 0;
            }
            Check();
        }

        public void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Show();
            if (flag == 0)
            {
                label2.Text = "O";
                flag = 1;
                a[2] = 0;
            }
            else
            {
                label2.Text = "X";
                a[2] = 1;
                flag = 0;
            }
            Check();
        }
        public void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Show();
            if (flag == 0)
            {
                label3.Text = "O";
                flag = 1;
                a[3] = 0;
            }
            else
            {
                label3.Text = "X";
                a[3] = 1;
                flag = 0;
            }
            Check();
        }
        public void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Show();
            if (flag == 0)
            {
                label4.Text = "O";
                flag = 1;
                a[4] = 0;
            }
            else
            {
                label4.Text = "X";
                a[4] = 1;
                flag = 0;
            }
            Check();
        }
        public void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Show();
            if (flag == 0)
            {
                label5.Text = "O";
                flag = 1;
                a[5] = 0;
            }
            else
            {
                label5.Text = "X";
                a[5] = 1;
                flag = 0;
            }
            Check();
        }
        public void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Show();
            if (flag == 0)
            {
                label6.Text = "O";
                flag = 1;
                a[6] = 0;
            }
            else
            {
                label6.Text = "X";
                a[6] = 1;
                flag = 0;
            }
            Check();
        }
        public void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            label7.Show();
            if (flag == 0)
            {
                label7.Text = "O";
                flag = 1;
                a[7] = 0;
            }
            else
            {
                label7.Text = "X";
                a[7] = 1;
                flag = 0;
            }
            Check();
        }
        public void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Show();
            if (flag == 0)
            {
                label8.Text = "O";
                flag = 1;
                a[8] = 0;
            }
            else
            {
                label8.Text = "X";
                a[8] = 1;
                flag = 0;
            }
            Check();
        }
        public void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            label9.Show();
            if (flag == 0)
            {
                label9.Text = "O";
                flag = 1;
                a[9] = 0;
            }
            else
            {
                label9.Text = "X";
                a[9] = 1;
                flag = 0;
            }
            Check();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void Check()
        {
            if(a[1]==a[2]&&a[1]==a[3]&&a[1]==0)
            {
               
                label1.ForeColor=Color.Maroon;
                label2.ForeColor = Color.Maroon;
                label3.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if(a[1]==a[4]&&a[1]==a[7]&&a[1]==0)
            {
               
                label1.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if(a[1]==a[5]&&a[1]==a[9]&&a[1]==0)
            {
               
                label1.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if(a[4]==a[5]&&a[4]==a[6]&&a[4]==0)
            {
               
                label5.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if(a[2]==a[5]&&a[2]==a[8]&&a[2]==0)
            {
               
                label2.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label8.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if(a[3]==a[5]&&a[3]==a[7]&&a[3]==0)
            {
                
                label3.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if(a[7]==a[8]&&a[7]==a[9]&&a[7]==0)
            {
               
                label8.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (a[3] == a[6] && a[3] == a[9] && a[3] == 0)
            { 
               
                label3.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (a[1] == a[2] && a[1] == a[3] && a[1] == 1)
                 {
               
                label1.ForeColor = Color.Maroon;
                label2.ForeColor = Color.Maroon;
                label3.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (a[1] == a[4] && a[1] == a[7] && a[1] == 1)
            {
               
                label1.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if(a[1] == a[5] && a[1] == a[9] && a[1] == 1)
            {
         
                label1.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if(a[4] == a[5] && a[4] == a[6] && a[4] == 1)
            {
               
                label5.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            } 
            if(a[2] == a[5] && a[2] == a[8] && a[2] == 1)
                {
               
                label2.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label8.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if(a[3] == a[5] && a[3] == a[7] && a[3] == 1)
                {
               
                label3.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if(a[7] == a[8] && a[7] == a[9] && a[7] == 1)
                {
               
                label7.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                label8.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if(a[3] == a[6] && a[3] == a[9] && a[3] == 1)
            {
               
                label3.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    Player2 Wins");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            else
            {
                if (a[1] != 2 && a[2] != 2 && a[3] != 2 && a[4] != 2 && a[5] != 2 && a[6] != 2 && a[7] != 2 && a[8] != 2 && a[9] != 2)
                {
                    MessageBox.Show("      DRAW");
                    tie++;
                    label15.Text = tie.ToString();
                    Continue();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntryForm f = new EntryForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            flag = 0;
            for (int i = 1; i <= 9; i++)
            {
                a[i] = 2;
            }
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 0;
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            
            for (int i = 0; i <= 9; i++)
            {
                a[i] = 2;
            }
            score1 = 0;
            score2 = 0;
            tie = 0;
            label13.Text = score1.ToString();
            label14.Text = score2.ToString();
            label15.Text = tie.ToString();
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;

        }
        public void Continue()
        {
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                flag = 0;
                for (int i = 1; i <= 9; i++)
                {
                    a[i] = 2;
                }
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;

            }
        }

        private void label16_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f9 = new Form2();
            f9.Show();
        }
    }
}