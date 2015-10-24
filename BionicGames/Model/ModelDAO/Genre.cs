using Model.ModelBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDAO
{
    public class GenreDAO : BaseDAO
    {
        public GenreDAO()
            : base()
        { }

        public Genre GetGenreById(int id)
        {
            Genre genre = new Genre();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM GENRE WHERE GenreId = @GenreId";

                command.CommandText = selectString;
                command.Parameters.Add("@GenreId", id);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    genre.GenreId = reader["GenreId"].ToString();
                    genre.Description = reader["Description"].ToString();
                }
                reader.Close();

                _connection.Close();
            }
            return genre;
        }

        public List<Genre> GetAllGenres(int id)
        {
            List<Genre> ganreList = new List<Genre>();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM GAME";

                command.CommandText = selectString;

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    Genre genre = new Genre();
                    genre.GenreId = reader["GenreId"].ToString();
                    genre.Description = reader["Description"].ToString();

                    ganreList.Add(genre);
                }
                reader.Close();
                _connection.Close();
            }
            return ganreList;
        }

        public void InsertGenre(Genre genre)
        {
            using (_connection)
            {
                _connection.Open();
                string insertString = @"INSERT INTO Genre(Description) VALUES(@Description)";
                command.CommandText = insertString;

                command.Parameters.Add("@Description", genre.Description);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void UpdateGenre(Genre genre)
        {
            using (_connection)
            {
                _connection.Open();
                string insertString = @"UPDATE Genre SET 
                                            Description = @Description
                                            WHERE GenreId = @GenreId";
                command.CommandText = insertString;

                command.Parameters.Add("@Description", genre.Description);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void DeleteGenre(string genre)
        {
            using (_connection)
            {
                _connection.Open();
                string deleteString = @"DELETE FROM Genre WHERE GenreId = @GenreId";
                command.CommandText = deleteString;

                command.Parameters.Add("@GenreId", genre);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }
    }
}
