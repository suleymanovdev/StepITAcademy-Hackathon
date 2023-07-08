namespace IUsta
{
    partial class Admin
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tcAdminpanel = new System.Windows.Forms.TabControl();
            this.tpAdminpanel = new System.Windows.Forms.TabPage();
            this.tbInfoorders = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tpInfomasters = new System.Windows.Forms.TabPage();
            this.tpInfocustomers = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tcAdminpanel.SuspendLayout();
            this.tbInfoorders.SuspendLayout();
            this.tpInfomasters.SuspendLayout();
            this.tpInfocustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::IUsta.Properties.Resources.logo_transperent;
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(190, 100);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // tcAdminpanel
            // 
            this.tcAdminpanel.Controls.Add(this.tpAdminpanel);
            this.tcAdminpanel.Controls.Add(this.tbInfoorders);
            this.tcAdminpanel.Controls.Add(this.tpInfomasters);
            this.tcAdminpanel.Controls.Add(this.tpInfocustomers);
            this.tcAdminpanel.Location = new System.Drawing.Point(12, 129);
            this.tcAdminpanel.Name = "tcAdminpanel";
            this.tcAdminpanel.SelectedIndex = 0;
            this.tcAdminpanel.Size = new System.Drawing.Size(1030, 550);
            this.tcAdminpanel.TabIndex = 2;
            // 
            // tpAdminpanel
            // 
            this.tpAdminpanel.Location = new System.Drawing.Point(4, 22);
            this.tpAdminpanel.Name = "tpAdminpanel";
            this.tpAdminpanel.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminpanel.Size = new System.Drawing.Size(1022, 524);
            this.tpAdminpanel.TabIndex = 0;
            this.tpAdminpanel.Text = "Admin Panel";
            this.tpAdminpanel.UseVisualStyleBackColor = true;
            // 
            // tbInfoorders
            // 
            this.tbInfoorders.Controls.Add(this.label2);
            this.tbInfoorders.Controls.Add(this.listBox1);
            this.tbInfoorders.Location = new System.Drawing.Point(4, 22);
            this.tbInfoorders.Name = "tbInfoorders";
            this.tbInfoorders.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfoorders.Size = new System.Drawing.Size(1022, 524);
            this.tbInfoorders.TabIndex = 1;
            this.tbInfoorders.Text = "Info Orders";
            this.tbInfoorders.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(70, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(771, 368);
            this.listBox1.TabIndex = 0;
            // 
            // tpInfomasters
            // 
            this.tpInfomasters.Controls.Add(this.label3);
            this.tpInfomasters.Controls.Add(this.listBox2);
            this.tpInfomasters.Location = new System.Drawing.Point(4, 22);
            this.tpInfomasters.Name = "tpInfomasters";
            this.tpInfomasters.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfomasters.Size = new System.Drawing.Size(1022, 524);
            this.tpInfomasters.TabIndex = 2;
            this.tpInfomasters.Text = "Info Masters";
            this.tpInfomasters.UseVisualStyleBackColor = true;
            // 
            // tpInfocustomers
            // 
            this.tpInfocustomers.Controls.Add(this.listBox3);
            this.tpInfocustomers.Controls.Add(this.label4);
            this.tpInfocustomers.Location = new System.Drawing.Point(4, 22);
            this.tpInfocustomers.Name = "tpInfocustomers";
            this.tpInfocustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfocustomers.Size = new System.Drawing.Size(1022, 524);
            this.tpInfocustomers.TabIndex = 3;
            this.tpInfocustomers.Text = "Info Customers";
            this.tpInfocustomers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(618, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(404, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Orders";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(56, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(890, 433);
            this.listBox2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "All Masters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(447, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "All Customers";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(50, 43);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(892, 433);
            this.listBox3.TabIndex = 4;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcAdminpanel);
            this.Controls.Add(this.pbImage);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tcAdminpanel.ResumeLayout(false);
            this.tbInfoorders.ResumeLayout(false);
            this.tbInfoorders.PerformLayout();
            this.tpInfomasters.ResumeLayout(false);
            this.tpInfomasters.PerformLayout();
            this.tpInfocustomers.ResumeLayout(false);
            this.tpInfocustomers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TabControl tcAdminpanel;
        private System.Windows.Forms.TabPage tpAdminpanel;
        private System.Windows.Forms.TabPage tbInfoorders;
        private System.Windows.Forms.TabPage tpInfomasters;
        private System.Windows.Forms.TabPage tpInfocustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
    }
}