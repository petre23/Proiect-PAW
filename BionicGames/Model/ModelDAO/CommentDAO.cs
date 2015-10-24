using Model.ModelBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDAO
{
    public class CommentDAO:BaseDAO
    {
        public CommentDAO() : base() { }

        public void InsertComment(Comment comment)
        {
            using (_connection)
            {
                _connection.Open();
                string insertString = @"INSERT INTO COMMENT(UserId,GameId,CommentText) VALUES(@UserId,@GameId,@CommentText)";
                command.CommandText = insertString;
                command.Parameters.Add("@UserId", comment.UserId);
                command.Parameters.Add("@GameId", comment.GameId);
                command.Parameters.Add("@CommentText", comment.CommentText);
                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void UpdateComment(Comment comment)
        {
            using (_connection)
            {
                _connection.Open();
                string insertString = @"UPDATE COMMENT SET 
                                            CommentText = @CommentText
                                            WHERE GameId = @GameId AND UserId = @UserId";
                command.CommandText = insertString;

                command.Parameters.Add("@GameId", comment.GameId);
                command.Parameters.Add("@CommentText", comment.CommentText);
                command.Parameters.Add("@UserId", comment.UserId);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public void DeleteComment(Comment comment)
        {
            using (_connection)
            {
                _connection.Open();
                string deleteString = @"DELETE FROM COMMENT WHERE GameId = @GameId AND UserId = @UserId";
                command.CommandText = deleteString;

                command.Parameters.Add("@GameId", comment.GameId);
                command.Parameters.Add("@UserId", comment.UserId);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public Comment GetCommentByUser(int gameId, string userId)
        {
            Comment comment = new Comment();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM COMMENT WHERE GameId = @GameId AND UserId = @UserId";

                command.CommandText = selectString;
                command.Parameters.Add("@GameId", gameId);
                command.Parameters.Add("@UserId", userId);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    comment.CommentText = reader["CommentText"].ToString();
                }
                reader.Close();

                _connection.Close();
            }
            return comment;
        }

        public List<Comment> GetAllCommentsForGame(int gameId)
        {
            List<Comment> commentList = new List<Comment>();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM COMMENT where GameId = @GameId";

                command.CommandText = selectString;
                command.Parameters.Add("@GameId",gameId);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return null;

                while (reader.Read())
                {
                    Comment comment = new Comment();
                    comment.UserId = reader["UserId"].ToString();
                    comment.CommentText = reader["CommentText"].ToString();

                    commentList.Add(comment);
                }
                reader.Close();
                _connection.Close();
            }
            return commentList;
        }
    }
}
