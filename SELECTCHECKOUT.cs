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
using static QLBanTruyen.CreateOrder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLBanTruyen
{
    public partial class SELECTCHECKOUT : Form
    {
        private connectdata dbConnection;
        public class Order
        {
            public int OrderID { get; set; }
            public string ProductName { get; set; }
            public string CustomerName { get; set; }
            public string DisplayText => $"Mã đơn hàng: {OrderID}, Tên sản phẩm: {ProductName}, Người đặt: {CustomerName}";
        }
        public SELECTCHECKOUT()
        {
            InitializeComponent();
            dbConnection = new connectdata();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cbxOrder.SelectedItem != null)
            {
                Order selectedOrder = (Order)cbxOrder.SelectedItem;
                ChiTietDonHang chiTietDonHangForm = new ChiTietDonHang(selectedOrder.OrderID);
                chiTietDonHangForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng trước khi đến.");
            }
        }

        private void SELECTCHECKOUT_Load(object sender, EventArgs e)
        {
            List<Order> orders = GetOrdersFromDatabase();

            cbxOrder.DisplayMember = "DisplayText";
            cbxOrder.ValueMember = "OrderID"; 
            cbxOrder.DataSource = orders;
        }

        private List<Order> GetOrdersFromDatabase()
        {
            List<Order> ordersList = new List<Order>();

            try
            {
                SqlConnection connection = dbConnection.connect();
                string query = "SELECT ORDER_ID, ORDER_NAME, ORDER_CUSTOMER FROM ORDERS";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order
                    {
                        OrderID = Convert.ToInt32(reader["ORDER_ID"]),
                        ProductName = reader["ORDER_NAME"].ToString(),
                        CustomerName = reader["ORDER_CUSTOMER"].ToString()
                    };

                    ordersList.Add(order);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ordersList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
        }
    } 
    }
