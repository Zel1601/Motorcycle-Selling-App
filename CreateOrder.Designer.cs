namespace QLBanTruyen
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCreateOrder = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblDateOrder = new System.Windows.Forms.Label();
            this.lblDateRe = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.dtpdateOr = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderRe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxsanpham = new System.Windows.Forms.ComboBox();
            this.lblquantitum = new System.Windows.Forms.Label();
            this.txtquantitum = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.grvds = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvds)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // lblCreateOrder
            // 
            this.lblCreateOrder.AutoSize = true;
            this.lblCreateOrder.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateOrder.Location = new System.Drawing.Point(397, 40);
            this.lblCreateOrder.Name = "lblCreateOrder";
            this.lblCreateOrder.Size = new System.Drawing.Size(254, 42);
            this.lblCreateOrder.TabIndex = 1;
            this.lblCreateOrder.Text = "Tạo Đơn Hàng";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(26, 108);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(162, 23);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Tên Khách Hàng :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(26, 164);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(85, 23);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Địa Chỉ :";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(26, 226);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(140, 23);
            this.lblSdt.TabIndex = 5;
            this.lblSdt.Text = "Số Điện Thoại :";
            // 
            // lblDateOrder
            // 
            this.lblDateOrder.AutoSize = true;
            this.lblDateOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOrder.Location = new System.Drawing.Point(26, 292);
            this.lblDateOrder.Name = "lblDateOrder";
            this.lblDateOrder.Size = new System.Drawing.Size(152, 23);
            this.lblDateOrder.TabIndex = 6;
            this.lblDateOrder.Text = "Ngày Đặt Hàng :";
            // 
            // lblDateRe
            // 
            this.lblDateRe.AutoSize = true;
            this.lblDateRe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRe.Location = new System.Drawing.Point(26, 352);
            this.lblDateRe.Name = "lblDateRe";
            this.lblDateRe.Size = new System.Drawing.Size(165, 23);
            this.lblDateRe.TabIndex = 7;
            this.lblDateRe.Text = "Ngày Nhận Hàng :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(199, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(451, 27);
            this.txtName.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(199, 160);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(451, 27);
            this.txtAddress.TabIndex = 10;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(199, 226);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(451, 27);
            this.txtSdt.TabIndex = 11;
            // 
            // dtpdateOr
            // 
            this.dtpdateOr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdateOr.Location = new System.Drawing.Point(199, 286);
            this.dtpdateOr.Name = "dtpdateOr";
            this.dtpdateOr.Size = new System.Drawing.Size(275, 30);
            this.dtpdateOr.TabIndex = 12;
            // 
            // dtpOrderRe
            // 
            this.dtpOrderRe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderRe.Location = new System.Drawing.Point(199, 352);
            this.dtpOrderRe.Name = "dtpOrderRe";
            this.dtpOrderRe.Size = new System.Drawing.Size(275, 30);
            this.dtpOrderRe.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên SP:";
            // 
            // cbxsanpham
            // 
            this.cbxsanpham.FormattingEnabled = true;
            this.cbxsanpham.Location = new System.Drawing.Point(790, 103);
            this.cbxsanpham.Name = "cbxsanpham";
            this.cbxsanpham.Size = new System.Drawing.Size(276, 24);
            this.cbxsanpham.TabIndex = 18;
            // 
            // lblquantitum
            // 
            this.lblquantitum.AutoSize = true;
            this.lblquantitum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantitum.Location = new System.Drawing.Point(682, 160);
            this.lblquantitum.Name = "lblquantitum";
            this.lblquantitum.Size = new System.Drawing.Size(99, 23);
            this.lblquantitum.TabIndex = 20;
            this.lblquantitum.Text = "Số Lượng:";
            // 
            // txtquantitum
            // 
            this.txtquantitum.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantitum.Location = new System.Drawing.Point(790, 160);
            this.txtquantitum.Name = "txtquantitum";
            this.txtquantitum.Size = new System.Drawing.Size(226, 27);
            this.txtquantitum.TabIndex = 21;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Location = new System.Drawing.Point(847, 329);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(127, 62);
            this.btnXuat.TabIndex = 23;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // grvds
            // 
            this.grvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvds.Location = new System.Drawing.Point(45, 430);
            this.grvds.Name = "grvds";
            this.grvds.RowHeadersWidth = 51;
            this.grvds.RowTemplate.Height = 24;
            this.grvds.Size = new System.Drawing.Size(970, 139);
            this.grvds.TabIndex = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(686, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 62);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(524, 329);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 62);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 706);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grvds);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtquantitum);
            this.Controls.Add(this.lblquantitum);
            this.Controls.Add(this.cbxsanpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpOrderRe);
            this.Controls.Add(this.dtpdateOr);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDateRe);
            this.Controls.Add(this.lblDateOrder);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblCreateOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateOrder";
            this.Text = "TaoDonHang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.Label lblCreateOrder;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblDateOrder;
        private System.Windows.Forms.Label lblDateRe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DateTimePicker dtpdateOr;
        private System.Windows.Forms.DateTimePicker dtpOrderRe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxsanpham;
        private System.Windows.Forms.Label lblquantitum;
        private System.Windows.Forms.TextBox txtquantitum;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridView grvds;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}