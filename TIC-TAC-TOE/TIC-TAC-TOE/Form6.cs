using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TIC_TAC_TOE
{
    public partial class Form6 : Form
    {
        private static Socket client;
        private static byte[] data = new byte[1024];
        IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);
        int[] a = new int[10] { 2,2,2,2,2,2,2,2,2,2};
        int flag = 0, score1 = 0, score2 = 0, tie = 0, win=0;
        string ipadd,pnum;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(string x,string y)
        {
            InitializeComponent();
            ipadd = x;
            pnum = y;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label18.Hide();
            //ipadd = textBox1.Text;
            //pnum = textBox2.Text;
        }
       // try{
        public void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Show();
            if (flag == 0)
            {
                label1.Text = "O";
               // flag = 1;
                a[1] = 0;
            }
            else
            {
                label1.Text = "X";
                a[1] = 1;
                //flag = 0;
            }
            
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label1.Text+"1");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
           // label17.Text = "?";
        }

        public void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Show();
            if (flag == 0)
            {
                label2.Text = "O";
               // flag = 1;
                a[2] = 0;
            }
            else
            {
                label2.Text = "X";
                a[2] = 1;
               // flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label2.Text+"2");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
            //label17.Text = "?";
        }
        public void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Show();
            if (flag == 0)
            {
                label3.Text = "O";
               // flag = 1;
                a[3] = 0;
            }
            else
            {
                label3.Text = "X";
                a[3] = 1;
               // flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label3.Text+"3");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
            //label17.Text = "?";
        }
        public void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Show();
            if (flag == 0)
            {
                label4.Text = "O";
                //flag = 1;
                a[4] = 0;
            }
            else
            {
                label4.Text = "X";
                a[4] = 1;
               // flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label4.Text+"4");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
           // label17.Text = "?";
        }
        public void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Show();
            if (flag == 0)
            {
                label5.Text = "O";
                //flag = 1;
                a[5] = 0;
            }
            else
            {
                label5.Text = "X";
                a[5] = 1;
               // flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label5.Text+"5");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
           // label17.Text = "?";
        }
        public void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Show();
            if (flag == 0)
            {
                label6.Text = "O";
                //flag = 1;
                a[6] = 0;
            }
            else
            {
                label6.Text = "X";
                a[6] = 1;
               // flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label6.Text+"6");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
           // label17.Text = "?";
        }
        public void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            label7.Show();
            if (flag == 0)
            {
                label7.Text = "O";
               // flag = 1;
                a[7] = 0;
            }
            else
            {
                label7.Text = "X";
                a[7] = 1;
              //  flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label7.Text+"7");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
           //label17.Text = "?";
        }
        public void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Show();
            if (flag == 0)
            {
                label8.Text = "O";
                //flag = 1;
                a[8] = 0;
            }
            else
            {
                label8.Text = "X";
                a[8] = 1;
                //flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label8.Text+"8");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
            //label17.Text = "?";
        }
        public void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            label9.Show();
            if (flag == 0)
            {
                label9.Text = "O";
                //flag = 1;
                a[9] = 0;
            }
            else
            {
                label9.Text = "X";
                a[9] = 1;
               // flag = 0;
            }
            Check();
            disable();
            byte[] message = Encoding.ASCII.GetBytes(label9.Text+"9");
            client.BeginSend(message, 0, message.Length, 0,
            new AsyncCallback(SendData), client);
            //label17.Text = "?";
        }
    //}
/*catch(exception ex)
{
   MessageBox.Show("    not connected");
}*/

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            client.Close();
           
        }
        public void Check()
        {
            if(a[1]==a[2]&&a[1]==a[3]&&a[1]==0)
            {
               
                label1.ForeColor=Color.Maroon;
                label2.ForeColor = Color.Maroon;
                label3.ForeColor = Color.Maroon;
                MessageBox.Show("    Player1 Wins");
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
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
                byte[] message = Encoding.ASCII.GetBytes("786");
                client.BeginSend(message, 0, message.Length, 0,
                new AsyncCallback(SendData), client);
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            else
            {
                if (a[1] != 2 && a[2] != 2 && a[3] != 2 && a[4] != 2 && a[5] != 2 && a[6] != 2 && a[7] != 2 && a[8] != 2 && a[9] != 2)
                {
                    MessageBox.Show("      DRAW");
                    byte[] message = Encoding.ASCII.GetBytes("786");
                    client.BeginSend(message, 0, message.Length, 0,
                    new AsyncCallback(SendData), client);
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
                win = 0;
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label18.Hide();
                startserver.Enabled = true;
                connectserver.Enabled = true;
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

        private void startserver_Click(object sender, EventArgs e)
        {
           // Form5 f5 = new Form5();
           // f5.Show();
           // this.Hide();
           
            //startServer();
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                       ProtocolType.Tcp);
            try
            {
                iep = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
                newsock.Bind(iep);
                newsock.Listen(5);
                newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
                label18.Text = "Server Started ...";
                label18.Show();
                startserver.Enabled = false;
                connectserver.Enabled = false;
                flag = 0;
            }
            catch
            {
                MessageBox.Show("Server Error ! Check your IP & port number");
                
            }            
        }

        private void connectserver_Click(object sender, EventArgs e)
        {
           // Form5 f5 = new Form5();
           // f5.Show();
           // this.Hide();
            //connectServer();
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            try
            {
                iep = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
                label18.Text = "Connected ...";
                label18.Show();
                startserver.Enabled = false;
                connectserver.Enabled = false;
                flag = 1;
               // return true;
            }
            catch
            {
                MessageBox.Show("Connection Failed !  Check Your IP & Port number !");
               // return false;
            }

            client.BeginConnect(iep, new AsyncCallback(Connected), client);
            
        }
        void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            client = oldserver.EndAccept(iar);
            
            Thread receiver = new Thread(new ThreadStart(ReceiveData));
            receiver.Start();
        }
        void Connected(IAsyncResult iar)
        {
            try
            {
                client.EndConnect(iar);
               
                Thread receiver = new Thread(new ThreadStart(ReceiveData));
                receiver.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("Error");
            }
        }
        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }
        void ReceiveData()
        {
            int recv = 0;
            string stringData;
            while (true)
            {
                recv = client.Receive(data);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
               // if(stringData.Contains("hello"))
                label17.Text = stringData;
            }
            //return;
        }
        private void startServer()
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            try
            {
                iep = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
                newsock.Bind(iep);
                newsock.Listen(5);
                newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
                //return true;
            }
            catch
            {
                MessageBox.Show("Error starting server!");
                //return false;

            }
            
           
           /* Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            try
            {
                 iep = new IPEndPoint(IPAddress.Parse(ipadd), Convert.ToInt32(pnum));
                 newsock.Bind(iep);
                 newsock.Listen(5);
                 newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
                 MessageBox.Show("hi i am listening");
                 return true;
            }
            catch
            {
                MessageBox.Show("Please  enter a valid address !");
                return false;
            }*/
        }

       // public bool connect

       public bool connectServer()
        {
           /* flag = 1;
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
           ProtocolType.Tcp);
            try
            {
                iep = new IPEndPoint(IPAddress.Parse(ipadd), Convert.ToInt32(pnum));
                
                return true;
            }
            catch
            {
                MessageBox.Show("Error connecting to server!");
                return false;

            }
            client.BeginConnect(iep, new AsyncCallback(Connected), client);*/
            
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp);
            try
            {
                iep = new IPEndPoint(IPAddress.Parse(ipadd), Convert.ToInt32(pnum));
                return true;
            }
            catch
            {
                MessageBox.Show("Please  enter a valid address !");
                return false; 
            }

            client.BeginConnect(iep, new AsyncCallback(Connected), client);
        }

      

       private void panel1_Paint(object sender, PaintEventArgs e)
       {

       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           if(label17.Text.Contains("1"))
           {
               label1.Show();
               if (label17.Text.Contains("O"))
               {
                   label1.Text = "O";
               }
               else
               {
                   label1.Text = "X";
               }
           }
           if (label17.Text.Contains("2"))
           {
               label2.Show();
               if (label17.Text.Contains("O"))
               {
                   label2.Text = "O";
               }
               else
               {
                   label2.Text = "X";
               }
           }
           if (label17.Text.Contains("3"))
           {
               label3.Show();
               if (label17.Text.Contains("O"))
               {
                   label3.Text = "O";
               }
               else
               {
                   label3.Text = "X";
               }
           }
           if (label17.Text.Contains("4"))
           {
               label4.Show();
               if (label17.Text.Contains("O"))
               {
                   label4.Text = "O";
               }
               else
               {
                   label4.Text = "X";
               }
           }
           if (label17.Text.Contains("5"))
           {
               label5.Show();
               if (label17.Text.Contains("O"))
               {
                   label5.Text = "O";
               }
               else
               {
                   label5.Text = "X";
               }
           }
           if (label17.Text.Contains("6"))
           {
               label6.Show();
               if (label17.Text.Contains("O"))
               {
                   label6.Text = "O";
               }
               else
               {
                   label6.Text = "X";
               }
           }
           if (label17.Text.Contains("7"))
           {
               label7.Show();
               if (label17.Text.Contains("O"))
               {
                   label7.Text = "O";
               }
               else
               {
                   label7.Text = "X";
               }
           }
           if (label17.Text.Contains("8"))
           {
               label8.Show();
               if (label17.Text.Contains("O"))
               {
                   label8.Text = "O";
               }
               else
               {
                   label8.Text = "X";
               }
           }
           if (label17.Text.Contains("9"))
           {
               label9.Show();
               if (label17.Text.Contains("O"))
               {
                   label9.Text = "O";
               }
               else
               {
                   label9.Text = "X";
               }
           }
          
           if (win==0)
           {
                if(a[1]==a[2]&&a[1]==a[3]&&a[1]==0)
            {
                win = 1;
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
                win = 1;
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
                win = 1; 
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
                win = 1;
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
                win = 1;
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
                win = 1;
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
                win = 1;
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
                win = 1;
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
                     win = 1;
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
                win = 1;
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
                win = 1;
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
                win = 1;
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
                    win = 1;
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
                    win = 1;
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
                    win = 1;
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
                win = 1;
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
                    win = 1;
                    MessageBox.Show("      DRAW");
                    tie++;
                    label15.Text = tie.ToString();
                    Continue();
                }
            }
            if (label17.Text.Contains("786"))
            {
                Continue(); 
            }
            if (win == 1)
            {
                Continue();
            }
            
              
        }
              
           
         

       }

       private void disable()
       {
           this.panel1.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
           this.panel2.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
           this.panel3.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
           this.panel4.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
           this.panel5.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
           this.panel6.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel6_MouseClick);
           this.panel7.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel7_MouseClick);
           this.panel8.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel8_MouseClick);
           this.panel9.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.panel9_MouseClick);
       }
       private void label17_TextChanged(object sender, EventArgs e)
       {
           this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
           this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
           this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
           this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
           this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
           this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseClick);
           this.panel7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseClick);
           this.panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseClick);
           this.panel9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseClick);
       }

      
    }
}