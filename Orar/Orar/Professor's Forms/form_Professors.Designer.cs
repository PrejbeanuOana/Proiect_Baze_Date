namespace Orar
{
    partial class form_Professors
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
            this.lview_professors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_EditProf = new System.Windows.Forms.Button();
            this.btn_AddProf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_ID = new System.Windows.Forms.TextBox();
            this.tbox_DeleteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lview_professors
            // 
            this.lview_professors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lview_professors.FullRowSelect = true;
            this.lview_professors.GridLines = true;
            this.lview_professors.Location = new System.Drawing.Point(12, 41);
            this.lview_professors.Name = "lview_professors";
            this.lview_professors.Size = new System.Drawing.Size(689, 221);
            this.lview_professors.TabIndex = 0;
            this.lview_professors.UseCompatibleStateImageBehavior = false;
            this.lview_professors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Details";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Salary";
            // 
            // btn_EditProf
            // 
            this.btn_EditProf.Location = new System.Drawing.Point(12, 12);
            this.btn_EditProf.Name = "btn_EditProf";
            this.btn_EditProf.Size = new System.Drawing.Size(102, 23);
            this.btn_EditProf.TabIndex = 1;
            this.btn_EditProf.Text = "Edit Professor";
            this.btn_EditProf.UseVisualStyleBackColor = true;
            this.btn_EditProf.Click += new System.EventHandler(this.btn_EditProf_Click);
            // 
            // btn_AddProf
            // 
            this.btn_AddProf.Location = new System.Drawing.Point(599, 12);
            this.btn_AddProf.Name = "btn_AddProf";
            this.btn_AddProf.Size = new System.Drawing.Size(102, 23);
            this.btn_AddProf.TabIndex = 2;
            this.btn_AddProf.Text = "Add Professor";
            this.btn_AddProf.UseVisualStyleBackColor = true;
            this.btn_AddProf.Click += new System.EventHandler(this.btn_AddProf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // tbox_ID
            // 
            this.tbox_ID.Location = new System.Drawing.Point(147, 14);
            this.tbox_ID.Name = "tbox_ID";
            this.tbox_ID.Size = new System.Drawing.Size(46, 20);
            this.tbox_ID.TabIndex = 4;
            // 
            // tbox_DeleteID
            // 
            this.tbox_DeleteID.Location = new System.Drawing.Point(437, 14);
            this.tbox_DeleteID.Name = "tbox_DeleteID";
            this.tbox_DeleteID.Size = new System.Drawing.Size(46, 20);
            this.tbox_DeleteID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(302, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete Professor";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // form_Professors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 274);
            this.Controls.Add(this.tbox_DeleteID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tbox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddProf);
            this.Controls.Add(this.btn_EditProf);
            this.Controls.Add(this.lview_professors);
            this.Name = "form_Professors";
            this.Text = "Professors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lview_professors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_EditProf;
        private System.Windows.Forms.Button btn_AddProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_ID;
        private System.Windows.Forms.TextBox tbox_DeleteID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Delete;
    }
}