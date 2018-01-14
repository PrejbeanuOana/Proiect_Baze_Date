namespace Orar
{
    partial class form_AddClassroom
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
            this.tbox_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(145, 81);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.btn_Cancel.TabIndex = 41;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(24, 81);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(115, 23);
            this.btn_Accept.TabIndex = 40;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // tbox_Description
            // 
            this.tbox_Description.Location = new System.Drawing.Point(24, 55);
            this.tbox_Description.Name = "tbox_Description";
            this.tbox_Description.Size = new System.Drawing.Size(236, 20);
            this.tbox_Description.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Description:";
            // 
            // tbox_Name
            // 
            this.tbox_Name.Location = new System.Drawing.Point(24, 16);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(236, 20);
            this.tbox_Name.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name:";
            // 
            // form_AddClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.tbox_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.label1);
            this.Name = "form_AddClassroom";
            this.Text = "Add Classroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.TextBox tbox_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.Label label1;
    }
}