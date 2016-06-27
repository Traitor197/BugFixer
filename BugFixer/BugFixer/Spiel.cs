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

		public Spiel(Account account, OleDbConnection con)
		{
            this.account = account;
            this.con = con;
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

            adapterStatistik = new OleDbDataAdapter("SELECT * FROM Statistik WHERE Account=" + account.ID.ToString(), con);
            cmdBuilder = new OleDbCommandBuilder(adapterStatistik);
            adapterStatistik.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapterStatistik.InsertCommand = cmdBuilder.GetInsertCommand();
            adapterStatistik.UpdateCommand = cmdBuilder.GetUpdateCommand();
        }

        private void Initialize()
        {
            // Programmierer
            dtProgrammierer = new DataTable(); 
            adapterProgrammierer.Fill(dtProgrammierer);
            dataGridViewProgrammierer.DataSource = dtProgrammierer;

            // Virensucher
            dtVirensucher = new DataTable();
            adapterVirensucher.Fill(dtVirensucher);
            dataGridViewVirensucher.DataSource = dtVirensucher;

            // Statistik
            dtStatistik = new DataTable();
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
            dataGridViewStatistik.RowHeadersVisible = false;
            dataGridViewStatistik.ColumnHeadersVisible = false;
            int numColToFreeze = 1;
            for (int i = 0; i < numColToFreeze; i++)
            {
                dataGridViewStatistik.Columns[i].Frozen = true;
                dataGridViewStatistik.Columns[i].DefaultCellStyle = dataGridViewStatistik.RowHeadersDefaultCellStyle;
                dataGridViewStatistik.Columns[i].ReadOnly = true;
            }
            dataGridViewStatistik.DataSource = dt;
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
