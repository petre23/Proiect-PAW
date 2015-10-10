using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GamingSite.Models.ModelBL
{
    public class BaseBL
    {
        public SqlConnection _connection;
        public string _connectionSring = GamingSite.Properties.Settings.Default.ConnectionString;
        public SqlCommand command;

        public BaseBL() 
        {
            _connection = new SqlConnection(_connectionSring);
            command = new SqlCommand();
            command.Connection = _connection;
        }
    }
}