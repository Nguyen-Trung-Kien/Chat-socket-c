using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    class Users
    {
        public int Port { get; set; }
        public string  Username { get; set; }
        public string Ip { get; set; }
        public Users(int port, string username, string ip)
        {
            this.Port = port;
            this.Username = username;
            this.Ip = ip;
        }

        public Users()
        {
            this.Port = 8888;
            this.Username = string.Empty;
            this.Ip = string.Empty;
        }
    }
}
