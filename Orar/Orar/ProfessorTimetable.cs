using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orar
{
    class ProfessorTimetable
    {
        public string NumeProfesor{ get; set; }
        public List<string> Clasa { get; set; }
        public List<string> Zi { get; set; }
        public List<int> Modul { get; set; }
        public List<string> OraCurs { get; set; }
        public List<string> Grupa { get; set; }
    }
}
