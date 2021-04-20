using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class login : Form
    {
        public string ip;
        public string port;
        public string uname;
        public login()
        {
            InitializeComponent();

        }
        private bool checktrue(string s)
        {

            if (s.Trim() == "")
                return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsNumber(s[i]))
                {
                    
                    return false;
                }
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txbIP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập vào Ip!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbPort.Text == string.Empty || checktrue(txbPort.Text)==false){
                MessageBox.Show("Vui lòng nhập vào Port hoặc nhập chưa đúng kiểu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbuser.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập username", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if (txbIP.Text != string.Empty && txbPort.Text != string.Empty && txbuser.Text != string.Empty)
            {
                
                client frmclient = new client();
                this.Hide();
                frmclient.Show();

            }
            else
            {
                MessageBox.Show("text", "xin 10 điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }
    }
}
