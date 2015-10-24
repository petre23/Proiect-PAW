using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDAO
{
    public class BaseDAO
    {
        public SqlConnection _connection;
        public string _connectionSring = Model.Properties.Settings.Default.ConnectionString;
        public SqlCommand command;

        public BaseDAO()
        {
            _connection = new SqlConnection(_connectionSring);
            command = new SqlCommand();
            command.Connection = _connection;
        }
    }
}
