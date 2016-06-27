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
	public partial class Anmelden : Form
	{
        private OleDbConnection con = null;
        public OleDbDataAdapter AdapterAccount { get; set; }
        public OleDbDataAdapter AdapterHilfsmittel { get; set; }
        public OleDbDataAdapter AdapterSpeicherstand { get; set; }
        public OleDbDataAdapter AdapterStatistik { get; set; }
        public DataTable dtHilfsmittel { get; set; }
        public DataTable dtSpeicherstand { get; set; }
        public DataTable dtStatistik { get; set; }

        public Anmelden()
		{
			InitializeComponent();
            Initialize();
		}

        private void Initialize()
        {
            try
            {
                OleDbConnectionStringBuilder strbld = new OleDbConnectionStringBuilder();
                strbld.Provider = "Microsoft.ACE.OLEDB.12.0";
                strbld.DataSource = Properties.Settings.Default.DbPath;
                con = new OleDbConnection(strbld.ConnectionString);
                con.Open();
            }
            catch (Exception)
            {
                labelStatus.Text = "Datenbank konnte nicht geöffnet werden.";
            }

        }

        private void InitAdapters()
        {
            OleDbCommandBuilder cmdBuilder;
            // Instantiate adapters
            AdapterAccount = new OleDbDataAdapter("SELECT * FROM Account", con);
            cmdBuilder = new OleDbCommandBuilder(AdapterAccount);
            AdapterAccount.DeleteCommand = cmdBuilder.GetDeleteCommand();
            AdapterAccount.InsertCommand = cmdBuilder.GetInsertCommand();
            AdapterAccount.UpdateCommand = cmdBuilder.GetUpdateCommand();

            /*
            AdapterHilfsmittel = new OleDbDataAdapter("SELECT * FROM Hilfsmittel", con);
            cmdBuilder = new OleDbCommandBuilder(AdapterHilfsmittel);
            AdapterAccount.DeleteCommand = cmdBuilder.GetDeleteCommand();
            AdapterAccount.InsertCommand = cmdBuilder.GetInsertCommand();
            AdapterAccount.UpdateCommand = cmdBuilder.GetUpdateCommand();

            AdapterSpeicherstand = new OleDbDataAdapter("SELECT * FROM Speicherstand", con);
            cmdBuilder = new OleDbCommandBuilder(AdapterSpeicherstand);
            AdapterSpeicherstand.DeleteCommand = cmdBuilder.GetDeleteCommand();
            AdapterSpeicherstand.InsertCommand = cmdBuilder.GetInsertCommand();
            AdapterSpeicherstand.UpdateCommand = cmdBuilder.GetUpdateCommand();

            AdapterStatistik = new OleDbDataAdapter("SELECT * FROM Statistik", con);
            cmdBuilder = new OleDbCommandBuilder(AdapterStatistik);
            AdapterStatistik.DeleteCommand = cmdBuilder.GetDeleteCommand();
            AdapterStatistik.InsertCommand = cmdBuilder.GetInsertCommand();
            AdapterStatistik.UpdateCommand = cmdBuilder.GetUpdateCommand();
            */
        }

        private void FillDataset()
        {
        }

        private bool userInputCheck()
        {
            if (textBoxNickname.Text.Length < 4)
            {
                labelStatus.Text = "Nickname zu kurz (min. 4 Zeichen)";
                return false;
            }

            if (textBoxPasswort.Text.Length < 3)
            {
                labelStatus.Text = "Passwort zu kurz (min. 3 Zeichen)";
                return false;
            }

            return true;
        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            // Vorgang abbrechen wenn Benutzer ungültige Werte eingibt
            if (!userInputCheck())
                return;

            OleDbDataReader reader = null;
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * From Account Where Nickname='" + textBoxNickname.Text + "';";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Account account = Account.mkAccount(reader);

                    if (textBoxPasswort.Text == account.Passwort)
                    {
                        labelStatus.Text = "Anmeldung erfolgreich!";
                        Spiel spiel = new Spiel(account, con);
                        spiel.Show();
                    }
                    else
                    {
                        labelStatus.Text = "Anmeldung fehlgeschlagen!\nNickname oder Passwort ist falsch.";
                    }
                }
                else
                {
                    labelStatus.Text = "Anmeldung fehlgeschlagen!\nNickname oder Passwort ist falsch.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                labelStatus.Text = "Datenbankfehler";
            }

            reader.Close();

        }

        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
            // Vorgang abbrechen wenn User ungültige Werte eingibt
            if (!userInputCheck())
                return;

            OleDbDataReader reader = null;
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * From Account Where Nickname='" + textBoxNickname.Text + "';";

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    labelStatus.Text = "Registrierung fehlgeschlagen!\nNickname ist schon vergeben.";
                }
                else
                {
                    reader.Close();
                    cmd.CommandText = "Insert Into Account (Nickname, Passwort) Values ('" + textBoxNickname.Text + "', '" + textBoxPasswort.Text + "');";
                    cmd.ExecuteNonQuery();

                    labelStatus.Text = "Registrierung erfolgreich!";
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Datenbankfehler";
                MessageBox.Show(ex.Message);
            }

            reader.Close();
        }

		private void textBoxPasswort_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				buttonAnmelden_Click(sender, new EventArgs());
			}
		}
	}
}
