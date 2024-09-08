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
    public partial class XuatHoaDon : Form
    {
        string productid;
        string productName;
        decimal productPrice;
        int productQuantity;
        decimal sumprice;
        decimal tiendua;
         decimal tienthoi;
        
        public XuatHoaDon(string productid,string productName, decimal productPrice, int productQuantity, decimal sumprice, decimal tiendua, decimal tienthoi)
        {
            InitializeComponent();
            this.productid = productid;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
            this.sumprice = sumprice;
            this.tiendua = tiendua;
            this.tienthoi = tienthoi;
        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
            lblNameSP.Text = "Tên sản phẩm: " + productName;
            lblPrice.Text = "Giá sản phẩm: " + productPrice.ToString("N0") + " VNĐ";
            lblQuantitum.Text = "Số lượng: " + productQuantity.ToString();
            lblsumprice.Text = "Thành tiền: " + sumprice.ToString("N0") + " VNĐ";
            lblTiendua.Text = "Số tiền khách đưa: " + tiendua.ToString("N0") + " VNĐ";
            lblTienthoi.Text = "Số tiền thối lại: " + tienthoi.ToString("N0") + " VNĐ";
        }
    }
}
