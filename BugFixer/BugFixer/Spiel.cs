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

        private OleDbDataAdapter adapterProgrammierer, adapterVirensucher, adapterStatistik, adapterSpeicherstand;
        private DataTable dtProgrammierer, dtVirensucher, dtStatistik, dtSpeicherstand;

        public int FixesProSekunde { get; set; }
        public int FixesProKlick { get; set; }

		public int AktuelleFixes
		{
			get
			{
                return Convert.ToInt32(dtStatistik.Rows[0]["AktuelleFixes"]);
			}
			set
			{
                labelFixes.Text = value.ToString();
                if (value < 0)
                {
                    dtStatistik.Rows[0]["AusgegebeneFixes"] = Convert.ToInt32(dtStatistik.Rows[0]["AusgegebeneFixes"]) - value;
                }
                dtStatistik.Rows[0]["AktuelleFixes"] = value;
			}
		}

		public Spiel(Account account, OleDbConnection con)
		{
            this.account = account;
            this.con = con;
            FixesProKlick = 1;
            FixesProSekunde = 0;

			InitializeComponent();
            InitDataAdapters();
            Initialize();
            SetupDataGridViewStatistik();
			InitializeControls();

            // Ändere Schriftgröße der DataGridViews
            dataGridViewProgrammierer.RowHeadersVisible = false;
            dataGridViewProgrammierer.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridViewProgrammierer.RowHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridViewProgrammierer.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);

            dataGridViewVirensucher.RowHeadersVisible = false;
            dataGridViewVirensucher.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridViewVirensucher.RowHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);
            dataGridViewVirensucher.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 14);

            timer1.Enabled = true;
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

            adapterSpeicherstand = new OleDbDataAdapter("SELECT * FROM Speicherstand WHERE Account=" + account.ID.ToString(), con);
            cmdBuilder = new OleDbCommandBuilder(adapterSpeicherstand);
            adapterSpeicherstand.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapterSpeicherstand.InsertCommand = cmdBuilder.GetInsertCommand();
            adapterSpeicherstand.UpdateCommand = cmdBuilder.GetUpdateCommand();
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

            // Speicherstand
            dtSpeicherstand = new DataTable();
            adapterSpeicherstand.Fill(dtSpeicherstand);

            // Ermittle Wert für FixesProKlick
            foreach (DataRow row in dtProgrammierer.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                foreach (DataRow row2 in dtSpeicherstand.Rows) 
                {
                    if (Convert.ToInt32(row2["Hilfsmittel"]) == id)
                    {
                        int anzahl = Convert.ToInt32(row2["Anzahl"]);
                        int stufe = Convert.ToInt32(row2["Verbesserungsstufe"]);
                        int fixwert = Convert.ToInt32(row["Fixwert"]);

                        FixesProKlick += fixwert * anzahl;
                    }
                }
            }

            // Ermittle Wert für FixesProSekunde
            foreach (DataRow row in dtVirensucher.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                foreach (DataRow row2 in dtSpeicherstand.Rows)
                {
                    if (Convert.ToInt32(row2["Hilfsmittel"]) == id)
                    {
                        int anzahl = Convert.ToInt32(row2["Anzahl"]);
                        int stufe = Convert.ToInt32(row2["Verbesserungsstufe"]);
                        int fixwert = Convert.ToInt32(row["Fixwert"]);

                        FixesProSekunde += fixwert * anzahl;
                    }
                }
            }

            labelFixes.Text = Convert.ToString(dtStatistik.Rows[0]["AktuelleFixes"]);
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

            for (int i = 0; i < dtStatistik.Columns.Count; i++)
            {
                DataColumn col = dtStatistik.Columns[i];
                DataRow row = dtStatistik.Rows[0];
                dt.Rows.Add(new Object[] { col.Caption, row[i] });
            }

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

        private void UpdateDataGridViewStatistik()
        {
            DataRow row = dtStatistik.Rows[0];
            DataTable table = (DataTable)dataGridViewStatistik.DataSource;

            for (int i = 0; i < dtStatistik.Columns.Count; i++)
            {
                table.Rows[i][1] = row[i];
            }
        }

        private void Spiel_FormClosing(object sender, FormClosingEventArgs e)
        {
            adapterStatistik.Update(dtStatistik);
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
            pictureBoxBug.Size = new Size(222, 198);

            AktuelleFixes += FixesProKlick;

            dtStatistik.Rows[0]["Geklickt"] = Convert.ToInt32(dtStatistik.Rows[0]["Geklickt"]) + 1;

            UpdateDataGridViewStatistik();
		}

		private void buttonKaufen_Click(object sender, EventArgs e)
		{
			if(AktuelleFixes >= 1)
			{

                AktuelleFixes -= 1;

                UpdateDataGridViewStatistik();
			}
		}

		private void buttonVerbessern_Click(object sender, EventArgs e)
		{
			if (AktuelleFixes >= 1)
			{
                AktuelleFixes -= 1;

                UpdateDataGridViewStatistik();
			}
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
            AktuelleFixes += FixesProSekunde;
            dtStatistik.Rows[0]["GefundeneViren"] = Convert.ToInt32(dtStatistik.Rows[0]["GefundeneViren"]) + FixesProSekunde;
            dtStatistik.Rows[0]["VergangeneZeit"] = Convert.ToInt32(dtStatistik.Rows[0]["VergangeneZeit"]) + 1;

            UpdateDataGridViewStatistik();
        }

        private void pictureBoxBug_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxBug.Size = new Size(234, 208);
        }
	}
}
