namespace Panasonic_PLI_Integration
{
    partial class ConnectionSettings
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
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sendTrigger = new System.Windows.Forms.TextBox();
            this.btn_sendTrigger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(13, 13);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(162, 20);
            this.tb_userName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Server IP Address";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(12, 65);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(162, 20);
            this.tb_address.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 39);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(162, 20);
            this.tb_password.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(13, 145);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(263, 145);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SendTrigger.exe Location";
            // 
            // tb_sendTrigger
            // 
            this.tb_sendTrigger.Location = new System.Drawing.Point(9, 113);
            this.tb_sendTrigger.Name = "tb_sendTrigger";
            this.tb_sendTrigger.Size = new System.Drawing.Size(162, 20);
            this.tb_sendTrigger.TabIndex = 9;
            // 
            // btn_sendTrigger
            // 
            this.btn_sendTrigger.Location = new System.Drawing.Point(177, 111);
            this.btn_sendTrigger.Name = "btn_sendTrigger";
            this.btn_sendTrigger.Size = new System.Drawing.Size(75, 23);
            this.btn_sendTrigger.TabIndex = 10;
            this.btn_sendTrigger.Text = "Browse";
            this.btn_sendTrigger.UseVisualStyleBackColor = true;
            this.btn_sendTrigger.Click += new System.EventHandler(this.btn_sendTrigger_Click);
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 180);
            this.Controls.Add(this.btn_sendTrigger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_sendTrigger);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_userName);
            this.Name = "ConnectionSettings";
            this.Text = "Connection Settings";
            this.Load += new System.EventHandler(this.ConnectionSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sendTrigger;
        private System.Windows.Forms.Button btn_sendTrigger;
    }
}