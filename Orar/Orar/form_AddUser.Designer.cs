namespace Orar
{
    partial class form_AddUser
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_Rpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(133, 129);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(12, 129);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(115, 23);
            this.btn_Accept.TabIndex = 6;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // tbox_Password
            // 
            this.tbox_Password.Location = new System.Drawing.Point(12, 64);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = '*';
            this.tbox_Password.Size = new System.Drawing.Size(236, 20);
            this.tbox_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tbox_Username
            // 
            this.tbox_Username.Location = new System.Drawing.Point(12, 25);
            this.tbox_Username.Name = "tbox_Username";
            this.tbox_Username.Size = new System.Drawing.Size(236, 20);
            this.tbox_Username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // tbox_Rpassword
            // 
            this.tbox_Rpassword.Location = new System.Drawing.Point(12, 103);
            this.tbox_Rpassword.Name = "tbox_Rpassword";
            this.tbox_Rpassword.PasswordChar = '*';
            this.tbox_Rpassword.Size = new System.Drawing.Size(236, 20);
            this.tbox_Rpassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repeat password:";
            // 
            // form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 165);
            this.Controls.Add(this.tbox_Rpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_Username);
            this.Controls.Add(this.label1);
            this.Name = "form_AddUser";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_Rpassword;
        private System.Windows.Forms.Label label3;
    }
}