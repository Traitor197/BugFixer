using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

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

        public override string ToString()
        {
            return Bezeichnung + " : " + Kaufkosten;
        }

        public static Hilfsmittel mkHilfsmittel(OleDbDataReader reader)
        {
            Hilfsmittel hilfsmittel = new Hilfsmittel();

            hilfsmittel.ID = Convert.ToInt32(removeDbNull(reader["ID"]));
            hilfsmittel.Bezeichnung = Convert.ToString(removeDbNull(reader["Bezeichnung"]));
            hilfsmittel.Fixwert = Convert.ToInt32(removeDbNull(reader["Fixwert"]));
            hilfsmittel.Kaufkosten = Convert.ToInt32(removeDbNull(reader["Kaufkosten"]));
            hilfsmittel.Verbesserungskosten = Convert.ToInt32(removeDbNull(reader["Verbesserungskosten"]));
            hilfsmittel.Bildpfad = Convert.ToString(removeDbNull(reader["Bildpfad"]));
            hilfsmittel.FindetViren = Convert.ToBoolean(removeDbNull(reader["findetViren"]));
            
            return hilfsmittel;
        }

        public static Object removeDbNull(Object o)
        {
            if (o == DBNull.Value)
            {
                return null;
            }
            return o;
        }
	}
}
