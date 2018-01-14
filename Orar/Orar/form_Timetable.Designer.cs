namespace Orar
{
    partial class form_Timetable
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
            this.rbtn_Professors = new System.Windows.Forms.RadioButton();
            this.rbtn_Groups = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.cbox_Groups = new System.Windows.Forms.ComboBox();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.cbox_Professors = new System.Windows.Forms.ComboBox();
            this.lview_Orar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_Professors
            // 
            this.rbtn_Professors.AutoSize = true;
            this.rbtn_Professors.Location = new System.Drawing.Point(6, 19);
            this.rbtn_Professors.Name = "rbtn_Professors";
            this.rbtn_Professors.Size = new System.Drawing.Size(74, 17);
            this.rbtn_Professors.TabIndex = 0;
            this.rbtn_Professors.TabStop = true;
            this.rbtn_Professors.Text = "Professors";
            this.rbtn_Professors.UseVisualStyleBackColor = true;
            this.rbtn_Professors.CheckedChanged += new System.EventHandler(this.rbtn_Professors_CheckedChanged);
            // 
            // rbtn_Groups
            // 
            this.rbtn_Groups.AutoSize = true;
            this.rbtn_Groups.Location = new System.Drawing.Point(6, 46);
            this.rbtn_Groups.Name = "rbtn_Groups";
            this.rbtn_Groups.Size = new System.Drawing.Size(59, 17);
            this.rbtn_Groups.TabIndex = 1;
            this.rbtn_Groups.TabStop = true;
            this.rbtn_Groups.Text = "Groups";
            this.rbtn_Groups.UseVisualStyleBackColor = true;
            this.rbtn_Groups.CheckedChanged += new System.EventHandler(this.rbtn_Groups_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Group);
            this.groupBox1.Controls.Add(this.cbox_Groups);
            this.groupBox1.Controls.Add(this.lbl_Professor);
            this.groupBox1.Controls.Add(this.cbox_Professors);
            this.groupBox1.Controls.Add(this.rbtn_Professors);
            this.groupBox1.Controls.Add(this.rbtn_Groups);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Timetable";
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Location = new System.Drawing.Point(497, 48);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(44, 13);
            this.lbl_Group.TabIndex = 5;
            this.lbl_Group.Text = "Groups:";
            // 
            // cbox_Groups
            // 
            this.cbox_Groups.FormattingEnabled = true;
            this.cbox_Groups.Location = new System.Drawing.Point(562, 45);
            this.cbox_Groups.Name = "cbox_Groups";
            this.cbox_Groups.Size = new System.Drawing.Size(178, 21);
            this.cbox_Groups.TabIndex = 4;
            this.cbox_Groups.SelectedIndexChanged += new System.EventHandler(this.cbox_Groups_SelectedIndexChanged);
            // 
            // lbl_Professor
            // 
            this.lbl_Professor.AutoSize = true;
            this.lbl_Professor.Location = new System.Drawing.Point(497, 21);
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Size = new System.Drawing.Size(59, 13);
            this.lbl_Professor.TabIndex = 3;
            this.lbl_Professor.Text = "Professors:";
            // 
            // cbox_Professors
            // 
            this.cbox_Professors.FormattingEnabled = true;
            this.cbox_Professors.Location = new System.Drawing.Point(562, 18);
            this.cbox_Professors.Name = "cbox_Professors";
            this.cbox_Professors.Size = new System.Drawing.Size(178, 21);
            this.cbox_Professors.TabIndex = 2;
            this.cbox_Professors.SelectedIndexChanged += new System.EventHandler(this.cbox_Professors_SelectedIndexChanged);
            // 
            // lview_Orar
            // 
            this.lview_Orar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lview_Orar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lview_Orar.FullRowSelect = true;
            this.lview_Orar.GridLines = true;
            this.lview_Orar.Location = new System.Drawing.Point(12, 99);
            this.lview_Orar.Name = "lview_Orar";
            this.lview_Orar.Size = new System.Drawing.Size(746, 119);
            this.lview_Orar.TabIndex = 3;
            this.lview_Orar.UseCompatibleStateImageBehavior = false;
            this.lview_Orar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Module 1";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Module 2";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Module 3";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Module 4";
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Module 5";
            this.columnHeader6.Width = 135;
            // 
            // form_Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 230);
            this.Controls.Add(this.lview_Orar);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_Timetable";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.form_Timetable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_Professors;
        private System.Windows.Forms.RadioButton rbtn_Groups;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Group;
        private System.Windows.Forms.ComboBox cbox_Groups;
        private System.Windows.Forms.Label lbl_Professor;
        private System.Windows.Forms.ComboBox cbox_Professors;
        private System.Windows.Forms.ListView lview_Orar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}