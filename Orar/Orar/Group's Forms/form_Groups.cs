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
    public partial class form_Groups : Form
    {
        public form_Groups()
        {
            InitializeComponent();
            LoadGroups();
        }

        public void LoadGroups()
        {
            TimetableDataContext context = new TimetableDataContext();

            IEnumerable<Group> gr = from g in context.Groups
                                    select g;

            foreach (var s in gr)
            {
                string[] row = { s.ID.ToString(), s.Description, s.Faculty, s.Year.ToString(), s.Professor.Name };
                ListViewItem item = new ListViewItem(row);
                lview_Gruops.Items.Add(item);
            }
        }

        private void btn_viewStudents_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(tbox_stdID.Text) || !int.TryParse(tbox_stdID.Text, out id))
            {
                MessageBox.Show("Enter valid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TimetableDataContext context = new TimetableDataContext();
                Group gr = (from g in context.Groups
                            where g.ID == id
                            select g).First();

                form_ViewGroupStudents fvgs = new form_ViewGroupStudents(id);
                fvgs.ShowDialog();

                tbox_stdID.Text = "";
            }
            catch
            {
                MessageBox.Show("Enter a valid Group ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_viewClasses_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(tbox_clsID.Text) || !int.TryParse(tbox_clsID.Text, out id))
            {
                MessageBox.Show("Enter valid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                TimetableDataContext context = new TimetableDataContext();
                Group gr = (from g in context.Groups
                            where g.ID == id
                            select g).First();

                form_ViewGroupClasses fvgc = new form_ViewGroupClasses(id);
                fvgc.ShowDialog();

                tbox_clsID.Text = "";
            }
            catch
            {
                MessageBox.Show("Enter a valid Group ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
