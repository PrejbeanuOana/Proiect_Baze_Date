using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orar
{
    public partial class form_AddStudents : Form
    {
        public form_AddStudents()
        {
            InitializeComponent();
        }

        private bool Check_Syntax()
        {
            if (string.IsNullOrWhiteSpace(tbox_Name.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_GorupID.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Phone.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Mail.Text))
                return false;
            if (!int.TryParse(tbox_GorupID.Text, out int s))
                return false;

            return true;
        }
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (!Check_Syntax())
            {
                MessageBox.Show("Enter valid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TimetableDataContext context = new TimetableDataContext();

                IEnumerable<Group> grup = from g in context.Groups
                                          where g.ID == int.Parse(tbox_GorupID.Text)
                                          select g;
                if (grup.Count() == 0)
                {
                    MessageBox.Show("This group don't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int Id = 1;
                if (context.Students.Count() != 0)
                    Id = context.Students.Max(p => p.ID) + 1;

                Student std = new Student();
                std.ID = Id;
                std.Name = tbox_Name.Text;
                std.Group_ID = int.Parse(tbox_GorupID.Text);
                std.Phone = tbox_Phone.Text;
                std.Mail = tbox_Mail.Text;

                context.Students.InsertOnSubmit(std);
                context.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
