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
using DatenTransferDLL;
using ModelBugFixer;

namespace BugFixer
{
	public partial class Anmelden : Form
	{
        private DTO dto = null;
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
                dto = new DTO();

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
            if (!userInputCheck())
                return;

            Account account = dto.GetAccountFromNickname(textBoxNickname.Text);

            if (account != null)
            {
                if (account.Passwort == textBoxPasswort.Text)
                {
                    labelStatus.Text = "Anmeldung erfolgreich!";
                    Spiel spiel = new Spiel(account, con);
                    spiel.Show();

                    return;
                }
            }

            labelStatus.Text = "Anmeldung fehlgeschlagen!\nNickname oder Passwort ist falsch.";
        }

        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
            // Vorgang abbrechen wenn Benutzer ungültige Werte eingibt
            if (!userInputCheck())
                return;

            Account account = dto.GetAccountFromNickname(textBoxNickname.Text);

            if (account == null)
            {
                dto.InsertNewAccount(textBoxNickname.Text, textBoxPasswort.Text);
                labelStatus.Text = "Registrierung erfolgreich!";
            }
        }

        private void buttonRegistrieren_Click1(object sender, EventArgs e)
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

                    cmd.CommandText = "SELECT ID FROM Account WHERE Nickname='" + textBoxNickname.Text + "'";
                    int accountAutowert = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = "Insert Into Statistik (Geklickt, GefixteBugs, GefundeneViren, AusgegebeneFixes, VergangeneZeit, AktuelleFixes, Account) " +
                        "Values (0, 0, 0, 0, 0, 0, " + accountAutowert + ")";
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
