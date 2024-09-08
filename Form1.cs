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
    public partial class Form1 : Form
    {
        private bool loggedIn = false;
        private string strcon = @"server=LAPTOP-Q0JQA1TM;Database=QLBANTRUYEN;uid=sa;  
pwd=16012003tai;Integrated security=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tìmTruyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register formDangKy = new Register();
            DialogResult result = formDangKy.ShowDialog();
            if (result == DialogResult.OK)
            { }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadLoggedInUsersFromDatabase()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                string query = "SELECT CUSTOMER_USERNAME FROM CUSTOMERS"; 
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string username = reader["CUSTOMER_USERNAME"].ToString();
                    lbhienthi.Items.Add(username);
                }

                reader.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLoggedInUsersFromDatabase();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login formDangNhap = new Login();
            this.Hide();
            // Mở form đăng ký dưới dạng form con (modal)
            DialogResult result = formDangNhap.ShowDialog();

            // Kiểm tra kết quả trả về từ form đăng ký (nếu cần)
            if (result == DialogResult.OK)
            {
                loggedIn = true;
                    }
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
