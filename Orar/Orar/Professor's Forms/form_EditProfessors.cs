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
    public partial class form_EditProfessors : Form
    {
        private int Prof_Id;

        public form_EditProfessors(Professor prof)
        {
            InitializeComponent();
            Load_Data(prof);
            Prof_Id = prof.ID;
        }

        private void Load_Data(Professor prof)
        {
            tbox_Name.Text = prof.Name;
            tbox_Title.Text = prof.Title;
            tbox_Details.Text = prof.Details;
            tbox_Phone.Text = prof.Phone;
            tbox_Mail.Text = prof.Mail;
            tbox_Salary.Text = prof.Salary.ToString();
        }

        private bool Check_Syntax()
        {
            if (string.IsNullOrWhiteSpace(tbox_Name.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Title.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Details.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Phone.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Mail.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Salary.Text))
                return false;
            if (!int.TryParse(tbox_Salary.Text, out int s))
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

            TimetableDataContext context = new TimetableDataContext();

            try
            {
                Professor prof = (from p in context.Professors
                                  where p.ID == Prof_Id
                                  select p).First();

                prof.Name = tbox_Name.Text;
                prof.Title = tbox_Title.Text;
                prof.Details = tbox_Details.Text;
                prof.Phone = tbox_Phone.Text;
                prof.Mail = tbox_Mail.Text;
                prof.Salary = int.Parse(tbox_Salary.Text);

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
