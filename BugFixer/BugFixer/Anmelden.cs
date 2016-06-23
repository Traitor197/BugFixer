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
                        Spiel spiel = new Spiel(account);
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
            catch (Exception)
            {
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
	}
}
