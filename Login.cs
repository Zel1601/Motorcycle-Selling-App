using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanTruyen
{
    public partial class Login : Form
    {
        private bool loggedIn = false;
        public Login()
        {
            InitializeComponent();
            loginControl1.LoginSuccessful += Login_LoginSuccessful;

        }
        private void Login_LoginSuccessful(object sender, EventArgs e)
        {
            loggedIn = true;
            this.Close();
            TrangChu trangChuForm = new TrangChu();
            trangChuForm.Show();
        }
    }
}
