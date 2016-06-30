﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenTransferDLL
{
    class DTO
    {
        private OleDbConnection con = null;

        private OleDbDataAdapter adapterProgrammierer, adapterVirensucher, adapterStatistik, adapterSpeicherstand;
        private DataTable dtProgrammierer, dtVirensucher, dtStatistik, dtSpeicherstand;

        public DTO()
        {
            OleDbConnectionStringBuilder sb = new OleDbConnectionStringBuilder();
            sb.Provider = "Microsoft.ACE.OLEDB.12.0";
            sb.DataSource = Properties.Settings1.Default.DbPath;
            con = new OleDbConnection(sb.ConnectionString);
            OpenConnection();
            // InitDataAdapters();
        }

        private bool OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            return true;
        }

        public bool PrüfeAccountVorhanden(string nickname)
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select * From Account Where Nickname='" + nickname + "';";
            
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            return false;
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
    }
}