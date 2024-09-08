namespace QLBanTruyen
{
    partial class TimKiem
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
            this.lblNameFind = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameFind
            // 
            this.lblNameFind.AutoSize = true;
            this.lblNameFind.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFind.ForeColor = System.Drawing.Color.Red;
            this.lblNameFind.Location = new System.Drawing.Point(367, 29);
            this.lblNameFind.Name = "lblNameFind";
            this.lblNameFind.Size = new System.Drawing.Size(227, 42);
            this.lblNameFind.TabIndex = 0;
            this.lblNameFind.Text = "Tìm Kiếm Xe";
            this.lblNameFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(175, 133);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(634, 39);
            this.txtKeyword.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(815, 133);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(124, 40);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm Kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(175, 215);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.RowHeadersWidth = 51;
            this.dgvdanhsach.RowTemplate.Height = 24;
            this.dgvdanhsach.Size = new System.Drawing.Size(764, 339);
            this.dgvdanhsach.TabIndex = 3;
            this.dgvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellContentClick);
            this.dgvdanhsach.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellContentDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(971, 514);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 598);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvdanhsach);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblNameFind);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameFind;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.Button btnBack;
    }
}