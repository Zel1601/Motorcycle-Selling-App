using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanTruyen
{
    internal class connectdata
    {
        private SqlConnection bantruyen;
        public SqlConnection connect() //Hàm kết nối
        {
            string truyencuatui = @"server=LAPTOP-Q0JQA1TM;Database=QLBANXEGANMAY;uid=sa;  
                                                    pwd=16012003tai;Integrated security=true";
            bantruyen = new SqlConnection(truyencuatui);
            try
            {
                bantruyen.Open();
            }
            catch (SqlException ex)
            {
                bantruyen.Open(); //Mo ket noi }
                MessageBox.Show("Cannot connect to database! Lỗi: " +
                ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return bantruyen;
        }
        public void disconnect() //Hàm ngắt kết nối
        {
            bantruyen.Close(); //Ngat ket noi
            bantruyen.Dispose(); //Giai phong doi tuong
        }
        }
    }
