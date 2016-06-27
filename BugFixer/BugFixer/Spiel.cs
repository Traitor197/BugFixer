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

        private OleDbDataAdapter adapterProgrammierer, adapterVirensucher, adapterStatistik;
        private DataTable dtProgrammierer, dtVirensucher, dtStatistik;
  

		public int AktuelleFixes
		{
			get
			{

                return 2;
			}
			set
			{

			}
		}

		public Spiel(Account account)
		{
            this.account = account;

			InitializeComponent();
            InitDataAdapters();
            SetupDataGridViewStatistik();
            Initialize();
			InitializeControls();
		}

        private void InitDataAdapters()
        {
            adapterProgrammierer = new OleDbDataAdapter("SELECT * FROM Hilfsmittel WHERE findetViren=false", con);
            OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder(adapterProgrammierer);
            adapterProgrammierer.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapterProgrammierer.InsertCommand = cmdBuilder.GetInsertCommand();
            adapterProgrammierer.UpdateCommand = cmdBuilder.GetUpdateCommand();

            adapterVirensucher = new OleDbDataAdapter("SELECT * FROM Hilfsmittel WHERE findetViren=true", con);
            cmdBuilder = new OleDbCommandBuilder(adapterVirensucher);
            adapterVirensucher.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapterVirensucher.InsertCommand = cmdBuilder.GetInsertCommand();
            adapterVirensucher.UpdateCommand = cmdBuilder.GetUpdateCommand();

            adapterStatistik = new OleDbDataAdapter("SELECT * FROM Statistik WHERE account=" + account.ID, con);
            cmdBuilder = new OleDbCommandBuilder(adapterVirensucher);
            adapterVirensucher.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapterVirensucher.InsertCommand = cmdBuilder.GetInsertCommand();
            adapterVirensucher.UpdateCommand = cmdBuilder.GetUpdateCommand();
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
            dtProgrammierer = new DataTable(); 
            adapterProgrammierer.Fill(dtProgrammierer);
            /*
            dtProgrammierer.Columns.Add(new DataColumn("Bezeichnung"));
            dtProgrammierer.Columns.Add(new DataColumn("Kaufkosten", typeof(int)));
            dtProgrammierer.Columns.Add(new DataColumn("Verbesserungskosten", typeof(int)));
            dtProgrammierer.Columns.Add(new DataColumn("Fixwert", typeof(int)));
            dtProgrammierer.Columns.Add(new DataColumn("Fixwert (Gesamt)", typeof(int)));
            */

            dataGridViewProgrammierer.DataSource = dtProgrammierer;

            // Virensucher
            dtVirensucher = new DataTable();
            adapterVirensucher.Fill(dtVirensucher);
            /*
            dtVirensucher.Columns.Add(new DataColumn("Bezeichnung"));
            dtVirensucher.Columns.Add(new DataColumn("Kaufkosten", typeof(int)));
            dtVirensucher.Columns.Add(new DataColumn("Verbesserungskosten", typeof(int)));
            dtVirensucher.Columns.Add(new DataColumn("Fixwert", typeof(int)));
            dtVirensucher.Columns.Add(new DataColumn("Fixwert (Gesamt)", typeof(int)));
            */

            dataGridViewVirensucher.DataSource = dtVirensucher;

            // Statistik
            dtStatistik = new DataTable("Statistik");
            adapterStatistik.Fill(dtStatistik);
            dataGridViewStatistik.DataSource = dtStatistik;
        }

		private void InitializeControls()
		{
			Point newLocation = pictureBoxBug.Location;
			newLocation.X = (this.ClientSize.Width - pictureBoxBug.Width) / 2;
            pictureBoxBug.Location = newLocation;

			toolStripStatusLabelAccount.Text = "Angemeldet als " + account.Nickname;
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

        private void AddNewRow(DataTable dt)
        {
            /*
            DataRow dr = dt.NewRow();
            dr[0] = hilfsmittel.Bezeichnung; 
            dr[1] = hilfsmittel.Kaufkosten; 
            dr[2] = hilfsmittel.Verbesserungskosten; 
            dr[3] = hilfsmittel.Fixwert;
            dr[4] = hilfsmittel.Fixwert;

            dt.Rows.Add(dr);
            */
        }

        private void listBoxVirensucher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Spiel_FormClosing(object sender, FormClosingEventArgs e)
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

		private void pictureBoxBug_MouseDown(object sender, MouseEventArgs e)
		{
			AktuelleFixes++;
		}

		private void buttonKaufen_Click(object sender, EventArgs e)
		{
			if(AktuelleFixes >= 1)
			{

                AktuelleFixes -= 1;
			}
		}

		private void buttonVerbessern_Click(object sender, EventArgs e)
		{
			if (AktuelleFixes >= 1)
			{
                AktuelleFixes -= 1;
			}
		}
	}
}
