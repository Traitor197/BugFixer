using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BugFixer
{
	public partial class Spiel : Form
	{
        private OleDbConnection con;
        private List<Hilfsmittel> listProgrammierer;
        private List<Hilfsmittel> listVirensucher;

		public Spiel()
		{
            this.listProgrammierer = new List<Hilfsmittel>();
            this.listVirensucher = new List<Hilfsmittel>();

			InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            con = new OleDbConnection(Properties.Settings.Default.ConString);
            con.Open();

            OleDbCommand cmd = con.CreateCommand();

            // Programmierer
            DataTable dtProgrammierer = new DataTable("Programmierer");
            dtProgrammierer.Columns.Add(new DataColumn("Bezeichnung"));
            dtProgrammierer.Columns.Add(new DataColumn("Kaufkosten", typeof(int)));
            dtProgrammierer.Columns.Add(new DataColumn("Verbesserungswert", typeof(int)));
            dtProgrammierer.Columns.Add(new DataColumn("Fixwert", typeof(int)));
            dtProgrammierer.Columns.Add(new DataColumn("Fixwert (Gesamt)", typeof(int)));

            cmd.CommandText = "Select * From Hilfsmittel Where findetViren=false;";
            
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AddNewRow(dtProgrammierer, Hilfsmittel.mkHilfsmittel(reader));
            }
            reader.Close();
            dataGridViewProgrammierer.DataSource = dtProgrammierer;

            // Virensucher
            DataTable dtVirensucher = new DataTable("Programmierer");
            dtVirensucher.Columns.Add(new DataColumn("Bezeichnung"));
            dtVirensucher.Columns.Add(new DataColumn("Kaufkosten", typeof(int)));
            dtVirensucher.Columns.Add(new DataColumn("Verbesserungswert", typeof(int)));
            dtVirensucher.Columns.Add(new DataColumn("Fixwert", typeof(int)));
            dtVirensucher.Columns.Add(new DataColumn("Fixwert (Gesamt)", typeof(int)));

            cmd.CommandText = "Select * From Hilfsmittel Where findetViren=true;";
            
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AddNewRow(dtVirensucher, Hilfsmittel.mkHilfsmittel(reader));
            }
            reader.Close();
            dataGridViewVirensucher.DataSource = dtVirensucher;


        }

        private void AddNewRow(DataTable dt, Hilfsmittel hilfsmittel)
        {
            DataRow dr = dt.NewRow();
            dr[0] = hilfsmittel.Bezeichnung; 
            dr[1] = hilfsmittel.Kaufkosten; 
            dr[2] = hilfsmittel.Verbesserungskosten; 
            dr[3] = hilfsmittel.Fixwert;
            dr[4] = hilfsmittel.Fixwert;

            dt.Rows.Add(dr);
        }

        private void listBoxVirensucher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
	}
}
