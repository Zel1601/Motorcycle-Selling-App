using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanTruyen
{
    public partial class DeleteXe : Form
    {
        private connectdata dbConnection;
        public DeleteXe()
        {
            InitializeComponent();
            dbConnection = new connectdata();
            LoadComicList();
        }
        private void LoadComicList()
        {
            SqlConnection connection = dbConnection.connect();
            try
            {
                string query = "SELECT MOTOR_ID, MOTOR_NAME FROM MOTORBIKE";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int motorid = Convert.ToInt32(reader["MOTOR_ID"]);
                    string motorname = reader["MOTOR_NAME"].ToString();
                    cbxDanhsach.Items.Add(new MotorItem(motorid, motorname));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.disconnect();
            }
        }

        private void cbxDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDanhsach.SelectedItem != null)
            {
                MotorItem selectxe = (MotorItem)cbxDanhsach.SelectedItem;
                SqlConnection connection = dbConnection.connect();
                try
                {
                    string query = "SELECT M.MOTOR_ID, M.MOTOR_NAME, M.MOTOR_PRICE, M.MOTOR_QUANTITUM, M.MOTOR_YEAR ,T.THUONGHIEU_NAME  FROM MOTORBIKE M , THUONGHIEU T WHERE MOTOR_ID = @maXe";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@maXe", selectxe.ComicId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblmaxe.Text = "Mã Xe: " + reader["MOTOR_ID"].ToString();
                        lbltenxe.Text = "Tên Xe: " + reader["MOTOR_NAME"].ToString();
                        lblGia.Text = "Giá: " + ((decimal)reader["MOTOR_PRICE"]).ToString("N0") + " VNĐ";
                        lblSoluong.Text = "Số lượng: " + reader["MOTOR_QUANTITUM"].ToString();
                        lblNgay.Text = "Ngày thêm: " + reader["MOTOR_YEAR"].ToString();
                        lblthuonghieu.Text = "Thương hiệu: " + reader["THUONGHIEU_NAME"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.disconnect();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxDanhsach.SelectedItem != null)
            {
                MotorItem selectedComic = (MotorItem)cbxDanhsach.SelectedItem;
                SqlConnection connection = dbConnection.connect();
                try
                {
                    string deleteQuery = "DELETE FROM MOTORBIKE WHERE MOTOR_ID = @maXe";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@maXe", selectedComic.ComicId);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thông tin xe thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxDanhsach.Items.Remove(selectedComic);
                        ClearLabels();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa xe. Có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.disconnect();
                }
            }
        }
        private void ClearLabels()
        {
            lblmaxe.Text = "Mã Xe:";
            lbltenxe.Text = "Tên Xe:";
            lblGia.Text = "Giá:";
            lblSoluong.Text = "Số lượng:";
            lblNgay.Text = "Ngày thêm:";
            lblthuonghieu.Text = "Thương hiệu:";
        }

        private class MotorItem
        {
            public int ComicId { get; }
            public string ComicName { get; }

            public MotorItem(int comicId, string comicName)
            {
                ComicId = comicId;
                ComicName = comicName;
            }

            public override string ToString()
            {
                return ComicName;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
