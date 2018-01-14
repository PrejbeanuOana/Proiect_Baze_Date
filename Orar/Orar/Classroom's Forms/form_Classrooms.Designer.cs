namespace Orar
{
    partial class form_Classrooms
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
            this.components = new System.ComponentModel.Container();
            this.btn_Add = new System.Windows.Forms.Button();
            this.timetableDataSet = new Orar.TimetableDataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Orar.TimetableDataSetTableAdapters.ClassesTableAdapter();
            this.classRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRoomsTableAdapter = new Orar.TimetableDataSetTableAdapters.ClassRoomsTableAdapter();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_DeleteID = new System.Windows.Forms.TextBox();
            this.lview_Classrom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 175);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // timetableDataSet
            // 
            this.timetableDataSet.DataSetName = "TimetableDataSet";
            this.timetableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.timetableDataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // classRoomsBindingSource
            // 
            this.classRoomsBindingSource.DataMember = "ClassRooms";
            this.classRoomsBindingSource.DataSource = this.timetableDataSet;
            // 
            // classRoomsTableAdapter
            // 
            this.classRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(141, 175);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // tbox_DeleteID
            // 
            this.tbox_DeleteID.Location = new System.Drawing.Point(249, 177);
            this.tbox_DeleteID.Name = "tbox_DeleteID";
            this.tbox_DeleteID.Size = new System.Drawing.Size(36, 20);
            this.tbox_DeleteID.TabIndex = 4;
            // 
            // lview_Classrom
            // 
            this.lview_Classrom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lview_Classrom.FullRowSelect = true;
            this.lview_Classrom.GridLines = true;
            this.lview_Classrom.Location = new System.Drawing.Point(12, 12);
            this.lview_Classrom.Name = "lview_Classrom";
            this.lview_Classrom.Size = new System.Drawing.Size(273, 157);
            this.lview_Classrom.TabIndex = 5;
            this.lview_Classrom.UseCompatibleStateImageBehavior = false;
            this.lview_Classrom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 130;
            // 
            // form_Classrooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 214);
            this.Controls.Add(this.lview_Classrom);
            this.Controls.Add(this.tbox_DeleteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Name = "form_Classrooms";
            this.Text = "Classrooms";
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRoomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TimetableDataSet timetableDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private TimetableDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classRoomsBindingSource;
        private TimetableDataSetTableAdapters.ClassRoomsTableAdapter classRoomsTableAdapter;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_DeleteID;
        private System.Windows.Forms.ListView lview_Classrom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}