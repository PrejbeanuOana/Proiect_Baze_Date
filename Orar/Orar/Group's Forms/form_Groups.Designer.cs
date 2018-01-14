namespace Orar
{
    partial class form_Groups
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
            this.lview_Gruops = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_viewStudents = new System.Windows.Forms.Button();
            this.btn_viewClasses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_stdID = new System.Windows.Forms.TextBox();
            this.tbox_clsID = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lview_Gruops
            // 
            this.lview_Gruops.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lview_Gruops.FullRowSelect = true;
            this.lview_Gruops.GridLines = true;
            this.lview_Gruops.Location = new System.Drawing.Point(12, 12);
            this.lview_Gruops.Name = "lview_Gruops";
            this.lview_Gruops.Size = new System.Drawing.Size(391, 154);
            this.lview_Gruops.TabIndex = 0;
            this.lview_Gruops.UseCompatibleStateImageBehavior = false;
            this.lview_Gruops.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Faculty";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Guide Professor";
            this.columnHeader5.Width = 150;
            // 
            // btn_viewStudents
            // 
            this.btn_viewStudents.Location = new System.Drawing.Point(12, 172);
            this.btn_viewStudents.Name = "btn_viewStudents";
            this.btn_viewStudents.Size = new System.Drawing.Size(148, 23);
            this.btn_viewStudents.TabIndex = 1;
            this.btn_viewStudents.Text = "View Group\'s Students";
            this.btn_viewStudents.UseVisualStyleBackColor = true;
            this.btn_viewStudents.Click += new System.EventHandler(this.btn_viewStudents_Click);
            // 
            // btn_viewClasses
            // 
            this.btn_viewClasses.Location = new System.Drawing.Point(12, 201);
            this.btn_viewClasses.Name = "btn_viewClasses";
            this.btn_viewClasses.Size = new System.Drawing.Size(148, 23);
            this.btn_viewClasses.TabIndex = 2;
            this.btn_viewClasses.Text = "View Group\'s Classes";
            this.btn_viewClasses.UseVisualStyleBackColor = true;
            this.btn_viewClasses.Click += new System.EventHandler(this.btn_viewClasses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // tbox_stdID
            // 
            this.tbox_stdID.Location = new System.Drawing.Point(193, 174);
            this.tbox_stdID.Name = "tbox_stdID";
            this.tbox_stdID.Size = new System.Drawing.Size(39, 20);
            this.tbox_stdID.TabIndex = 5;
            // 
            // tbox_clsID
            // 
            this.tbox_clsID.Location = new System.Drawing.Point(193, 203);
            this.tbox_clsID.Name = "tbox_clsID";
            this.tbox_clsID.Size = new System.Drawing.Size(39, 20);
            this.tbox_clsID.TabIndex = 6;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(328, 172);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 52);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Exit";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // form_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 235);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tbox_clsID);
            this.Controls.Add(this.tbox_stdID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_viewClasses);
            this.Controls.Add(this.btn_viewStudents);
            this.Controls.Add(this.lview_Gruops);
            this.Name = "form_Groups";
            this.Text = "Groups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lview_Gruops;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_viewStudents;
        private System.Windows.Forms.Button btn_viewClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_stdID;
        private System.Windows.Forms.TextBox tbox_clsID;
        private System.Windows.Forms.Button btn_Close;
    }
}