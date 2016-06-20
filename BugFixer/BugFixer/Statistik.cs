using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixer
{
    class Statistik
    {
        public int ID { get; set; }
        public Account account { get; set; }
        public int Geklickt { get; set; }
        public int GefixteBugs { get; set; }
        public int GefundeneViren { get; set; }
        public int AusgegebeneFixes { get; set; }
        public int VergangeneZeit { get; set; }
    }
}
