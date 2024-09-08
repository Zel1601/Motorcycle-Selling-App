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
using static QLBanTruyen.CreateOrder;

namespace QLBanTruyen
{
    public partial class ThanhToan : Form
    {
        private connectdata dbConnection;
        private decimal totalPrice;
        private int orderId; // Thêm biến orderId

        public ThanhToan(int orderId, int quantity, decimal totalPrice)
        {
            InitializeComponent();
            lblId.Text = "Mã đơn hàng: " + orderId.ToString();
            lblQuantitum.Text = "Số lượng: " + quantity.ToString();
            this.totalPrice = totalPrice;
            lblsumprice.Text = "Tổng tiền: " + totalPrice.ToString("N0") + " VNĐ";
            dbConnection = new connectdata();
            this.orderId = orderId; 
            lblId.Text = "Mã đơn hàng: " + this.orderId.ToString();
        }

            private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPriceRe.Text, out int tiennhap))
            {
                int tienthanhtoan = Convert.ToInt32(totalPrice); 
                int tienthoi = tiennhap - tienthanhtoan;

                lblPriceRee.Text = "Số Tiền Khách Đưa: " + tiennhap.ToString("N0") + " VNĐ";
                lblPriceSe.Text = "Số Tiền Thối Lại: " + tienthoi.ToString("N0") + " VNĐ";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đưa hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = dbConnection.connect();
                string query = @"SELECT O.ORDER_ID, O.ORDER_NAME, O.ORDER_QUANTITUM, M.MOTOR_PRICE 
                     FROM ORDERS O ,MOTORBIKE M
                     WHERE O.ORDER_ID = @orderId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@orderId", this.orderId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string productid = reader["ORDER_ID"].ToString();
                    string productName = reader["ORDER_NAME"].ToString();
                    int productQuantity = Convert.ToInt32(reader["ORDER_QUANTITUM"]);
                    decimal productPrice = Convert.ToDecimal(reader["MOTOR_PRICE"]);

                    int tiennhap = int.Parse(txtPriceRe.Text);
                    int tienthanhtoan = Convert.ToInt32(totalPrice);
                    int tienthoi = tiennhap - tienthanhtoan;

                    XuatHoaDon hoaDonForm = new XuatHoaDon(productid, productName, productPrice, productQuantity, tienthanhtoan, tiennhap, tienthoi);
                    hoaDonForm.ShowDialog();
                    DeleteOrderFromDatabase(this.orderId);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteOrderFromDatabase(int orderId)
        {
            try
            {
                SqlConnection connection = dbConnection.connect();
                string deleteQuery = "DELETE FROM ORDERS WHERE ORDER_ID = @OrderId";

                SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@OrderId", orderId);

                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đơn Hàng Đã Thanh Toán!.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thanh toán đơn hàng!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
