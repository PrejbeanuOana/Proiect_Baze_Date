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
    public partial class form_Professors : Form
    {
        public form_Professors()
        {
            InitializeComponent();
            LoadProfessors();
        }

        public void LoadProfessors()
        {
            TimetableDataContext context = new TimetableDataContext();

            IEnumerable<Professor> professor = from p in context.Professors
                                               select p;

            foreach (var prof in professor)
            {
                string[] row = { prof.ID.ToString(), prof.Name, prof.Title, prof.Details, prof.Phone, prof.Mail, prof.Salary.ToString() };
                ListViewItem item = new ListViewItem(row);
                lview_professors.Items.Add(item);
            }
        }

        private void btn_EditProf_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(tbox_ID.Text) || !int.TryParse(tbox_ID.Text, out id))
            {
                MessageBox.Show("Enter valid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                TimetableDataContext context = new TimetableDataContext();
                Professor professor = (from p in context.Professors
                                       where p.ID == id
                                       select p).First();

                form_EditProfessors feditprof = new form_EditProfessors(professor);
                feditprof.ShowDialog();

                lview_professors.Items.Clear();
                LoadProfessors();
                tbox_ID.Text = "";
            }
            catch
            {
                MessageBox.Show("Enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddProf_Click(object sender, EventArgs e)
        {
            try
            {
                form_AddProfesor faddprof = new form_AddProfesor();
                faddprof.ShowDialog();

                lview_professors.Items.Clear();
                LoadProfessors();
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
                Professor professor = (from p in context.Professors
                                       where p.ID == id
                                       select p).First();

                context.Professors.DeleteOnSubmit(professor);
                context.SubmitChanges();

                lview_professors.Items.Clear();
                LoadProfessors();
                tbox_DeleteID.Text = "";
            }
            catch
            {
                MessageBox.Show("Enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
