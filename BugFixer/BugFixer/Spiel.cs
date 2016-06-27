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
        private Account account;

        private List<Hilfsmittel> listProgrammierer;
        private List<Hilfsmittel> listVirensucher;

		public Spiel(Account account)
		{
            this.account = account;
            this.listProgrammierer = new List<Hilfsmittel>();
            this.listVirensucher = new List<Hilfsmittel>();

			InitializeComponent();
            SetupDataGridViewStatistik();
            Initialize();
        }

        private void Initialize()
        {
            OleDbConnectionStringBuilder strBuilder = new OleDbConnectionStringBuilder();
            strBuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
            strBuilder.DataSource = Properties.Settings.Default.DbPath;

            con = new OleDbConnection(strBuilder.ConnectionString);
            con.Open();

            OleDbCommand cmd = con.CreateCommand();

            // Programmierer
            DataTable dtProgrammierer = new DataTable("Programmierer");
            dtProgrammierer.Columns.Add(new DataColumn("Bezeichnung"));
            dtProgrammierer.Columns.Add(new DataColumn("Kaufkosten", typeof(int)));
            dtProgrammierer.Columns.Add(new DataColumn("Verbesserungskosten", typeof(int)));
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
            dtVirensucher.Columns.Add(new DataColumn("Verbesserungskosten", typeof(int)));
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

            // Statistik
            DataTable dtStatistik = new DataTable("Statistik");

        }

        private void SetupDataGridViewStatistik()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Header", typeof(string));
            dt.Columns.Add("Values", typeof(string));
            dt.Rows.Add(new Object[] { "H1", "V1" });
            dt.Rows.Add(new Object[] { "H2", "V2" });

            dataGridViewStatistik.DataSource = dt.DefaultView;
            dataGridViewStatistik.RowHeadersVisible = true;
            int numColToFreeze = 2;
            for (int i = 0; i < numColToFreeze - 1; i++)
            {
                dataGridViewStatistik.Columns[i].Frozen = true;
                dataGridViewStatistik.Columns[i].DefaultCellStyle = dataGridViewStatistik.RowHeadersDefaultCellStyle;
                dataGridViewStatistik.Columns[i].ReadOnly = true;
            }
            /*
            Dim NumColToFreeze As Int32 = 2
              With DataGridView1
                 .RowHeadersVisible = True
                 For i As Int32 = 0 To NumColToFreeze -1
                    .Columns(i).Frozen = True ' prevents column from scrolling out of view
                    .Columns(i).DefaultCellStyle = .RowHeadersDefaultCellStyle ' make it look like a header
                    .Columns(i).ReadOnly = True
                 Next
              End With
           End Sub
           */

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

        private void Spiel_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

		private void pictureBoxBug_Click(object sender, EventArgs e)
		{

		}

		bool selectable = true;
		private void dataGridViewProgrammierer_SelectionChanged(object sender, EventArgs e)
		{
			if (selectable == true)
			{
				selectable = false;
				dataGridViewVirensucher.ClearSelection();
			}

			selectable = true;
		}

		private void dataGridViewVirensucher_SelectionChanged(object sender, EventArgs e)
		{
			if (selectable == true)
			{
				selectable = false;
				dataGridViewProgrammierer.ClearSelection();
			}

			selectable = true;
		}
	}
}
