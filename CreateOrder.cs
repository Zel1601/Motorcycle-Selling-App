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
    public partial class CreateOrder : Form
    {
        public class Order
        {
            public int OrderId { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime OrderDateReceive { get; set; }
            public int CustomerId { get; set; }
        }
        private connectdata dbConnection;
        private DataTable dtDonHang;

        public CreateOrder()
        {
            InitializeComponent();
            dbConnection = new connectdata();
            dtDonHang = new DataTable();
            dtDonHang.Columns.Add("TenSanPham");
            dtDonHang.Columns.Add("SoLuongDat");
            dtDonHang.Columns.Add("NgayDat");
            dtDonHang.Columns.Add("NgayNhan");
            grvds.DataSource = dtDonHang;

            LoadSanPhamToComboBox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
        }
        private void LoadSanPhamToComboBox()
        {
            using (SqlConnection connection = dbConnection.connect())
            {
                string query = "SELECT MOTOR_NAME FROM MOTORBIKE";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tenSanPham = reader["MOTOR_NAME"].ToString();
                    cbxsanpham.Items.Add(tenSanPham);
                }

                reader.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenSanPham = cbxsanpham.SelectedItem.ToString();
            int soLuongDat = Convert.ToInt32(txtquantitum.Text); 

            using (SqlConnection connection = dbConnection.connect())
            {
                string queryQuantity = "SELECT MOTOR_QUANTITUM FROM MOTORBIKE WHERE MOTOR_NAME = @SelectedProduct";
                SqlCommand queryQuantityCommand = new SqlCommand(queryQuantity, connection);
                queryQuantityCommand.Parameters.AddWithValue("@SelectedProduct", tenSanPham);
                int soLuongCon = Convert.ToInt32(queryQuantityCommand.ExecuteScalar());

                if (soLuongDat <= soLuongCon)
                {
                    dtDonHang.Rows.Add(tenSanPham, soLuongDat, dtpdateOr.Value.ToShortDateString(), dtpOrderRe.Value.AddDays(15).ToShortDateString());
                    string updateQuantityQuery = "UPDATE MOTORBIKE SET MOTOR_QUANTITUM = MOTOR_QUANTITUM - @OrderQuantity WHERE MOTOR_NAME = @SelectedProduct";
                    SqlCommand updateQuantityCommand = new SqlCommand(updateQuantityQuery, connection);
                    updateQuantityCommand.Parameters.AddWithValue("@OrderQuantity", soLuongDat);
                    updateQuantityCommand.Parameters.AddWithValue("@SelectedProduct", tenSanPham);
                    updateQuantityCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Không đủ số lượng sản phẩm trong kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text;
            string customerAddress = txtAddress.Text;
            string customerPhone = txtSdt.Text;
            DateTime orderDate = dtpdateOr.Value;
            string selectedProduct = cbxsanpham.SelectedItem.ToString();
            int orderQuantity = Convert.ToInt32(txtquantitum.Text); // Số lượng mua
            DateTime receiveDate = orderDate.AddDays(15);

            using (SqlConnection connection = dbConnection.connect())
            {
                string orderInsertQuery = "INSERT INTO ORDERS (ORDER_NAME, ORDER_CUSTOMER, ORDER_ADDRESS, ORDER_SDT, ORDER_QUANTITUM, ORDER_DATE, ORDER_DATERECEIVE, CUSTOMER_ID) " +
                                          "VALUES (@OrderName, @CustomerName, @CustomerAddress, @CustomerPhone, @OrderQuantity, @OrderDate, @ReceiveDate, @CustomerId)";
                SqlCommand orderInsertCommand = new SqlCommand(orderInsertQuery, connection);
                orderInsertCommand.Parameters.AddWithValue("@OrderName", selectedProduct);
                orderInsertCommand.Parameters.AddWithValue("@CustomerName", customerName);
                orderInsertCommand.Parameters.AddWithValue("@CustomerAddress", customerAddress);
                orderInsertCommand.Parameters.AddWithValue("@CustomerPhone", customerPhone);
                orderInsertCommand.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                orderInsertCommand.Parameters.AddWithValue("@OrderDate", orderDate);
                orderInsertCommand.Parameters.AddWithValue("@ReceiveDate", receiveDate);
                orderInsertCommand.Parameters.AddWithValue("@CustomerId", 1);
                orderInsertCommand.ExecuteNonQuery();

                string updateProductQuantityQuery = "UPDATE MOTORBIKE SET MOTOR_QUANTITUM = MOTOR_QUANTITUM - @OrderQuantity WHERE MOTOR_NAME = @SelectedProduct";
                SqlCommand updateProductQuantityCommand = new SqlCommand(updateProductQuantityQuery, connection);
                updateProductQuantityCommand.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                updateProductQuantityCommand.Parameters.AddWithValue("@SelectedProduct", selectedProduct);
                updateProductQuantityCommand.ExecuteNonQuery();
            }

            MessageBox.Show("Đơn hàng đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
        }
    }
}
