namespace QLBanTruyen
{
    partial class AddThuongHieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblauthorId = new System.Windows.Forms.Label();
            this.txtmaxe = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txttenxe = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Hãng Xe";
            // 
            // lblauthorId
            // 
            this.lblauthorId.AutoSize = true;
            this.lblauthorId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblauthorId.Location = new System.Drawing.Point(12, 106);
            this.lblauthorId.Name = "lblauthorId";
            this.lblauthorId.Size = new System.Drawing.Size(100, 23);
            this.lblauthorId.TabIndex = 1;
            this.lblauthorId.Text = "Mã Hãng :";
            // 
            // txtmaxe
            // 
            this.txtmaxe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaxe.Location = new System.Drawing.Point(158, 99);
            this.txtmaxe.Name = "txtmaxe";
            this.txtmaxe.Size = new System.Drawing.Size(321, 30);
            this.txtmaxe.TabIndex = 2;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(12, 179);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(104, 23);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Tên Hãng :";
            // 
            // txttenxe
            // 
            this.txttenxe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenxe.Location = new System.Drawing.Point(158, 172);
            this.txttenxe.Name = "txttenxe";
            this.txttenxe.Size = new System.Drawing.Size(321, 30);
            this.txttenxe.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(158, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 51);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(158, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Trở Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 462);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txttenxe);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.txtmaxe);
            this.Controls.Add(this.lblauthorId);
            this.Controls.Add(this.label1);
            this.Name = "AddThuongHieu";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblauthorId;
        private System.Windows.Forms.TextBox txtmaxe;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txttenxe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}