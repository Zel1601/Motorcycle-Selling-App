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
    public partial class ChiTietDonHang : Form
    {
        public event EventHandler OrderCancelled;
        public event EventHandler<OrderPaymentEventArgs> OrderPaymentRequested;
        private int orderID;
        private connectdata dbConnection;
        public ChiTietDonHang(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            dbConnection = new connectdata();
        }

        private void ChiTietDonHang_Load(object sender, EventArgs e)

        {
            LoadProductDetails(orderID);
        }

        private void LoadProductDetails(int orderId)
        {
            SqlConnection connection = dbConnection.connect();
            try
            {
                string query = @"SELECT O.ORDER_ID, O.ORDER_NAME, O.ORDER_CUSTOMER, O.ORDER_ADDRESS, O.ORDER_SDT, O.ORDER_QUANTITUM, O.ORDER_DATE, O.ORDER_DATERECEIVE, M.MOTOR_PRICE
                        FROM ORDERS O, MOTORBIKE M
                        WHERE O.ORDER_ID = @orderID";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@orderID", orderId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblMa.Text = "Mã sản phẩm: " + reader["ORDER_ID"].ToString();
                    lblNameSP.Text = "Tên sản phẩm: " + reader["ORDER_NAME"].ToString();
                    lblSoluong.Text = "Số lượng: " + reader["ORDER_QUANTITUM"].ToString();
                    lblGia.Text = "Giá: " + ((decimal)reader["MOTOR_PRICE"]).ToString("N0") + " VNĐ";
                    lblNameNg.Text = "Người đặt: " + reader["ORDER_CUSTOMER"].ToString();
                    lblAddress.Text = "Địa chỉ nhận: " + reader["ORDER_ADDRESS"].ToString();
                    lblDateOr.Text = "Ngày đặt: " + reader["ORDER_DATE"].ToString();
                    lblDateRe.Text = "Ngày nhận: " + reader["ORDER_DATERECEIVE"].ToString();
                    lblphone.Text = "Số điện thoại: " + reader["ORDER_SDT"].ToString();

                    // Tính thành tiền
                    decimal price = Convert.ToDecimal(reader["MOTOR_PRICE"]);
                    int quantity = Convert.ToInt32(reader["ORDER_QUANTITUM"]);
                    decimal totalPrice = price * quantity;
                    lblTongTien.Text = "Thành tiền: " + totalPrice.ToString("N0") + " VNĐ";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            OrderCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            QLDonHang qLDonHang = new QLDonHang();
            qLDonHang.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection connection = dbConnection.connect();
                try
                {
                    string deleteQuery = "DELETE FROM ORDERS WHERE ORDER_ID = @orderID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@orderID", orderID);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đơn hàng đã được hủy thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy đơn hàng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int orderId = orderID;
                int quantity = Convert.ToInt32(lblSoluong.Text.Replace("Số lượng: ", ""));
                string totalText = lblTongTien.Text;
                totalText = new string(totalText.Where(char.IsDigit).ToArray());
                if (decimal.TryParse(totalText, out decimal totalPrice))
                {
                    OrderPaymentRequested?.Invoke(this, new OrderPaymentEventArgs(orderId, quantity, totalPrice));
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể chuyển đổi thành tiền thành số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class OrderPaymentEventArgs : EventArgs
        {
            public int OrderId { get; }
            public int Quantity { get; }
            public decimal TotalPrice { get; }

            public OrderPaymentEventArgs(int orderId, int quantity, decimal totalPrice)
            {
                OrderId = orderId;
                Quantity = quantity;
                TotalPrice = totalPrice;
            }
        }
    }
}