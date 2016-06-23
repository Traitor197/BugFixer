using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BugFixer
{
	public class Account
	{
		public int ID { get; set; }
		public string Nickname { get; set; }
		public string Passwort { get; set; }

        public static Account mkAccount(OleDbDataReader reader)
        {
            Account account = new Account();

            account.ID = Convert.ToInt32(reader["ID"]);
            account.Nickname = Convert.ToString(reader["Nickname"]);
            account.Passwort = Convert.ToString(reader["Passwort"]);

            return account;
        }
	}
}
