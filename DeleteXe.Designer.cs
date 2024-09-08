namespace QLBanTruyen
{
    partial class DeleteXe
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
            this.lblDeleteTitle = new System.Windows.Forms.Label();
            this.cbxDanhsach = new System.Windows.Forms.ComboBox();
            this.lblchon = new System.Windows.Forms.Label();
            this.lblmaxe = new System.Windows.Forms.Label();
            this.lbltenxe = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblthuonghieu = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteTitle
            // 
            this.lblDeleteTitle.AutoSize = true;
            this.lblDeleteTitle.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTitle.Location = new System.Drawing.Point(462, 32);
            this.lblDeleteTitle.Name = "lblDeleteTitle";
            this.lblDeleteTitle.Size = new System.Drawing.Size(134, 42);
            this.lblDeleteTitle.TabIndex = 0;
            this.lblDeleteTitle.Text = "Xóa Xe";
            this.lblDeleteTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxDanhsach
            // 
            this.cbxDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDanhsach.FormattingEnabled = true;
            this.cbxDanhsach.Location = new System.Drawing.Point(401, 102);
            this.cbxDanhsach.Name = "cbxDanhsach";
            this.cbxDanhsach.Size = new System.Drawing.Size(470, 33);
            this.cbxDanhsach.TabIndex = 1;
            this.cbxDanhsach.SelectedIndexChanged += new System.EventHandler(this.cbxDanhsach_SelectedIndexChanged);
            // 
            // lblchon
            // 
            this.lblchon.AutoSize = true;
            this.lblchon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchon.Location = new System.Drawing.Point(260, 112);
            this.lblchon.Name = "lblchon";
            this.lblchon.Size = new System.Drawing.Size(89, 23);
            this.lblchon.TabIndex = 2;
            this.lblchon.Text = "Chọn Xe:";
            // 
            // lblmaxe
            // 
            this.lblmaxe.AutoSize = true;
            this.lblmaxe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxe.Location = new System.Drawing.Point(397, 163);
            this.lblmaxe.Name = "lblmaxe";
            this.lblmaxe.Size = new System.Drawing.Size(73, 23);
            this.lblmaxe.TabIndex = 3;
            this.lblmaxe.Text = "Mã Xe:";
            // 
            // lbltenxe
            // 
            this.lbltenxe.AutoSize = true;
            this.lbltenxe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenxe.Location = new System.Drawing.Point(397, 215);
            this.lbltenxe.Name = "lbltenxe";
            this.lbltenxe.Size = new System.Drawing.Size(77, 23);
            this.lbltenxe.TabIndex = 4;
            this.lbltenxe.Text = "Tên Xe:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(397, 258);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(53, 23);
            this.lblGia.TabIndex = 5;
            this.lblGia.Text = "Giá :";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(397, 298);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(118, 23);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày Thêm :";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(397, 348);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(104, 23);
            this.lblSoluong.TabIndex = 7;
            this.lblSoluong.Text = "Số Lượng :";
            // 
            // lblthuonghieu
            // 
            this.lblthuonghieu.AutoSize = true;
            this.lblthuonghieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthuonghieu.Location = new System.Drawing.Point(397, 391);
            this.lblthuonghieu.Name = "lblthuonghieu";
            this.lblthuonghieu.Size = new System.Drawing.Size(133, 23);
            this.lblthuonghieu.TabIndex = 8;
            this.lblthuonghieu.Text = "Thương Hiệu :";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(469, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 44);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(655, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(283, 486);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 44);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DeleteXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblthuonghieu);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lbltenxe);
            this.Controls.Add(this.lblmaxe);
            this.Controls.Add(this.lblchon);
            this.Controls.Add(this.cbxDanhsach);
            this.Controls.Add(this.lblDeleteTitle);
            this.Name = "DeleteXe";
            this.Text = "Xóa Sản Phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteTitle;
        private System.Windows.Forms.ComboBox cbxDanhsach;
        private System.Windows.Forms.Label lblchon;
        private System.Windows.Forms.Label lblmaxe;
        private System.Windows.Forms.Label lbltenxe;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblthuonghieu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}