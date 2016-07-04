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
using ModelBugFixer;
using DatenTransferDLL;

namespace BugFixer
{
	public partial class Spiel : Form
	{
        private DTO dto;
        private Account account;

        private DataTable dtProgrammierer, dtVirensucher, dtStatistik, dtSpeicherstand;

        private float kostenMultiplier = 1.25f;

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

        public Spiel(Account account, OleDbConnection con, DTO dto)
		{
            this.account = account;
            this.dto = dto;

            FixesProKlick = 1;
            FixesProSekunde = 0;
            
			InitializeComponent();
            InitializeDTO();
            Initialize();
            SetupDataGridViewStatistik();

            // Ändere Schriftgröße der DataGridViews
			
            dataGridViewProgrammierer.RowHeadersVisible = false;
            dataGridViewProgrammierer.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            dataGridViewProgrammierer.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
			dataGridViewProgrammierer.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);

			dataGridViewVirensucher.RowHeadersVisible = false;
			dataGridViewVirensucher.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
			dataGridViewVirensucher.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
			dataGridViewVirensucher.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);

			InitializeControls();

            timerCountSeconds.Enabled = true;
			InitializeDataGridViews();
        }

        private void InitializeDTO()
        {
            dto.InitDataAdapters(account.ID);

            dtProgrammierer = new DataTable();
            dtVirensucher = new DataTable();
            dtStatistik = new DataTable();
            dtSpeicherstand = new DataTable();

            dto.GetProgrammierer(dtProgrammierer);
            dto.GetVirensucher(dtVirensucher);
            dto.GetStatistik(dtStatistik);
            dto.GetSpeicherstand(dtSpeicherstand);

            dataGridViewProgrammierer.DataSource = dtProgrammierer;
            dataGridViewVirensucher.DataSource = dtVirensucher;
        }

        private void Initialize()
        {
            // Ermittle Wert für FixesProKlick
            foreach (DataRow row in dtProgrammierer.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);

                foreach (DataRow row2 in dtSpeicherstand.Rows) 
                {
                    if (Convert.ToInt32(row2["Hilfsmittel"]) == id)
                    {
                        int anzahl = Convert.ToInt32(row2["Anzahl"]);
                        int fixwert = Convert.ToInt32(row["Fixwert"]);

                        FixesProKlick += fixwert * anzahl;

                        row["Kaufkosten"] = Convert.ToInt32(row["Kaufkosten"]) * Math.Pow(kostenMultiplier, anzahl);
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
                        int fixwert = Convert.ToInt32(row["Fixwert"]);

                        FixesProSekunde += fixwert * anzahl;

                        row["Kaufkosten"] = Convert.ToInt32(row["Kaufkosten"]) * Math.Pow(kostenMultiplier, anzahl);
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

			dataGridViewProgrammierer.Columns[0].Visible = false;
			dataGridViewProgrammierer.Columns[4].Visible = false;
			dataGridViewVirensucher.Columns[0].Visible = false;
			dataGridViewVirensucher.Columns[4].Visible = false;

			dataGridViewProgrammierer.Columns.Add("Gekauft", "Gekauft");
			dataGridViewVirensucher.Columns.Add("Gekauft", "Gekauft");

			labelStatus.Visible = false;

			labelFixesProKlick.Text = FixesProKlick.ToString();
			labelFixesProSekunde.Text = FixesProSekunde.ToString();
		}

		private void InitializeDataGridViews()
		{
			dataGridViewProgrammierer.Sort(dataGridViewProgrammierer.Columns["Fixwert"], ListSortDirection.Ascending);
			dataGridViewVirensucher.Sort(dataGridViewVirensucher.Columns["Fixwert"], ListSortDirection.Ascending);
            dataGridViewStatistik.ClearSelection();
			DataGridViewRowCollection rows = dataGridViewProgrammierer.Rows;
			DataRowCollection collection = dtSpeicherstand.Rows;
			foreach (DataRow row in collection)
			{
				foreach (DataGridViewRow gridViewRow in rows)
				{
					int hilfsmittelFK = Convert.ToInt32(row["Hilfsmittel"]);
					int hilfsmittelPK = Convert.ToInt32(gridViewRow.Cells["ID"].Value);
					if (hilfsmittelFK == hilfsmittelPK)
					{
						gridViewRow.Cells["Gekauft"].Value = Convert.ToInt32(row["Anzahl"]);
					}
				}
			}

			rows = dataGridViewVirensucher.Rows;
			collection = dtSpeicherstand.Rows;
			foreach (DataRow row in collection)
			{
				foreach (DataGridViewRow gridViewRow in rows)
				{
					int hilfsmittelFK = Convert.ToInt32(row["Hilfsmittel"]);
					int hilfsmittelPK = Convert.ToInt32(gridViewRow.Cells["ID"].Value);
					if (hilfsmittelFK == hilfsmittelPK)
					{
						gridViewRow.Cells["Gekauft"].Value = Convert.ToInt32(row["Anzahl"]);
					}
				}
			}
		}

		private void SetupDataGridViewStatistik()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Header", typeof(string));
            dt.Columns.Add("Values", typeof(string));

            for (int i = 0; i < dtStatistik.Columns.Count - 2; i++)
            {
                DataColumn col = dtStatistik.Columns[i + 1];
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

			for (int i = 0; i < dtStatistik.Columns.Count - 2; i++)
            {
                table.Rows[i][1] = row[i + 1];
            }
		}

        private void Spiel_FormClosing(object sender, FormClosingEventArgs e)
        {
            dto.SpeichereStatistik(dtStatistik);
            dto.SpeichereSpeicherstand(dtSpeicherstand);
        }

		bool selectable = true;

		private void timerGridViews_Tick(object sender, EventArgs e)
		{
			InitializeDataGridViews();
			timerGridViews.Enabled = false;
		}

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
			dtStatistik.Rows[0]["GefixteBugs"] = Convert.ToInt32(dtStatistik.Rows[0]["GefixteBugs"]) + FixesProKlick;

			UpdateDataGridViewStatistik();
		}

		private void buttonKaufen_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection selectedRow = dataGridViewProgrammierer.SelectedRows;

			bool findetViren = false;
			if (selectedRow.Count <= 0)
			{
				selectedRow = dataGridViewVirensucher.SelectedRows;
				findetViren = true;
			}

			if (selectedRow.Count <= 0)
				return;

			int kaufkosten = Convert.ToInt32(selectedRow[0].Cells["kaufkosten"].Value);
			int fixwert = Convert.ToInt32(selectedRow[0].Cells["Fixwert"].Value);

			if (AktuelleFixes >= kaufkosten)
			{

				AktuelleFixes -= kaufkosten;

				dtStatistik.Rows[0]["AusgegebeneFixes"] = Convert.ToInt32(dtStatistik.Rows[0]["AusgegebeneFixes"]) + kaufkosten;
				
				DataRowCollection collection = dtSpeicherstand.Rows;
				foreach(DataRow row in collection)
				{
					int hilfsmittelFK = Convert.ToInt32(row["Hilfsmittel"]);
					int hilfsmittelPK = Convert.ToInt32(selectedRow[0].Cells["ID"].Value);
					if (hilfsmittelFK == hilfsmittelPK)
					{
						row["Anzahl"] = Convert.ToInt32(row["Anzahl"]) + 1;
                        selectedRow[0].Cells["Kaufkosten"].Value = Convert.ToInt32(Convert.ToInt32(selectedRow[0].Cells["Kaufkosten"].Value) * kostenMultiplier);
                        selectedRow[0].Cells["Gekauft"].Value = Convert.ToInt32(row["Anzahl"]);
					}
				}

				if (findetViren)
				{
					FixesProSekunde += fixwert;
					labelFixesProSekunde.Text = FixesProSekunde.ToString();
				}
				else
				{
					FixesProKlick += fixwert;
					labelFixesProKlick.Text = FixesProKlick.ToString();
				}

				UpdateDataGridViewStatistik();
				labelStatus.Visible = false;

			}
			else
			{
				labelStatus.Text = "Es fehlen " + (kaufkosten - AktuelleFixes) + " Fixes!";
				labelStatus.Visible = true;
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
