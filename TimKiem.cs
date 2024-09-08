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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();
            LayDuLieu(keyword);
        }

        private void LayDuLieu(string keyword)
        {
            connectdata cd = new connectdata();
            SqlConnection bantruyen = cd.connect();

            string query = @"SELECT M.MOTOR_ID AS 'MÃ SẢN PHẨM',
                                           M.MOTOR_NAME AS 'TÊN SẢN PHẨM', 
                                           T.THUONGHIEU_NAME AS 'HÃNG XE', 
                                           M.MOTOR_PRICE AS 'GIÁ', 
                                           M.MOTOR_QUANTITUM AS 'SỐ LƯỢNG' 
                                            FROM MOTORBIKE M
                                            INNER JOIN THUONGHIEU T ON T.THUONGHIEU_ID = M.THUONGHIEU_ID
                                            WHERE M.MOTOR_NAME LIKE @keyword 
                                               OR T.THUONGHIEU_NAME LIKE @keyword ";
            using (SqlCommand cmd = new SqlCommand(query, bantruyen))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvdanhsach.DataSource = dataTable;
            }
            cd.disconnect();
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            dgvdanhsach.DataSource = null;
            btnFind.Click += btnFind_Click;
            Load += TimKiem_Load;
        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvdanhsach.CellContentDoubleClick += dgvdanhsach_CellContentDoubleClick; ; 
            btnFind.Click += btnFind_Click;
            Load += TimKiem_Load;
        }

        private void dgvdanhsach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvdanhsach.Columns[e.ColumnIndex].Name == "TÊN SẢN PHẨM")
            {
                int comicId = Convert.ToInt32(dgvdanhsach.Rows[e.RowIndex].Cells["MÃ SẢN PHẨM"].Value);

                this.Hide();
                Detail formChiTiet = new Detail(comicId, this);
                formChiTiet.FormClosed += FormChiTiet_FormClosed;
                formChiTiet.ShowDialog();
            }
        }
        private void FormChiTiet_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TrangChu trangchu = new TrangChu();
            trangchu.ShowDialog();
        }
    }
    }
