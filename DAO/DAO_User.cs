using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOM;

namespace DAO
{
    public class DAO_User
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionStringCopy);

        public List<User> LoadAllFromDB()
        {
            try
            {
                DataTable dtUsers = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Users", connection);
                adp.Fill(dtUsers);
                List<User> users = new List<User>();
                foreach (DataRow row in dtUsers.Rows)
                {
                    User user = new User();
                    user.UserID = Convert.ToInt32(row["UserID"]);
                    user.Password = row["Password"].ToString();
                    user.Role = Convert.ToInt32(row["Role"]);
                    user.IsActive = Convert.ToInt32(row["IsActive"]);
                    user.IsLogged = Convert.ToInt32(row["IsLogged"]);
                    user.HasChangedPassword = Convert.ToInt32(row["HasChangedPassword"]);
                    user.Name = row["Name"].ToString();
                    user.IDCard = row["IDCard"].ToString();
                    user.PasswordInitials = row["PasswordInitials"].ToString();
                    users.Add(user);
                }
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveToDB(User user)
        {
            try
            {
                SqlCommand insertUser = new SqlCommand();
                insertUser.Connection = connection;
                insertUser.CommandText = "INSERT INTO [Users] ([Password], [Role], [IsActive], [IsLogged], [HasChangedPassword], [Name], [IDCard], [PasswordInitials]) VALUES (@Password, @Role, @IsActive, @IsLogged, @HasChangedPassword, @Name, @IDCard, @PasswordInitials)";
                insertUser.Parameters.AddWithValue("@Password", user.Password);
                insertUser.Parameters.AddWithValue("@Role", user.Role);
                insertUser.Parameters.AddWithValue("@IsActive", user.IsActive);
                insertUser.Parameters.AddWithValue("@IsLogged", user.IsLogged);
                insertUser.Parameters.AddWithValue("@HasChangedPassword", user.HasChangedPassword);
                insertUser.Parameters.AddWithValue("@Name", user.Name);
                insertUser.Parameters.AddWithValue("@IDCard", user.IDCard);
                insertUser.Parameters.AddWithValue("@PasswordInitials", user.PasswordInitials);

                connection.Open();
                insertUser.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateToDB(User user)
        {
            try
            {
                SqlCommand updateUser = new SqlCommand();
                updateUser.Connection = connection;
                if(user.Password != "")
                {
                    updateUser.CommandText = "UPDATE Users SET Password = @Password, Role = @Role, IsActive = @IsActive, IsLogged = @IsLogged, HasChangedPassword = @HasChangedPassword, Name = @Name, PasswordInitials = @PasswordInitials WHERE UserID = @UserID";
                    updateUser.Parameters.AddWithValue("@Password", user.Password);
                    updateUser.Parameters.AddWithValue("@PasswordInitials", user.PasswordInitials);
                } else
                {
                    updateUser.CommandText = "UPDATE Users SET Role = @Role, IsActive = @IsActive, IsLogged = @IsLogged, HasChangedPassword = @HasChangedPassword, Name = @Name WHERE UserID = @UserID";
                }
                
                updateUser.Parameters.AddWithValue("@UserID", user.UserID);
                updateUser.Parameters.AddWithValue("@Role", user.Role);
                updateUser.Parameters.AddWithValue("@IsActive", user.IsActive);
                updateUser.Parameters.AddWithValue("@IsLogged", user.IsLogged);
                updateUser.Parameters.AddWithValue("@HasChangedPassword", user.HasChangedPassword);
                updateUser.Parameters.AddWithValue("@Name", user.Name);

                connection.Open();
                updateUser.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteFromDB(User user)
        {
            try
            {
                SqlCommand deleteUser = new SqlCommand();
                deleteUser.Connection = connection;
                deleteUser.CommandText = "DELETE FROM Users WHERE UserID = @UserID";
                deleteUser.Parameters.AddWithValue("@UserID", user.UserID);

                connection.Open();
                deleteUser.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User SearchByID(string IDCard)
        {
            try
            {
                DataTable dtUsers = new DataTable();
                string query = "SELECT * FROM Users WHERE IDCard = @IDCard";
                SqlDataAdapter adp = new SqlDataAdapter(query, connection);
                adp.SelectCommand.Parameters.AddWithValue("@IDCard", IDCard);
                adp.Fill(dtUsers);
                if (dtUsers.Rows.Count > 0)
                {
                    User user = new User();
                    DataRow row = dtUsers.Rows[0];
                    user.UserID = Convert.ToInt32(row["UserID"]);
                    user.Password = row["Password"].ToString();
                    user.Role = Convert.ToInt32(row["Role"]);
                    user.IsActive = Convert.ToInt32(row["IsActive"]);
                    user.IsLogged = Convert.ToInt32(row["IsLogged"]);
                    user.HasChangedPassword = Convert.ToInt32(row["HasChangedPassword"]);
                    user.Name = row["Name"].ToString();
                    user.IDCard = row["IDCard"].ToString();
                    user.PasswordInitials = row["PasswordInitials"].ToString();

                    return user;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User SearchByID(int id)
        {
            try
            {
                DataTable dtUsers = new DataTable();
                string query = "SELECT * FROM Users WHERE UserID = @id";
                SqlDataAdapter adp = new SqlDataAdapter(query, connection);
                adp.SelectCommand.Parameters.AddWithValue("@id", id);
                adp.Fill(dtUsers);
                if (dtUsers.Rows.Count > 0)
                {
                    User user = new User();
                    DataRow row = dtUsers.Rows[0];
                    user.UserID = Convert.ToInt32(row["UserID"]);
                    user.Password = row["Password"].ToString();
                    user.Role = Convert.ToInt32(row["Role"]);
                    user.IsActive = Convert.ToInt32(row["IsActive"]);
                    user.IsLogged = Convert.ToInt32(row["IsLogged"]);
                    user.HasChangedPassword = Convert.ToInt32(row["HasChangedPassword"]);
                    user.Name = row["Name"].ToString();
                    user.IDCard = row["IDCard"].ToString();
                    user.PasswordInitials = row["PasswordInitials"].ToString();

                    return user;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeactivateUser(int userID)
        {
            try
            {
                SqlCommand deactivateUser = new SqlCommand();
                deactivateUser.Connection = connection;
                deactivateUser.CommandText = "UPDATE Users SET IsActive = 0 WHERE UserID = @UserID";
                deactivateUser.Parameters.AddWithValue("@UserID", userID);

                connection.Open();
                deactivateUser.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActivateUser(int userID)
        {
            try
            {
                SqlCommand activateUser = new SqlCommand();
                activateUser.Connection = connection;
                activateUser.CommandText = "UPDATE Users SET IsActive = 1 WHERE UserID = @UserID";
                activateUser.Parameters.AddWithValue("@UserID", userID);

                connection.Open();
                activateUser.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LogoutUser(int userID)
        {
            try
            {
                SqlCommand logoutUser = new SqlCommand();
                logoutUser.Connection = connection;
                logoutUser.CommandText = "UPDATE Users SET IsLogged = 0 WHERE UserID = @UserID";
                logoutUser.Parameters.AddWithValue("@UserID", userID);

                connection.Open();
                logoutUser.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User AuthenticateUser(string IDCard, string password)
        {
            try
            {
                SqlCommand authenticateUser = new SqlCommand();
                authenticateUser.Connection = connection;
                authenticateUser.CommandText = "SELECT UserID FROM Users WHERE IDCard = @IDCard AND Password = @Password AND IsActive = 1";
                authenticateUser.Parameters.AddWithValue("@IDCard", IDCard);
                authenticateUser.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SqlDataReader reader = authenticateUser.ExecuteReader();
                int userID = 0;
                bool isAuthenticated = false;
                if (reader.Read())
                {
                    userID = reader.GetInt32(0);
                    isAuthenticated = true;
                }
                connection.Close();

                if (isAuthenticated)
                {
                    // Update IsLogged to 1
                    SqlCommand updateIsLogged = new SqlCommand();
                    updateIsLogged.Connection = connection;
                    updateIsLogged.CommandText = "UPDATE Users SET IsLogged = 1 WHERE UserID = @UserID";
                    updateIsLogged.Parameters.AddWithValue("@UserID", userID);
                    connection.Open();
                    updateIsLogged.ExecuteNonQuery();
                    connection.Close();
                    return SearchByID(userID);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
