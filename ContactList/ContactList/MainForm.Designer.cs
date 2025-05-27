namespace ContactList
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddContact;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(280, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách liên hệ";
            // 
            // btnAddContact
            // 
            this.btnAddContact.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddContact.Location = new System.Drawing.Point(320, 150);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(160, 40);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Thêm liên hệ";
            this.btnAddContact.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Danh sách liên hệ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);

        }
    }
}
