namespace QLBanTruyen
{
    partial class QLDonHang
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
            this.lblQLDonHang = new System.Windows.Forms.Label();
            this.grvOrder = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbltt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLDonHang
            // 
            this.lblQLDonHang.AutoSize = true;
            this.lblQLDonHang.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLDonHang.Location = new System.Drawing.Point(408, 25);
            this.lblQLDonHang.Name = "lblQLDonHang";
            this.lblQLDonHang.Size = new System.Drawing.Size(334, 42);
            this.lblQLDonHang.TabIndex = 0;
            this.lblQLDonHang.Text = "Quản Lý Đơn Hàng";
            this.lblQLDonHang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grvOrder
            // 
            this.grvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrder.Location = new System.Drawing.Point(22, 180);
            this.grvOrder.Name = "grvOrder";
            this.grvOrder.RowHeadersWidth = 51;
            this.grvOrder.RowTemplate.Height = 24;
            this.grvOrder.Size = new System.Drawing.Size(1130, 384);
            this.grvOrder.TabIndex = 1;
            this.grvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOrder_CellDoubleClick);
            this.grvOrder.SelectionChanged += new System.EventHandler(this.grvOrder_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1023, 123);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbltt
            // 
            this.lbltt.AutoSize = true;
            this.lbltt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltt.Location = new System.Drawing.Point(439, 123);
            this.lbltt.Name = "lbltt";
            this.lbltt.Size = new System.Drawing.Size(271, 32);
            this.lbltt.TabIndex = 3;
            this.lbltt.Text = "Thông Tin Đơn Hàng";
            // 
            // QLDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 596);
            this.Controls.Add(this.lbltt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grvOrder);
            this.Controls.Add(this.lblQLDonHang);
            this.Name = "QLDonHang";
            this.Text = "QLDonHang";
            this.Load += new System.EventHandler(this.QLDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLDonHang;
        private System.Windows.Forms.DataGridView grvOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbltt;
    }
}