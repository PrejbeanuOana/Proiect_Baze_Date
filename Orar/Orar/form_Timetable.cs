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
    public partial class form_Timetable : Form
    {
        private List<GroupTimetable> orarFinalGrupe;
        private List<ProfessorTimetable> orarFinalProfessori;

        public form_Timetable(object lst_g, object lst_p)
        {
            InitializeComponent();
            orarFinalGrupe = lst_g as List<GroupTimetable>;
            orarFinalProfessori = lst_p as List<ProfessorTimetable>;
        }

        private void form_Timetable_Load(object sender, EventArgs e)
        {
            rbtn_Professors.Checked = true;
            lbl_Group.Enabled = false;
            cbox_Groups.Enabled = false;

            TimetableDataContext context = new TimetableDataContext();
            IEnumerable<Group> groups = from g in context.Groups
                                        select g;
            IEnumerable<Professor> professors = from p in context.Professors
                                                select p;

            foreach (var item in groups)
            {
                cbox_Groups.Items.Add(item.Description);
            }
            foreach (var item in professors)
            {
                cbox_Professors.Items.Add(item.Name);
            }
        }

        private void rbtn_Professors_CheckedChanged(object sender, EventArgs e)
        {
            lview_Orar.Items.Clear();
            lbl_Professor.Enabled = true;
            cbox_Professors.Enabled = true;
            lbl_Group.Enabled = false;
            cbox_Groups.Enabled = false;
            cbox_Groups.SelectedIndex = -1;
        }

        private void rbtn_Groups_CheckedChanged(object sender, EventArgs e)
        {
            lview_Orar.Items.Clear();
            lbl_Professor.Enabled = false;
            cbox_Professors.Enabled = false;
            lbl_Group.Enabled = true;
            cbox_Groups.Enabled = true;
            cbox_Professors.SelectedIndex = -1;
        }

        private void cbox_Professors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_Professors.SelectedIndex == -1)
                return;

            lview_Orar.Items.Clear();


            ProfessorTimetable pt = new ProfessorTimetable();
            foreach (var item in orarFinalProfessori)
            {
                if (item.NumeProfesor == cbox_Professors.Text)
                {
                    pt = item;
                    break;
                }
            }

            string[] rowLuni = { "Luni", "", "", "", "", "" };
            string[] rowMarti = { "Marti", "", "", "", "", "" };
            string[] rowMiercuri = { "Miercuri", "", "", "", "", "" };
            string[] rowJoi = { "Joi", "", "", "", "", "" };
            string[] rowVineri = { "Vineri", "", "", "", "", "" };

            List<ListViewItem> items = new List<ListViewItem>();
            for (int i = 0; i < pt.Zi.Count(); i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(pt.OraCurs[i][0]);
                sb.Append(pt.OraCurs[i][1]);

                if (pt.Zi[i] == "luni")
                {
                    rowLuni[pt.Modul[i] + 1] = sb.ToString() + ". : " + pt.Clasa[i] + " : " + pt.Grupa[i];
                }
                else if (pt.Zi[i] == "marti")
                {
                    rowMarti[pt.Modul[i] + 1] = sb.ToString() + ". : " + pt.Clasa[i] + " : " + pt.Grupa[i];
                }
                else if (pt.Zi[i] == "miercuri")
                {
                    rowMiercuri[pt.Modul[i] + 1] = sb.ToString() + ". : " + pt.Clasa[i] + " : " + pt.Grupa[i];
                }
                else if (pt.Zi[i] == "joi")
                {
                    rowJoi[pt.Modul[i] + 1] = sb.ToString() + ". : " + pt.Clasa[i] + " : " + pt.Grupa[i];
                }
                else if (pt.Zi[i] == "vineri")
                {
                    rowVineri[pt.Modul[i] + 1] = sb.ToString() + ". : " + pt.Clasa[i] + " : " + pt.Grupa[i];
                }
            }

            items.Add(new ListViewItem(rowLuni));
            items.Add(new ListViewItem(rowMarti));
            items.Add(new ListViewItem(rowMiercuri));
            items.Add(new ListViewItem(rowJoi));
            items.Add(new ListViewItem(rowVineri));

            foreach (var item in items)
            {
                lview_Orar.Items.Add(item);
            }
        }

        private void cbox_Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_Groups.SelectedIndex == -1)
                return;

            lview_Orar.Items.Clear();


            GroupTimetable gt = new GroupTimetable();
            foreach (var item in orarFinalGrupe)
            {
                if (item.NumeGrupa == cbox_Groups.Text)
                {
                    gt = item;
                    break;
                }
            }

            string[] rowLuni = { "Luni", "", "", "", "", "" };
            string[] rowMarti = { "Marti", "", "", "", "", "" };
            string[] rowMiercuri = { "Miercuri", "", "", "", "", "" };
            string[] rowJoi = { "Joi", "", "", "", "", "" };
            string[] rowVineri = { "Vineri", "", "", "", "", "" };

            List<ListViewItem> items = new List<ListViewItem>();
            for (int i = 0; i < gt.Zi.Count(); i++)
            {
                if (gt.Zi[i] == "luni")
                {
                    rowLuni[gt.Modul[i] + 1] = gt.OraCurs[i] + " : " + gt.Clasa[i];
                }
                else if (gt.Zi[i] == "marti")
                {
                    rowMarti[gt.Modul[i] + 1] = gt.OraCurs[i] + " : " + gt.Clasa[i];
                }
                else if (gt.Zi[i] == "miercuri")
                {
                    rowMiercuri[gt.Modul[i] + 1] = gt.OraCurs[i] + " : " + gt.Clasa[i];
                }
                else if (gt.Zi[i] == "joi")
                {
                    rowJoi[gt.Modul[i] + 1] = gt.OraCurs[i] + " : " + gt.Clasa[i];
                }
                else if (gt.Zi[i] == "vineri")
                {
                    rowVineri[gt.Modul[i] + 1] = gt.OraCurs[i] + " : " + gt.Clasa[i];
                }
            }

            items.Add(new ListViewItem(rowLuni));
            items.Add(new ListViewItem(rowMarti));
            items.Add(new ListViewItem(rowMiercuri));
            items.Add(new ListViewItem(rowJoi));
            items.Add(new ListViewItem(rowVineri));

            foreach (var item in items)
            {
                lview_Orar.Items.Add(item);
            }
        }
    }
}
