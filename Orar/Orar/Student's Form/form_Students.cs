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
    public partial class form_Students : Form
    {
        public form_Students()
        {
            InitializeComponent();
            LoadStudents();
        }

        public void LoadStudents()
        {
            TimetableDataContext context = new TimetableDataContext();

            IEnumerable<Student> stud = from c in context.Students
                                        select c;

            foreach (var s in stud)
            {
                string[] row = { s.ID.ToString(), s.Name, s.Group.Description, s.Mail, s.Phone };
                ListViewItem item = new ListViewItem(row);
                lview_Students.Items.Add(item);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                form_AddStudents faddstd = new form_AddStudents();
                faddstd.ShowDialog();

                lview_Students.Items.Clear();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(tbox_DeleteID.Text) || !int.TryParse(tbox_DeleteID.Text, out id))
            {
                MessageBox.Show("Enter valid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TimetableDataContext context = new TimetableDataContext();
                Student std = (from p in context.Students
                               where p.ID == id
                               select p).First();

                context.Students.DeleteOnSubmit(std);
                context.SubmitChanges();

                lview_Students.Items.Clear();
                LoadStudents();
                tbox_DeleteID.Text = "";
            }
            catch
            {
                MessageBox.Show("Enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
