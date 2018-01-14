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
    public partial class form_ViewGroupStudents : Form
    {
        private int ID_Group;

        public form_ViewGroupStudents(int id)
        {
            InitializeComponent();
            ID_Group = id;
            LoadStudents();
        }

        public void LoadStudents()
        {
            TimetableDataContext context = new TimetableDataContext();

            Group gr = (from g in context.Groups
                        where g.ID == ID_Group
                        select g).First();
            lbl_Group.Text = gr.Description + ":";

            IEnumerable<Student> stud = from c in context.Students
                                        where c.Group_ID == ID_Group
                                        select c;

            foreach (var s in stud)
            {
                string[] row = { s.ID.ToString(), s.Name, s.Group.Description, s.Mail, s.Phone };
                ListViewItem item = new ListViewItem(row);
                lview_Students.Items.Add(item);
            }
        }
    }
}
