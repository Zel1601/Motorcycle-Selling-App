using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLBanTruyen
{
    public partial class Detail : Form
    {
        public int maSanPham { get; set; }
        private TimKiem parentForm;

        public Detail(int comicId, TimKiem parent)
        {
            InitializeComponent();
            this.maSanPham = comicId; ;
            this.parentForm = parent;
        }

        private void layDuLieuTuDatabase (int maSanPham)
        {
            connectdata cd = new connectdata();
            SqlConnection bantruyen = cd.connect();

            string query = @"SELECT M.MOTOR_ID, M.MOTOR_NAME, T.THUONGHIEU_NAME, M.MOTOR_PRICE, M.MOTOR_QUANTITUM 
                     FROM MOTORBIKE M
                     INNER JOIN THUONGHIEU T ON T.THUONGHIEU_ID = M.THUONGHIEU_ID
                     WHERE M.MOTOR_ID = @motorId";

            using (SqlCommand cmd = new SqlCommand(query, bantruyen))
            {
                cmd.Parameters.AddWithValue("@motorId", maSanPham);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblId.Text = "Mã sản phẩm: " + reader["MOTOR_ID"].ToString();
                    lblNameSP.Text = "Tên sản phẩm: " + reader["MOTOR_NAME"].ToString();
                    lblAuthor.Text = "Tác giả: " + reader["THUONGHIEU_NAME"].ToString();
                    lblPrice.Text = "Giá: " + ((decimal)reader["MOTOR_PRICE"]).ToString("N0") + " VNĐ";
                    lblQuantitum.Text = "Số lượng :" + reader["MOTOR_QUANTITUM"].ToString();
                }
                reader.Close();
            }
            cd.disconnect();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            if (maSanPham > 0) 
            {
                layDuLieuTuDatabase(maSanPham);
            }
        }
        private void SetProductDetails(int maSanPham, string tenSanPham, string tacGia, decimal gia, int soLuongCon)
        {
            lblId.Text = "Mã sản phẩm: " + maSanPham.ToString();
            lblNameSP.Text = "Tên sản phẩm: " + tenSanPham;
            lblAuthor.Text = "Tác giả: " + tacGia;
            lblPrice.Text = "Giá: " + gia.ToString("N2");
            lblQuantitum.Text = "Số lượng: " + soLuongCon.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
            parentForm.Show();
        }

        private void Detail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); 
            parentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
