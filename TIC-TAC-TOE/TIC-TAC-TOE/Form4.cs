using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form4 : Form
    {
       
        public Form4(int x)
        {
            InitializeComponent();
            this.diff = x;
           
        }
       
        int[,] arr = new int[3, 3];
        int cnt, val, a, b, c = 1, d = 1, score = 0, tie = 0, cmp=1 , diff;
        char let;
        String pl1 = "Player", pl2 = "Computer";
        Random rnd = new Random();
        bool turn = true;

        void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) { arr[i, j] = 0; }
            }
        
            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label7.Text = "_";
            label8.Text = "_";
            label9.Text = "_";
            label10.Text = "Computer-" ;
            label11.Text = "player-";
            label12.Text = "Ties-";
           

            cnt = 0;
            val = 1;
            let = 'X';
            label16.Text = pl1 + "'s Turn First";
        }

        bool play(int l, int m)
        {
            if (arr[l, m] == 0)
            {
                a = c; b = d; c = l; d = m;
                Label ctrl = link(l, m);
                ctrl.Text = let.ToString();
                arr[l, m] = val;
                change();
                Check(l, m, arr[l, m]);
                return true;
            }
            else
                return false;
        }

        Label link(int l, int m)
        {
            if (l == 0)
            {
                if (m == 0)
                    return label1;
                if (m == 1)
                    return label2;
                if (m == 2)
                    return label3;
            }
            if (l == 1)
            {
                if (m == 0)
                    return label6;
                if (m == 1)
                    return label5;
                if (m == 2)
                    return label4;
            }
            if (l == 2)
            {
                if (m == 0)
                    return label9;
                if (m == 1)
                    return label8;
                if (m == 2)
                    return label7;
            }
            return null;
        }

        void change()
        {
            if (let == 'X')
            {
                let = 'O';
                val = 4;
                cnt++;
            }
            else
            {
                let = 'X';
                val = 1;
                cnt++;
            }
        }

        void Check(int l, int m, int n)
        {
            if (cnt == 1)
                if (cmp == 1)
                    turn = true;
            if (cnt > 4)
            {
                if ((arr[l, 0] + arr[l, 1] + arr[l, 2] == n * 3) || (arr[0, m] + arr[1, m] + arr[2, m] == n * 3))
                {
                    cnt = n;
                }
                else
                {
                    if ((arr[0, 0] + arr[1, 1] + arr[2, 2] == n * 3) || (arr[2, 0] + arr[1, 1] + arr[0, 2] == n * 3))
                    {
                        cnt = n;
                    }
                    else
                    {
                        if (cnt == 9)
                        {
                            cnt = 0;
                        }
                    }
                }
                if (cnt == 1 || cnt == 0)
                {
                    if (cnt == 1)
                    {
                        MessageBox.Show(pl1 + " Wins");
                        score++;
                        if (pl1 == "Computer")
                            label13.Text = score.ToString();
                        else
                            label14.Text = score.ToString();
                    }
                    if (cnt == 0)
                    {
                        MessageBox.Show("      DRAW");
                        tie++;
                        label15.Text = tie.ToString();
                        
                     
                    }
                    reset();
                    if (cmp == 1)
                        if (pl1 == "Computer")
                        {
                            turn = false;
                            compplay(val);
                        }
                        else
                            turn = false;

                }
                else
                    if (cnt == 4)
                    {
                       
                        MessageBox.Show(pl2 + " Wins");
                        score++;
                        if (pl2== "Computer")
                         label13.Text = score.ToString();
                        else
                         label14.Text = score.ToString();
                            
                        String temp = pl1;
                        pl1 = pl2;
                        pl2 = temp;
                        reset();
                        if (cmp == 1)
                            if (pl1 == "Computer")
                                compplay(val);
                            else
                                turn = false;
                    }
            }
        }


        void compplay(int n)
        {
            bool carry = true;
            if (diff == 3)
                carry = winorstop(a, b, n);
            if ((diff == 2 || diff == 3) && carry)
            {
                if (n == 1)
                    carry = winorstop(c, d, 4);
                else
                    carry = winorstop(c, d, 1);
            }
            if (carry)
                doany();
        }

        bool winorstop(int l, int m, int n)
        {
            if (arr[l, 0] + arr[l, 1] + arr[l, 2] == n * 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (play(l, i))
                        return false;
                }
            }
            else
                if (arr[0, m] + arr[1, m] + arr[2, m] == n * 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (play(i, m))
                            return false;
                    }
                }
                else
                    if (arr[0, 0] + arr[1, 1] + arr[2, 2] == n * 2)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (play(i, i))
                                return false;
                        }
                    }
                    else
                        if (arr[2, 0] + arr[1, 1] + arr[0, 2] == n * 2)
                        {
                            for (int i = 0, j = 2; i < 3; i++, j--)
                            {
                                if (play(i, j))
                                    return false;
                            }
                        }

            return true;
        }

        void doany()
        {
            int l = 2, m = 0;
            switch (cnt)
            {
                case 0: play(0, 0);
                    break;
                case 1: if (!(play(1, 1)))
                        play(0, 0);
                    break;
                case 2: if (!(play(2, 2)))
                        play(0, 2);
                    break;
                case 3: if ((arr[0, 1] + arr[1, 1] + arr[2, 1]) == val)
                        play(0, 1);
                    else
                        if ((arr[1, 0] + arr[1, 1] + arr[1, 2]) == val)
                            play(1, 0);
                        else
                            if (arr[0, 1] != 0)
                                play(0, 2);
                            else
                                play(2, 0);

                    break;
                default: while (!(play(l, m)))
                    {
                        l = rnd.Next(3);
                        m = rnd.Next(3);
                    }
                    break;
            }
        }

      
        public void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void label3_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Show();
            if (play(0, 2) && turn == true)
                compplay(val);
            
        }

        public void label2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Show();
            if (play(0, 1) && turn == true)
                compplay(val);
        }

        public void label1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Show();
            if (play(0, 0) && turn == true)
                compplay(val);
        }

        public void label4_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Show();
            if (play(1, 2) && turn == true)
                compplay(val);
        }

        public void label5_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Show();
            if (play(1, 1) && turn == true)
                compplay(val);
        }

        public void label6_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Show();
            if (play(1, 0) && turn == true)
                compplay(val);
        }

        public void label7_MouseClick(object sender, MouseEventArgs e)
        {
            label7.Show();
            if (play(2, 2) && turn == true)
                compplay(val);
        }

        public void label8_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Show();
            if (play(2, 1) && turn == true)
                compplay(val);
        }

        public void label9_MouseClick(object sender, MouseEventArgs e)
        {
            label9.Show();
            if (play(2, 0) && turn == true)
                compplay(val);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntryForm f = new EntryForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String pl1 = "Player", pl2 = "Computer";
            label16.Text = pl1 + "'s Turn First";
            score = 0;
            tie = 0;
            label13.Text = score.ToString();
            label14.Text = score.ToString();
            label15.Text = tie.ToString();
            reset();
           
        }

        private void label17_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f9 = new Form2();
            f9.Show();
        }

       
    }
}