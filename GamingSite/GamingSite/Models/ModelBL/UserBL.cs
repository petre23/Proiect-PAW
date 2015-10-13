using GamingSite.Models.ModelBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace GamingSite.Models.ModelBL
{
    public class UserBL:BaseBL
    {
        public UserBL() : base() { }

        public bool InsertUser(User usr)
        {
            try
            {
                using (_connection)
                {
                    _connection.Open();
                    string insertString = "INSERT INTO SYS_USER(Username,Password) VALUES(@Username,@Password)";
                    command.CommandText = insertString;

                    usr.Password = Sha256Encrypt(usr.Password);

                    command.Parameters.Add("@Username", usr.Username);
                    command.Parameters.Add("@Password", usr.Password);

                    command.ExecuteNonQuery();

                    _connection.Close();
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void UpdatetUser(User usr)
        {
            using (_connection) 
            {
                _connection.Open();
                string updateString = "UPDATE SYS_USER SET UserNmae = @Username,Password = @Password";
                command.CommandText = updateString;

                usr.Password = Sha256Encrypt(usr.Password);

                command.Parameters.Add("@Username",usr.Username);
                command.Parameters.Add("@Password",usr.Password);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }

        public string Sha256Encrypt(string text)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();

            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(text));

            String retValue = Convert.ToBase64String(hashedDataBytes);

            return retValue;
        }

        public void DeleteUser(User usr)
        {
            using (_connection)
            {
                _connection.Open();
                string deleteString = "DELETE FROM SYS_USER WHERE UserNmae = @Username";
                command.CommandText = deleteString;

                command.Parameters.Add("@Username", usr.Username);

                command.ExecuteNonQuery();

                _connection.Close();
            }
        }


        public bool SuccesfullLogin(User usr)
        {
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM SYS_USER WHERE Username = @Username AND Password = @Password";
                command.CommandText = selectString;

                usr.Password = Sha256Encrypt(usr.Password);

                command.Parameters.Add("@Username",usr.Username);
                command.Parameters.Add("@Password", usr.Password);

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                    return true;

                reader.Close();
                _connection.Close();
            }
            return false;
        }

        public bool GetAdminStatus(string username) 
        {
            if (string.IsNullOrEmpty(username))
                return false;

            using (_connection)
            {
                _connection.Open();

                string selectString = "SELECT Admin FROM SYS_USER WHERE Username = @Username";
                command.CommandText = selectString;

                var reader = command.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read())
                        return Convert.ToBoolean(reader["Admin"]);
                    reader.Close();
                }

                _connection.Close();
            }
            return false;
        }

        public List<User> GetAllUsers() 
        {
            List<User> userList = new List<User>();
            using (_connection)
            {
                _connection.Open();
                string selectString = "SELECT * FROM SYS_USER";
                command.CommandText = selectString;
                var reader = command.ExecuteReader();

                if (reader.HasRows) 
                {
                    while (reader.Read()) 
                    {
                        User user = new User();
                        user.Username = reader["Username"].ToString();
                        user.IsAdmin = Convert.ToBoolean(reader["Admin"]);
                        userList.Add(user);
                    }
                    reader.Close();
                }
                _connection.Close();
            }
            return userList;
        }

    }
}