using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanTruyen
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhMucSanPham danhmuc = new DanhMucSanPham();
            danhmuc.Show();           
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimKiem find = new TimKiem();
            find.Show();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateOrder create = new CreateOrder();
            create.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddXe add = new AddXe();
            add.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLDonHang qLDonHang = new QLDonHang();
            qLDonHang.Show();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SELECTCHECKOUT sELECTCHECKOUT = new SELECTCHECKOUT();
            sELECTCHECKOUT.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteXe deleteComic = new DeleteXe();
            deleteComic.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditXe editComic = new EditXe();
            editComic.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
