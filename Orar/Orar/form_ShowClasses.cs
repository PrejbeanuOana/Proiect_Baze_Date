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
    public partial class form_ShowClasses : Form
    {
        public form_ShowClasses()
        {
            InitializeComponent();
            LoadClasses();
        }

        public void LoadClasses()
        {
            TimetableDataContext context = new TimetableDataContext();

            IEnumerable<Class> cls = from c in context.Classes
                                      select c;

            foreach (var s in cls)
            {
                string[] row = { s.ID.ToString(), s.Name, s.Professor.Name, s.Credits.ToString()};
                ListViewItem item = new ListViewItem(row);
                lview_Classes.Items.Add(item);
            }
        }
    }
}
