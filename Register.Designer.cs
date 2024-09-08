namespace QLBanTruyen
{
    partial class Register
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.registerControl1 = new ShopTruyenRegister.RegisterControl();
            this.SuspendLayout();
            // 
            // registerControl1
            // 
            this.registerControl1.Location = new System.Drawing.Point(1, 0);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(891, 697);
            this.registerControl1.TabIndex = 0;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 694);
            this.Controls.Add(this.registerControl1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private ShopTruyenRegister.RegisterControl registerControl1;
    }
}