using Model.ModelBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDAO
{
    public class RatingDAO : BaseDAO
    {
        public RatingDAO() : base() { }

        public void AddtRating(Rating rating)
        {
            using (_connection)
            {
                _connection.Open();
                string insertString = @"INSERT INTO RATING VALUES(@Rating,@GameId)";
                command.CommandText = insertString;

                command.Parameters.Add("@Rating", rating.Rate);
                command.Parameters.Add("@GameId", rating.GameId);
                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void UpdateRating(Rating rating)
        {
            using (_connection)
            {
                _connection.Open();
                string insertString = @"UPDATE RATING SET 
                                            Rating = @Rating
                                            WHERE GameId = @GameId ";
                command.CommandText = insertString;

                command.Parameters.Add("@GameId", rating.GameId);
                command.Parameters.Add("@Rating", rating.Rate);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void DeleteRating(Rating rating)
        {
            using (_connection)
            {
                _connection.Open();
                string deleteString = @"DELETE FROM RATING WHERE GameId = @GameId ";
                command.CommandText = deleteString;

                command.Parameters.Add("@GameId", rating.GameId);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public string GetGameRating(Rating rating)
        {
            string avgRating = "0";
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT AVG(Rating) AS AvgRating FROM RATING WHERE GameId = @GameId ";

                command.CommandText = selectString;
                command.Parameters.Add("@GameId", rating.GameId);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    avgRating = reader["AvgRating"].ToString();
                }
                reader.Close();

                _connection.Close();
            }
            return avgRating;
        }
    }
}
