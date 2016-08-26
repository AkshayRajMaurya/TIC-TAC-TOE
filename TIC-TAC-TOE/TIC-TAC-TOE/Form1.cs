using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class EntryForm : Form
    {
        int flag;
        public static int lev;
        public EntryForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label8.Show();
            label10.Show();
            label11.Show();
         
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
        }

        private void label8_MouseClick(object sender, MouseEventArgs e)
        {
           // EntryForm_Load();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
           
            label10.Hide();
            label11.Hide();
            label3.Show();
            label4.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/akshay.raj.maurya786");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://plus.google.com/103151558307425606551");
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
           
            Form4 f4 = new Form4(1);
            f4.Show();
            this.Hide();
           
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
           
            Form4 f4 = new Form4(2);
            f4.Show();
            this.Hide();
          

        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
           
            Form4 f4 = new Form4(3);
            f4.Show();
            this.Hide();
            
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {

             Form3 f3 = new Form3();
             f3.Show();
             this.Hide();
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f9 = new Form2();
            f9.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/A_RaJ_M");
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            Form6 f6 = new Form6("127.0.0.1","10");
            f6.Show();
            this.Hide();
        }
    }
}