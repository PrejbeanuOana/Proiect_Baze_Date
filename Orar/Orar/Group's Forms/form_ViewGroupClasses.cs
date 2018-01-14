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
    public partial class form_ViewGroupClasses : Form
    {
        private int ID_Group;

        public form_ViewGroupClasses(int id)
        {
            InitializeComponent();
            ID_Group = id;
            LoadClasses();
        }

        public void LoadClasses()
        {
            TimetableDataContext context = new TimetableDataContext();

            Group gr = (from g in context.Groups
                        where g.ID == ID_Group
                        select g).First();
            lbl_Group.Text = gr.Description + ":";

            IEnumerable<Attend> att = from a in context.Attends
                                      where a.Group_ID == ID_Group
                                      select a;

            foreach (var s in att)
            {
                string[] row = { s.Class.ID.ToString(), s.Class.Name, s.Class.Professor.Name, s.Class.Credits.ToString() };
                ListViewItem item = new ListViewItem(row);
                lview_Classes.Items.Add(item);
            }
        }
    }
}
