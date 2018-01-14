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
    public partial class form_AddUser : Form
    {
        public form_AddUser()
        {
            InitializeComponent();
        }

        private bool Check_Syntax()
        {
            if (string.IsNullOrWhiteSpace(tbox_Username.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Password.Text))
                return false;
            if (string.IsNullOrWhiteSpace(tbox_Rpassword.Text))
                return false;
            if (tbox_Password.Text != tbox_Rpassword.Text)
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

                int count = (from u in context.Users
                             where u.Username == tbox_Username.Text
                             select u).Count();
                if (count == 1)
                {
                    MessageBox.Show("User already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int Id = 1;
                if (context.Users.Count() != 0)
                    Id = context.Users.Max(p => p.ID) + 1;

                User usr = new User();
                usr.ID = Id;
                usr.Username = tbox_Username.Text;
                usr.PasswordHash = GenerateSHA256Hash(tbox_Password.Text);

                context.Users.InsertOnSubmit(usr);
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

        private static String ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        private String GenerateSHA256Hash(String input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.SHA256Managed sha256hashstring =
                new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }
    }
}
