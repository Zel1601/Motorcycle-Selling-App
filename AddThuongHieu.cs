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
    public partial class AddThuongHieu : Form
    {
        private connectdata dbConnection;
        public AddThuongHieu()
        {
            InitializeComponent();
            dbConnection = new connectdata();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maxe= txtmaxe.Text;
            string tenxe = txttenxe.Text;

            SqlConnection connection = dbConnection.connect();

            try
            {
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM THUONGHIEU WHERE THUONGHIEU_ID = @Mã", connection);
                checkCommand.Parameters.AddWithValue("@Mã", maxe);
                int authorCount = (int)checkCommand.ExecuteScalar();

                if (authorCount > 0)
                {
                    MessageBox.Show("Mã Hãng Xe đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO THUONGHIEU (THUONGHIEU_ID, THUONGHIEU_NAME) VALUES (@Mã, @Tên)", connection);
                    insertCommand.Parameters.AddWithValue("@Mã", maxe);
                    insertCommand.Parameters.AddWithValue("@Tên", tenxe);

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã Thêm Hãng Xe Thành Công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm Hãng Xe : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.disconnect();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AddXe ad = new AddXe();
            ad.ShowDialog();
        }
    }
}
