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
    public partial class DanhMucSanPham : Form
    {
        public DanhMucSanPham()
        {
            InitializeComponent();
        }

        private void layDuLieu()
        {
            connectdata cd = new connectdata();
            SqlConnection bantruyen = cd.connect();

            string query = @"SELECT M.MOTOR_ID AS'MÃ XE', M.MOTOR_NAME AS 'TÊN XE', 
                           T.THUONGHIEU_NAME  AS'HÃNG XE', 
                           FORMAT(M.MOTOR_PRICE, 'C0', 'vi-VN') AS 'GIÁ', M.MOTOR_QUANTITUM AS'SỐ LƯỢNG',
                            M.MOTOR_YEAR AS'NGÀY THÊM',
                            M.MOTOR_AREA AS'KHU VỰC'
                    FROM MOTORBIKE M
                    LEFT JOIN THUONGHIEU T ON T.THUONGHIEU_ID = M.THUONGHIEU_ID";

            using (SqlCommand cmd = new SqlCommand(query, bantruyen))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvDanhMuc.DataSource = dataTable;
            }

            cd.disconnect();
        }

        private void DanhMucSanPham_Load(object sender, EventArgs e)
        {
            layDuLieu();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }
    }
}
