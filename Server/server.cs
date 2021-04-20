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

namespace Server
{
    public partial class server : Form
    {
        
        public server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            connect();
        }

        private void btnMessageserver_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientlist)
            {
                send(item);
            }
            addMessage("Server:   "+txbMessageserver.Text);
            txbMessageserver.Clear();
        }

        private void server_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
        private void lsvMessage1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        IPEndPoint IP;
        Socket server1;
        List<Socket> clientlist;
        void connect()
        {
            clientlist = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 8888);
            server1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server1.Bind(IP);


            Thread listen = new Thread(() =>

            {
                try
                {
                    while (true)
                    {
                        server1.Listen(100);
                        Socket client = server1.Accept();
                        clientlist.Add(client);

                        Thread receive1 = new Thread(Receive);
                        receive1.IsBackground = true;
                        receive1.Start(client);
                    }

                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8888);
                    server1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                }
            });

            listen.IsBackground = true;
            listen.Start();

        }
        //tat ket noi
        void close()
        {
            server1.Close();
        }
        //gui message
        void send(Socket client)
        {
            if (txbMessageserver.Text != string.Empty && client != null )
                client.Send(Serialize("Server:   "+txbMessageserver.Text));

        }
        //nhan tin
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {

                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data, 0, data.Length, SocketFlags.None);

                    string message = (string)Deserialize(data);
                    addMessage(message);
                    foreach (Socket item in clientlist)
                    {
                        if (item!=null && item != client)
                            item.Send(Serialize("Client:   "+message));
                    }
                    
                }
            }
            catch
            {
                clientlist.Remove(client);
                client.Close();
            }



        }
        void addMessage(string s)
        {
            lsvMessageserver.Items.Add(new ListViewItem() { Text = s });
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
    }
}
