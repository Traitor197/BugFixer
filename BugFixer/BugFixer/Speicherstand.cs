using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixer
{
    class Speicherstand
    {
        public int ID { get; set; }
        public Account AccountForeignkey { get; set; }
        public Hilfsmittel HilfsmittelForeignkey { get; set; }
        public int Anzahl { get; set; }
        public int Verbesserungsstufe { get; set; }
    }
}
