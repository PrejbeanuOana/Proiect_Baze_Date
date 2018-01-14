namespace Orar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Professors = new System.Windows.Forms.Button();
            this.btn_Classrooms = new System.Windows.Forms.Button();
            this.btn_Students = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_User = new System.Windows.Forms.TextBox();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.gbox_Chooseoption = new System.Windows.Forms.GroupBox();
            this.btn_Timetable = new System.Windows.Forms.Button();
            this.btn_Adduser = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Classes = new System.Windows.Forms.Button();
            this.btn_Groups = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbox_Login = new System.Windows.Forms.GroupBox();
            this.gbox_Chooseoption.SuspendLayout();
            this.gbox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Professors
            // 
            this.btn_Professors.Location = new System.Drawing.Point(6, 19);
            this.btn_Professors.Name = "btn_Professors";
            this.btn_Professors.Size = new System.Drawing.Size(75, 23);
            this.btn_Professors.TabIndex = 0;
            this.btn_Professors.Text = "Professors";
            this.btn_Professors.UseVisualStyleBackColor = true;
            this.btn_Professors.Click += new System.EventHandler(this.btn_Professors_Click);
            // 
            // btn_Classrooms
            // 
            this.btn_Classrooms.Location = new System.Drawing.Point(87, 19);
            this.btn_Classrooms.Name = "btn_Classrooms";
            this.btn_Classrooms.Size = new System.Drawing.Size(75, 23);
            this.btn_Classrooms.TabIndex = 1;
            this.btn_Classrooms.Text = "Classrooms";
            this.btn_Classrooms.UseVisualStyleBackColor = true;
            this.btn_Classrooms.Click += new System.EventHandler(this.btn_Classrooms_Click);
            // 
            // btn_Students
            // 
            this.btn_Students.Location = new System.Drawing.Point(168, 19);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Size = new System.Drawing.Size(75, 23);
            this.btn_Students.TabIndex = 2;
            this.btn_Students.Text = "Students";
            this.btn_Students.UseVisualStyleBackColor = true;
            this.btn_Students.Click += new System.EventHandler(this.btn_Students_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // tbox_User
            // 
            this.tbox_User.Location = new System.Drawing.Point(69, 13);
            this.tbox_User.Name = "tbox_User";
            this.tbox_User.Size = new System.Drawing.Size(180, 20);
            this.tbox_User.TabIndex = 4;
            this.tbox_User.TextChanged += new System.EventHandler(this.tbox_User_TextChanged);
            // 
            // tbox_Password
            // 
            this.tbox_Password.Location = new System.Drawing.Point(69, 39);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = '*';
            this.tbox_Password.Size = new System.Drawing.Size(180, 20);
            this.tbox_Password.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(255, 13);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(73, 46);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // gbox_Chooseoption
            // 
            this.gbox_Chooseoption.Controls.Add(this.btn_Timetable);
            this.gbox_Chooseoption.Controls.Add(this.btn_Adduser);
            this.gbox_Chooseoption.Controls.Add(this.btn_Logout);
            this.gbox_Chooseoption.Controls.Add(this.btn_Classes);
            this.gbox_Chooseoption.Controls.Add(this.btn_Groups);
            this.gbox_Chooseoption.Controls.Add(this.btn_Professors);
            this.gbox_Chooseoption.Controls.Add(this.btn_Classrooms);
            this.gbox_Chooseoption.Controls.Add(this.btn_Students);
            this.gbox_Chooseoption.Enabled = false;
            this.gbox_Chooseoption.Location = new System.Drawing.Point(12, 91);
            this.gbox_Chooseoption.Name = "gbox_Chooseoption";
            this.gbox_Chooseoption.Size = new System.Drawing.Size(331, 81);
            this.gbox_Chooseoption.TabIndex = 8;
            this.gbox_Chooseoption.TabStop = false;
            this.gbox_Chooseoption.Text = "Choose Option";
            // 
            // btn_Timetable
            // 
            this.btn_Timetable.Location = new System.Drawing.Point(87, 52);
            this.btn_Timetable.Name = "btn_Timetable";
            this.btn_Timetable.Size = new System.Drawing.Size(75, 23);
            this.btn_Timetable.TabIndex = 7;
            this.btn_Timetable.Text = "Timetable";
            this.btn_Timetable.UseVisualStyleBackColor = true;
            this.btn_Timetable.Click += new System.EventHandler(this.btn_Timetable_Click);
            // 
            // btn_Adduser
            // 
            this.btn_Adduser.Location = new System.Drawing.Point(168, 52);
            this.btn_Adduser.Name = "btn_Adduser";
            this.btn_Adduser.Size = new System.Drawing.Size(75, 23);
            this.btn_Adduser.TabIndex = 6;
            this.btn_Adduser.Text = "Add User";
            this.btn_Adduser.UseVisualStyleBackColor = true;
            this.btn_Adduser.Click += new System.EventHandler(this.btn_Adduser_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(249, 52);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Classes
            // 
            this.btn_Classes.Location = new System.Drawing.Point(6, 52);
            this.btn_Classes.Name = "btn_Classes";
            this.btn_Classes.Size = new System.Drawing.Size(75, 23);
            this.btn_Classes.TabIndex = 4;
            this.btn_Classes.Text = "Classes";
            this.btn_Classes.UseVisualStyleBackColor = true;
            this.btn_Classes.Click += new System.EventHandler(this.btn_Classes_Click);
            // 
            // btn_Groups
            // 
            this.btn_Groups.Location = new System.Drawing.Point(249, 19);
            this.btn_Groups.Name = "btn_Groups";
            this.btn_Groups.Size = new System.Drawing.Size(75, 23);
            this.btn_Groups.TabIndex = 3;
            this.btn_Groups.Text = "Groups";
            this.btn_Groups.UseVisualStyleBackColor = true;
            this.btn_Groups.Click += new System.EventHandler(this.btn_Groups_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 81);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // gbox_Login
            // 
            this.gbox_Login.Controls.Add(this.label1);
            this.gbox_Login.Controls.Add(this.tbox_User);
            this.gbox_Login.Controls.Add(this.label2);
            this.gbox_Login.Controls.Add(this.btn_Login);
            this.gbox_Login.Controls.Add(this.tbox_Password);
            this.gbox_Login.Location = new System.Drawing.Point(12, 12);
            this.gbox_Login.Name = "gbox_Login";
            this.gbox_Login.Size = new System.Drawing.Size(335, 73);
            this.gbox_Login.TabIndex = 10;
            this.gbox_Login.TabStop = false;
            this.gbox_Login.Text = "Log In";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 284);
            this.Controls.Add(this.gbox_Login);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbox_Chooseoption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Timetable";
            this.gbox_Chooseoption.ResumeLayout(false);
            this.gbox_Login.ResumeLayout(false);
            this.gbox_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Professors;
        private System.Windows.Forms.Button btn_Classrooms;
        private System.Windows.Forms.Button btn_Students;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_User;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.GroupBox gbox_Chooseoption;
        private System.Windows.Forms.Button btn_Groups;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Classes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Adduser;
        private System.Windows.Forms.GroupBox gbox_Login;
        private System.Windows.Forms.Button btn_Timetable;
    }
}

