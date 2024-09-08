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
using static QLBanTruyen.ChiTietDonHang;

namespace QLBanTruyen
{
    public partial class QLDonHang : Form
    {
        private connectdata dbConnection;

        public QLDonHang()
        {
            InitializeComponent();
            dbConnection = new connectdata();
        }

        private void QLDonHang_Load(object sender, EventArgs e)
        {
            LoadOrdersData();
        }
        private void LoadOrdersData()
        {
            SqlConnection connection = dbConnection.connect();
            string query = "SELECT * FROM ORDERS";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable ordersTable = new DataTable();
            adapter.Fill(ordersTable);
            grvOrder.DataSource = ordersTable;
            connection.Close();
        }

        private void grvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (grvOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = grvOrder.SelectedRows[0];
                int orderID = Convert.ToInt32(selectedRow.Cells["ORDER_ID"].Value);
            }
        }
        private void grvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = grvOrder.Rows[e.RowIndex];
                int orderID = Convert.ToInt32(selectedRow.Cells["ORDER_ID"].Value);
                OpenChiTietDonHangForm(orderID);
            }
        }
        private void OpenChiTietDonHangForm(int orderID)
        {
            ChiTietDonHang chiTietForm = new ChiTietDonHang(orderID);
            chiTietForm.OrderCancelled += ChiTietForm_OrderCancelled;
            chiTietForm.OrderPaymentRequested += ChiTietForm_OrderPaymentRequested;
            chiTietForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
        }
        private void ChiTietForm_OrderCancelled(object sender, EventArgs e)
        {
            LoadOrdersData();
        }
        private void ChiTietForm_OrderPaymentRequested(object sender, OrderPaymentEventArgs e)
        {
            ThanhToan thanhToanForm = new ThanhToan(e.OrderId, e.Quantity, e.TotalPrice);
            thanhToanForm.ShowDialog();
            LoadOrdersData();
        }

    }
}
