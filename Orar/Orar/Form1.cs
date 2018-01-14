#region Using_directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.ProviderBase;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Data.SqlTypes;
using System.Transactions;
#endregion

namespace Orar
{
    public partial class Form1 : Form
    {
        private List<GroupTimetable> orarFinalGrupe = new List<GroupTimetable>();
        private List<ProfessorTimetable> orarFinalProfessori = new List<ProfessorTimetable>();

        public Form1()
        {
            InitializeComponent();
            GenerateTimetable();
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

        private void btn_Professors_Click(object sender, EventArgs e)
        {
            form_Professors fprof = new form_Professors();
            fprof.Show();
        }

        private void btn_Classrooms_Click(object sender, EventArgs e)
        {
            form_Classrooms fclas = new form_Classrooms();
            fclas.Show();
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {
            form_Students fstd = new form_Students();
            fstd.Show();
        }

        private void btn_Adduser_Click(object sender, EventArgs e)
        {
            form_AddUser fadduser = new form_AddUser();
            fadduser.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbox_User.Text) || string.IsNullOrWhiteSpace(tbox_Password.Text))
                {
                    MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimetableDataContext context = new TimetableDataContext();
                User usr = (from u in context.Users
                            where u.Username == tbox_User.Text
                            select u).First();

                if (usr.PasswordHash == GenerateSHA256Hash(tbox_Password.Text))
                {
                    MessageBox.Show("Welcome to timetable app!", "Log in succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbox_User.Text = "";
                    tbox_Password.Text = "";

                    gbox_Login.Enabled = false;
                    gbox_Chooseoption.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            gbox_Login.Enabled = true;
            gbox_Chooseoption.Enabled = false;
        }

        private void btn_Classes_Click(object sender, EventArgs e)
        {
            form_ShowClasses fshowclasses = new form_ShowClasses();
            fshowclasses.Show();
        }

        private void btn_Groups_Click(object sender, EventArgs e)
        {
            form_Groups fgr = new form_Groups();
            fgr.Show();
        }

        private void btn_Timetable_Click(object sender, EventArgs e)
        {
            form_Timetable ftable = new form_Timetable(orarFinalGrupe, orarFinalProfessori);
            ftable.ShowDialog();
        }

        //Creem orarul
        private bool CheckProfessorsSync(string clasa, string zi, int modul, string oraCurs, string grupa, string profName)
        {
            ProfessorTimetable pt = null;
            foreach (var item in orarFinalProfessori)
            {
                if (item.NumeProfesor == profName)
                {
                    pt = item;
                    break;
                }
            }

            bool checkOcupat = false;
            for (int i = 0; i < pt.Zi.Count(); i++)
            {
                if (zi == pt.Zi[i] && modul == pt.Modul[i])
                {
                    checkOcupat = true;
                    break;
                }
            }
            if (checkOcupat == true)
                return true;

            pt.Clasa.Add(clasa);
            pt.Zi.Add(zi);
            pt.Modul.Add(modul);
            pt.OraCurs.Add(oraCurs);
            pt.Grupa.Add(grupa);

            return true;
        }
        private void GenerateInitialStateProfessorsTimetable()
        {
            TimetableDataContext context = new TimetableDataContext();

            IEnumerable<Professor> profs = from p in context.Professors
                                           select p;
            foreach (var prof in profs)
            {
                ProfessorTimetable pt = new ProfessorTimetable();
                pt.NumeProfesor = prof.Name;
                pt.Clasa = new List<string>();
                pt.Zi = new List<string>();
                pt.Modul = new List<int>();
                pt.OraCurs = new List<string>();
                pt.Grupa = new List<string>();

                orarFinalProfessori.Add(pt);
            }
        }
        private void GenerateTimetable()
        {
            //Generam tabela de profesori goala
            GenerateInitialStateProfessorsTimetable();

            TimetableDataContext context = new TimetableDataContext();

            //Initializam toate clasele cu module si sunt toate libere
            List<bool> moduleLibere = new List<bool> { false, false, false, false, false };

            //Lista cu id-uri si zilele saptamanii
            List<int> classRooms_ID = (from c in context.ClassRooms
                                       select c.ID).ToList();
            List<string> zileSaptaman = new List<string> { "luni", "marti", "miercuri", "joi", "vineri" };

            //Dictionar final legaturi clasa->zile_saptamana->Module
            Dictionary<int, Dictionary<string, List<bool>>> classRooms_Zile_Module = new Dictionary<int, Dictionary<string, List<bool>>>();
            foreach (int index in classRooms_ID)
            {
                Dictionary<string, List<bool>> zileSaptaman_Module_temp = new Dictionary<string, List<bool>>();
                zileSaptaman_Module_temp.Add("luni", moduleLibere.ToList());
                zileSaptaman_Module_temp.Add("marti", moduleLibere.ToList());
                zileSaptaman_Module_temp.Add("miercuri", moduleLibere.ToList());
                zileSaptaman_Module_temp.Add("joi", moduleLibere.ToList());
                zileSaptaman_Module_temp.Add("vineri", moduleLibere.ToList());

                classRooms_Zile_Module.Add(index, zileSaptaman_Module_temp);
            }

            //Selectam toate grupele
            IEnumerable<Group> grupeStudenti = from g in context.Groups
                                               select g;

            Random rnd = new Random();
            //Parchurgem fiecare grupa
            foreach (Group grupa in grupeStudenti)
            {
                //Selectam orele de curs
                IEnumerable<Attend> oreCurs = from a in context.Attends
                                              where a.Group_ID == grupa.ID
                                              select a;

                GroupTimetable gt = new GroupTimetable();
                gt.NumeGrupa = grupa.Description;
                gt.Clasa = new List<string>();
                gt.Zi = new List<string>();
                gt.Modul = new List<int>();
                gt.OraCurs = new List<string>();

                //Parcurgem fiecare ora de Curs de 2 ori!
                for (int i = 0; i < 2; i++)
                {
                    foreach (var oraCurs in oreCurs)
                    {
                        bool clasaGasita = false;
                        int contorEsec = -1;

                        while (!clasaGasita)
                        {
                            int croom_rnd = rnd.Next(0, classRooms_ID.Count());
                            int weekday_rnd = rnd.Next(0, 5);
                            int modul_rnd;
                            contorEsec++;
                            if (contorEsec >= 12)
                                modul_rnd = rnd.Next(0, 5);
                            else
                                modul_rnd = rnd.Next(0, 3);

                            if (classRooms_Zile_Module[classRooms_ID[croom_rnd]][zileSaptaman[weekday_rnd]][modul_rnd] == false)
                            {
                                string numeSala = (from sal in context.ClassRooms
                                                   where sal.ID == classRooms_ID[croom_rnd]
                                                   select sal.Name).First();

                                //Verificam daca nu avem deja modulul acela ocupat
                                bool checkOcupat = false;
                                for (int j = 0; j < gt.Zi.Count(); j++)
                                {
                                    if (zileSaptaman[weekday_rnd] == gt.Zi[j] && modul_rnd == gt.Modul[j])
                                    {
                                        checkOcupat = true;
                                        break;
                                    }
                                }
                                //Verificam daca nu se suprapun 2 profesori
                                if (CheckProfessorsSync(numeSala, zileSaptaman[weekday_rnd], modul_rnd, oraCurs.Class.Name, grupa.Description, oraCurs.Class.Professor.Name) == false)
                                    checkOcupat = true;

                                if (checkOcupat == true)
                                    continue;

                                //Adaugam in lista aici
                                gt.Clasa.Add(numeSala);
                                gt.Zi.Add(zileSaptaman[weekday_rnd]);
                                gt.Modul.Add(modul_rnd);
                                gt.OraCurs.Add(oraCurs.Class.Name);

                                classRooms_Zile_Module[classRooms_ID[croom_rnd]][zileSaptaman[weekday_rnd]][modul_rnd] = true;
                                clasaGasita = true;
                            }
                        }
                    }
                }
                orarFinalGrupe.Add(gt);
            }
        }

        private void tbox_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
