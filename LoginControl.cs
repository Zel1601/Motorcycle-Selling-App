using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanTruyen
{
    public partial class LoginControl : UserControl
    {
        private const string connectionString = @"server=LAPTOP-Q0JQA1TM;Database=QLBANXEGANMAY;uid=sa;pwd=16012003tai;Integrated security=true";

        public event EventHandler LoginSuccessful;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng. Vui lòng kiểm tra lại.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM CUSTOMER WHERE CUSTOMER_USERNAME = @username AND CUSTOMER_PASSWORD = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    return userCount > 0;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
