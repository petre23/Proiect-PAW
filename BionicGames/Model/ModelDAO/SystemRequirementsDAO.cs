using Model.ModelBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDAO
{
    public class SystemRequirementsDAO: BaseDAO
    {
        public SystemRequirementsDAO() : base() { }

        public SystemRequirements GetSystemReqByGameId(int gameid)
        {
            SystemRequirements sysReq = new SystemRequirements();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM SystemRequirements WHERE Game = @GameId";

                command.CommandText = selectString;
                command.Parameters.Add("@GameId", gameid);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    sysReq.Game = Convert.ToInt32(reader["Game"]);
                    sysReq.OS = reader["OS"].ToString();
                    sysReq.Processor = reader["Processor"].ToString();
                    sysReq.SystemRequirementsId = Convert.ToInt32(reader["Genre"]);
                    sysReq.Memory = reader["Memory"].ToString() + " GB Ram";
                }

                reader.Close();
                _connection.Close();
            }
            return sysReq;
        }

        public SystemRequirements GetSystemReqById(int id)
        {
            SystemRequirements sysReq = new SystemRequirements();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM SystemRequirements WHERE SystemRequirementsId = @SystemRequirementsId";

                command.CommandText = selectString;
                command.Parameters.Add("@SystemRequirementsId", id);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    sysReq.Game = Convert.ToInt32(reader["Game"]);
                    sysReq.OS = reader["OS"].ToString();
                    sysReq.Processor = reader["Processor"].ToString();
                    sysReq.Memory = reader["Memory"].ToString() + " GB Ram";
                }

                reader.Close();
                _connection.Close();
            }
            return sysReq;
        }

        public void InsertSysReqGame(SystemRequirements sysReq)
        {

            using (_connection)
            {
                _connection.Open();
                string insertString = @"INSERT INTO SystemRequirements VALUES(
                                        @Processor,@Memory,@OS,@Game)";

                command.CommandText = insertString;

                command.Parameters.Add("@Processor", sysReq.Processor);
                command.Parameters.Add("@Memory", sysReq.Memory);
                command.Parameters.Add("@OS", sysReq.OS);
                command.Parameters.Add("@Game", sysReq.Game);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void UpdateGameById(SystemRequirements sysReq)
        {
            using (_connection)
            {
                _connection.Open();
                string updateString = @"UPDATE SystemRequirements SET Processor = @Processor,Memory = @Memory,
                                                    OS = @OS,Game = @Game
                                                    WHERE SystemRequirementsId = @SystemRequirementsId";
                command.CommandText = updateString;

                command.Parameters.Add("@SystemRequirementsId", sysReq.SystemRequirementsId);
                command.Parameters.Add("@Processor", sysReq.Processor);
                command.Parameters.Add("@OS", sysReq.OS);
                command.Parameters.Add("@Game", sysReq.Game);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void DeleteGame(int id)
        {
            using (_connection)
            {
                _connection.Open();

                string deleteString = "DELETE FROM SystemRequirements WHERE SystemRequirementsId = @SystemRequirementsId";

                command.CommandText = deleteString;
                command.Parameters.Add("@SystemRequirementsId", id);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }
    }
}
