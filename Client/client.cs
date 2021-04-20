using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            connect();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
        // ket noi server

        IPEndPoint IP;
        Socket client1;
       


        void connect()
        {
            //login a = new login();
            //string ip = a.ip;
            //int port = Int32.Parse(a.port);
            //string uname = a.uname;
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            client1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try {
                client1.Connect(IP);
            }
            catch {
                MessageBox.Show("Không thể kết nối với server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                    }
            

            Thread listen = new Thread(receive);
            listen.IsBackground = true;
            listen.Start();
        }
        //tat ket noi
        private void btnMessage_Click(object sender, EventArgs e)
        {
            

            
            send();
            addMessage("Me :  "  + txbMessage.Text);

        }
        
        void close()
        {
            client1.Close();
        }
        //gui message
        void send()
        {

            //string aa = loginif.txbuser.Text;
            
            if (txbMessage.Text!= string.Empty)
                client1.Send(Serialize(txbMessage.Text));

        }
        //nhan tin
        void receive()
        {
            try {
                while (true)
                {

                    byte[] data = new byte[1024 * 5000];
                    client1.Receive(data, 0, data.Length, SocketFlags.None);

                    string message = (string)Deserialize(data);
                    addMessage(message);
                }
            }
            catch
            {
                Close();
            }
            
           
            
        }
        void addMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
            txbMessage.Clear();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {

            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
            
        }

        //dong ket noi
        private void client_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
    }
}
