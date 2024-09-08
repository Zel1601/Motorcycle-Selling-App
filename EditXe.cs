using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanTruyen
{
    public partial class EditXe : Form
    {
        private connectdata dbConnection;
        private Xe selectedXe;
        public class Xe
        {
            public int Id { get; set; }
            public string TenXe { get; set; }
            public decimal Gia { get; set; }
            public int SoLuong { get; set; }

            public Xe()
            {
                // Hàm khởi tạo mặc định
            }

            public Xe(int id, string tenXe, decimal gia, int soLuong)
            {
                Id = id;
                TenXe = tenXe;
                Gia = gia;
                SoLuong = soLuong;
            }

            public override string ToString()
            {
                return TenXe; // Hiển thị tên truyện trong ComboBox
            }
        }

        public EditXe()
        {
            InitializeComponent();
            dbConnection = new connectdata();
            selectedXe = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedXe != null)
            {
                using (SqlConnection connection = dbConnection.connect())
                {
                    try
                    {
                        string query = "UPDATE MOTORBIKE SET MOTOR_NAME = @tenXe, MOTOR_PRICE = @gia, MOTOR_QUANTITUM = @soLuong WHERE MOTOR_ID = @XeId";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@XeId", selectedXe.Id);
                        cmd.Parameters.AddWithValue("@tenXe", txtName.Text);
                        decimal gia;
                        if (decimal.TryParse(txtGia.Text, out gia))
                        {
                            cmd.Parameters.AddWithValue("@gia", gia);
                        }
                        else
                        {
                            MessageBox.Show("Giá không hợp lệ. Vui lòng nhập một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Kết thúc hàm để không thực hiện lệnh SQL nếu giá không hợp lệ.
                        }

                        int soLuong;
                        if (int.TryParse(txtSoluong.Text, out soLuong))
                        {
                            cmd.Parameters.AddWithValue("@soLuong", soLuong);
                        }
                        else
                        {
                            MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Kết thúc hàm để không thực hiện lệnh SQL nếu số lượng không hợp lệ.
                        }
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin xe thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật thông tin xe. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbxDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDanhSach.SelectedItem != null)
            {
                selectedXe = (Xe)cbxDanhSach.SelectedItem;

                // Thực hiện truy vấn SQL để lấy thông tin chi tiết về truyện
                SqlConnection connection = dbConnection.connect();
                try
                {
                    string query = "SELECT M.MOTOR_ID, M.MOTOR_NAME, M.MOTOR_PRICE, M.MOTOR_QUANTITUM, T.THUONGHIEU_NAME  FROM MOTORBIKE M , THUONGHIEU T WHERE MOTOR_ID = @maXe";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@maXe", selectedXe.Id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtMa.Text = selectedXe.Id.ToString();
                        txtName.Text = reader["MOTOR_NAME"].ToString();
                        txtGia.Text = ((decimal)reader["MOTOR_PRICE"]).ToString("N0") + " VNĐ";
                        txtSoluong.Text = reader["MOTOR_QUANTITUM"].ToString();
                        txtbrand.Text = reader["THUONGHIEU_NAME"].ToString();
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

        private void EditComic_Load(object sender, EventArgs e)
        {
            LoadDanhSachTruyen();
        }

        private void LoadDanhSachTruyen()
        {
            cbxDanhSach.Items.Clear();

            using (SqlConnection connection = dbConnection.connect())
            {
                try
                {
                    string query = "SELECT MOTOR_ID, MOTOR_NAME FROM MOTORBIKE";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int truyenId = reader.GetInt32(0);
                        string tenTruyen = reader.GetString(1);
                        Xe truyen = new Xe { Id = truyenId, TenXe = tenTruyen };
                        cbxDanhSach.Items.Add(truyen);
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
