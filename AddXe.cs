using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanTruyen
{
    public partial class AddXe : Form
    {
        private connectdata dbConnection;

        public AddXe()
        {
            InitializeComponent();
            dbConnection = new connectdata(); 
            LoadComboBoxes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }

        private void AddTruyen_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maTruyen = txtMaTruyen.Text;
            string tenTruyen = txtTenTruyen.Text;
            decimal gia = decimal.Parse(txtGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            DateTime ngayThemTruyen = dtpOr.Value;
            int authorId = Convert.ToInt32(cbxTacgia.SelectedValue);
            string area = txtArea.Text;

            SqlConnection connection = dbConnection.connect();

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO MOTORBIKE (MOTOR_ID, MOTOR_NAME, MOTOR_QUANTITUM, MOTOR_YEAR, MOTOR_PRICE, THUONGHIEU_ID, MOTOR_AREA) VALUES (@maxe, @tenxe, @soluong, @ngay, @gia, @thuonghieu,@area)", connection);
                command.Parameters.AddWithValue("@maxe", maTruyen);
                command.Parameters.AddWithValue("@tenxe", tenTruyen);
                command.Parameters.AddWithValue("@soluong", soLuong);
                command.Parameters.AddWithValue("@ngay", ngayThemTruyen);
                command.Parameters.AddWithValue("@gia", gia);
                command.Parameters.AddWithValue("@thuonghieu", authorId);
                command.Parameters.AddWithValue("@area", area);



                command.ExecuteNonQuery();
                MessageBox.Show("Xe Đã Thêm Thành Công!", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Xe Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.disconnect();
            }
        }
        private void LoadComboBoxes()
        {
            SqlConnection connection = dbConnection.connect();

            string authorQuery = "SELECT THUONGHIEU_ID, THUONGHIEU_NAME FROM THUONGHIEU";
            SqlDataAdapter authorAdapter = new SqlDataAdapter(authorQuery, connection);
            DataTable authorTable = new DataTable();
            authorAdapter.Fill(authorTable);
            cbxTacgia.DataSource = authorTable;
            cbxTacgia.DisplayMember = "THUONGHIEU_NAME"; 
            cbxTacgia.ValueMember = "THUONGHIEU_ID"; 

            connection.Close();
        }

        private void btnCreatAu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddThuongHieu addAu = new AddThuongHieu();
            addAu.Show();
        }

        private void btnCreateCa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}

