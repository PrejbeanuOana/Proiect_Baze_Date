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
    public partial class form_AddClassroom : Form
    {
        public form_AddClassroom()
        {
            InitializeComponent();
        }

        private bool Check_Syntax()
        {
            if (string.IsNullOrWhiteSpace(tbox_Name.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Description.Text))
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

                int Id = 1;
                if (context.ClassRooms.Count() != 0)
                    Id = context.ClassRooms.Max(p => p.ID) + 1;

                ClassRoom cls = new ClassRoom();
                cls.ID = Id;
                cls.Name = tbox_Name.Text;
                cls.Description = tbox_Description.Text;

                context.ClassRooms.InsertOnSubmit(cls);
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
