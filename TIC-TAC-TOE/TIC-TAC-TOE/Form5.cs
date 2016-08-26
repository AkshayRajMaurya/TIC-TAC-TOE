using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form5 : Form
    {
        int n =2;
        string x ,y;
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Ipadd.Text;
            y = pnum.Text;
            n = 2;
            Form6 f6 = new Form6(x, y);
            f6.Show();
            this.Hide();
        }
    }
}