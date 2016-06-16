using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixer
{
	class Hilfsmittel
	{
		public int ID { get; set; }
		public string Bezeichnung { get; set; }
		public int Fixwert { get; set; }
		public int Kaufkosten { get; set; }
		public int Verbesserungskosten { get; set; }
		public string Bildpfad { get; set; }
		public bool FindetViren { get; set; }
	}
}
