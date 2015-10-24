using Model.ModelBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDAO
{
    public class GameDAO : BaseDAO
    {
        public GameDAO()
            : base()
        { }

        public Game GetGameById(int id)
        {
            Game game = new Game();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM GAME WHERE GameId = @GameId";

                command.CommandText = selectString;
                command.Parameters.Add("@GameId", id);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    game.GameId = Convert.ToInt32(reader["GameId"]);
                    game.Name = reader["Name"].ToString();
                    game.ReleaseYear = Convert.ToInt32(reader["ReleaseYear"]);
                    game.Genre = reader["Genre"].ToString();
                    game.Rating = Convert.ToDecimal(reader["Rating"]);
                    game.ImageUrl = reader["ImageURL"].ToString();
                    game.CreationDate = Convert.ToDateTime(reader["CreationDate"]);
                    game.GameInfo = reader["GameInfo"].ToString();
                    game.Rating = Convert.ToDecimal(reader["Rating"]);

                }

                reader.Close();
                _connection.Close();
            }
            return game;
        }

        public List<Game> GetAllGames()
        {
            List<Game> gameList = new List<Game>();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM GAME";

                command.CommandText = selectString;

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    Game game = new Game();
                    game.GameId = Convert.ToInt32(reader["GameId"]);
                    game.Name = reader["Name"].ToString();
                    game.ReleaseYear = Convert.ToInt32(reader["ReleaseYear"]);
                    game.Genre = reader["Genre"].ToString();
                    game.Rating = Convert.ToDecimal(reader["Rating"]);
                    game.ImageUrl = reader["ImageURL"].ToString();
                    game.CreationDate = Convert.ToDateTime(reader["CreationDate"]);
                    game.GameInfo = reader["GameInfo"].ToString();
                    game.Rating = Convert.ToDecimal(reader["Rating"]);

                    gameList.Add(game);
                }
                reader.Close();

                _connection.Close();
            }
            return gameList;
        }

        public void InsertNewGame(Game game)
        {

            using (_connection)
            {
                _connection.Open();
                string insertString = @"INSERT INTO GAME(Name,ReleaseYear,Genre,
                                        CreationDate,ImageURL,GameInfo,Rating) VALUES(
                                        @Name,@ReleaseYear,GETDATE(),@ImageUrl,@GameInfo,@Rating)";

                command.CommandText = insertString;

                command.Parameters.Add("@Name", game.Name);
                command.Parameters.Add("@ReleaseYear", game.ReleaseYear);
                command.Parameters.Add("@Genre", game.Genre);
                command.Parameters.Add("@Rating", game.Rating);
                command.Parameters.Add("@GameInfo", game.GameInfo);
                command.Parameters.Add("@ImageUrl", game.ImageUrl);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void UpdateGameById(Game game)
        {

            using (_connection)
            {
                _connection.Open();
                string updateString = @"UPDATE GAME SET Name = @Name,ReleaseYear = @ReleaseYear,
                                                    Genre = @Genre,Rating = @Rating
                                                    GaneInfo = @GameInfo,ImageURL = @ImageUrl
                                                    WHERE GameId = @GameId";
                command.CommandText = updateString;

                command.Parameters.Add("@GameId", game.GameId);
                command.Parameters.Add("@Name", game.Name);
                command.Parameters.Add("@ReleaseYear", game.ReleaseYear);
                command.Parameters.Add("@Genre", game.Genre);
                command.Parameters.Add("@Rating", game.Rating);
                command.Parameters.Add("@GameInfo", game.GameInfo);
                command.Parameters.Add("@ImageUrl", game.ImageUrl);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void DeleteGame(int id)
        {
            using (_connection)
            {
                _connection.Open();

                string deleteString = "DELETE FROM GAME WHERE GameID = @GameId";

                command.CommandText = deleteString;
                command.Parameters.Add("@GameId", id);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }
    }
}
