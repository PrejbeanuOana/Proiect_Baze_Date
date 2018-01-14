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
    public partial class form_Classrooms : Form
    {
        public form_Classrooms()
        {
            InitializeComponent();
            LoadClassrooms();
        }

        public void LoadClassrooms()
        {
            TimetableDataContext context = new TimetableDataContext();

            IEnumerable<ClassRoom> classRoom = from c in context.ClassRooms
                                               select c;

            foreach (var cls in classRoom)
            {
                string[] row = { cls.ID.ToString(), cls.Name, cls.Description};
                ListViewItem item = new ListViewItem(row);
                lview_Classrom.Items.Add(item);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                form_AddClassroom faddcls = new form_AddClassroom();
                faddcls.ShowDialog();

                lview_Classrom.Items.Clear();
                LoadClassrooms();
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
                ClassRoom classRoom = (from p in context.ClassRooms
                                       where p.ID == id
                                       select p).First();

                context.ClassRooms.DeleteOnSubmit(classRoom);
                context.SubmitChanges();

                lview_Classrom.Items.Clear();
                LoadClassrooms();
                tbox_DeleteID.Text = "";
            }
            catch
            {
                MessageBox.Show("Enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
