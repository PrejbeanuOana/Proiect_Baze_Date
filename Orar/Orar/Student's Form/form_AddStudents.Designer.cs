namespace Orar
{
    partial class form_AddStudents
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
            this.tbox_Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_GorupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(134, 168);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.btn_Cancel.TabIndex = 41;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(12, 168);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(115, 23);
            this.btn_Accept.TabIndex = 40;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // tbox_Mail
            // 
            this.tbox_Mail.Location = new System.Drawing.Point(12, 142);
            this.tbox_Mail.Name = "tbox_Mail";
            this.tbox_Mail.Size = new System.Drawing.Size(237, 20);
            this.tbox_Mail.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mail:";
            // 
            // tbox_Phone
            // 
            this.tbox_Phone.Location = new System.Drawing.Point(12, 103);
            this.tbox_Phone.Name = "tbox_Phone";
            this.tbox_Phone.Size = new System.Drawing.Size(237, 20);
            this.tbox_Phone.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Phone:";
            // 
            // tbox_GorupID
            // 
            this.tbox_GorupID.Location = new System.Drawing.Point(12, 64);
            this.tbox_GorupID.Name = "tbox_GorupID";
            this.tbox_GorupID.Size = new System.Drawing.Size(237, 20);
            this.tbox_GorupID.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Group_ID:";
            // 
            // tbox_Name
            // 
            this.tbox_Name.Location = new System.Drawing.Point(12, 25);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(237, 20);
            this.tbox_Name.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name:";
            // 
            // form_AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 207);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.tbox_Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_GorupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.label1);
            this.Name = "form_AddStudents";
            this.Text = "Add Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.TextBox tbox_Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_GorupID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.Label label1;
    }
}