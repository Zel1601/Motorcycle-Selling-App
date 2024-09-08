namespace QLBanTruyen
{
    partial class AddXe
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantitum = new System.Windows.Forms.Label();
            this.txtMaTruyen = new System.Windows.Forms.TextBox();
            this.txtTenTruyen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxTacgia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOr = new System.Windows.Forms.DateTimePicker();
            this.btnCreatAu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Red;
            this.lblAdd.Location = new System.Drawing.Point(310, 52);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(161, 42);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Thêm Xe";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(62, 116);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(138, 23);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Mã Sản Phẩm :";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(62, 161);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên Sản Phẩm :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(62, 213);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(133, 23);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Thương Hiệu :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(62, 363);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 23);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Giá :";
            // 
            // lblQuantitum
            // 
            this.lblQuantitum.AutoSize = true;
            this.lblQuantitum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitum.Location = new System.Drawing.Point(62, 414);
            this.lblQuantitum.Name = "lblQuantitum";
            this.lblQuantitum.Size = new System.Drawing.Size(104, 23);
            this.lblQuantitum.TabIndex = 6;
            this.lblQuantitum.Text = "Số Lượng :";
            // 
            // txtMaTruyen
            // 
            this.txtMaTruyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTruyen.Location = new System.Drawing.Point(232, 109);
            this.txtMaTruyen.Name = "txtMaTruyen";
            this.txtMaTruyen.Size = new System.Drawing.Size(477, 30);
            this.txtMaTruyen.TabIndex = 8;
            // 
            // txtTenTruyen
            // 
            this.txtTenTruyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTruyen.Location = new System.Drawing.Point(232, 154);
            this.txtTenTruyen.Name = "txtTenTruyen";
            this.txtTenTruyen.Size = new System.Drawing.Size(477, 30);
            this.txtTenTruyen.TabIndex = 9;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(230, 356);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(477, 30);
            this.txtGia.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(232, 407);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(477, 30);
            this.txtSoLuong.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(555, 513);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 50);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(346, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 50);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Hủy";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxTacgia
            // 
            this.cbxTacgia.DisplayMember = "AUTHOR_NAME";
            this.cbxTacgia.FormattingEnabled = true;
            this.cbxTacgia.Location = new System.Drawing.Point(231, 212);
            this.cbxTacgia.Name = "cbxTacgia";
            this.cbxTacgia.Size = new System.Drawing.Size(478, 24);
            this.cbxTacgia.TabIndex = 17;
            this.cbxTacgia.ValueMember = "AUTHOR_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ngày Tạo :";
            // 
            // dtpOr
            // 
            this.dtpOr.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOr.Location = new System.Drawing.Point(231, 307);
            this.dtpOr.Name = "dtpOr";
            this.dtpOr.Size = new System.Drawing.Size(475, 34);
            this.dtpOr.TabIndex = 20;
            // 
            // btnCreatAu
            // 
            this.btnCreatAu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatAu.Location = new System.Drawing.Point(232, 254);
            this.btnCreatAu.Name = "btnCreatAu";
            this.btnCreatAu.Size = new System.Drawing.Size(175, 35);
            this.btnCreatAu.TabIndex = 21;
            this.btnCreatAu.Text = "Tạo Thương Hiệu";
            this.btnCreatAu.UseVisualStyleBackColor = true;
            this.btnCreatAu.Click += new System.EventHandler(this.btnCreatAu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(134, 513);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 50);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Khu Vực :";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(232, 456);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(477, 30);
            this.txtArea.TabIndex = 25;
            // 
            // AddXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 670);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreatAu);
            this.Controls.Add(this.dtpOr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTacgia);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenTruyen);
            this.Controls.Add(this.txtMaTruyen);
            this.Controls.Add(this.lblQuantitum);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddXe";
            this.Text = "Thêm Xe";
            this.Load += new System.EventHandler(this.AddTruyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantitum;
        private System.Windows.Forms.TextBox txtMaTruyen;
        private System.Windows.Forms.TextBox txtTenTruyen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbxTacgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOr;
        private System.Windows.Forms.Button btnCreatAu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArea;
    }
}