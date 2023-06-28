using DOM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Level
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionStringCopy);

        public List<Level> loadAllFromDB()
        {
            try
            {
                DataTable dtLevels = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Levels", connection);
                adp.Fill(dtLevels);
                List<Level> levels = new List<Level>();
                foreach (DataRow row in dtLevels.Rows)
                {
                    Level level = new Level();
                    level.LevelID = Int32.Parse(row["LevelID"].ToString());
                    level.Name = row["Name"].ToString();
                    levels.Add(level);
                }
                return levels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(Level level)
        {
            try
            {
                SqlCommand insert = new SqlCommand();
                insert.Connection = connection;
                insert.CommandText = "INSERT INTO Levels(Name) VALUES (@Name); SELECT SCOPE_IDENTITY()";
                insert.Parameters.AddWithValue("@Name", level.Name);

                connection.Open();
                level.LevelID = Convert.ToInt32(insert.ExecuteScalar());
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateInDB(Level level)
        {
            try
            {
                SqlCommand update = new SqlCommand();
                update.Connection = connection;
                update.CommandText = "UPDATE Levels SET Name = @Name WHERE LevelID = @LevelID";
                update.Parameters.AddWithValue("@LevelID", level.LevelID);
                update.Parameters.AddWithValue("@Name", level.Name);
                connection.Open();
                update.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteFromDB(int levelID)
        {
            try
            {
                SqlCommand delete = new SqlCommand();
                delete.Connection = connection;
                delete.CommandText = "DELETE FROM Levels WHERE LevelID = @LevelID";
                delete.Parameters.AddWithValue("@LevelID", levelID);
                connection.Open();
                delete.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Level loadFromDB(int levelID)
        {
            try
            {
                SqlCommand select = new SqlCommand();
                select.Connection = connection;
                select.CommandText = "SELECT * FROM Levels WHERE LevelID = @LevelID";
                select.Parameters.AddWithValue("@LevelID", levelID);
                SqlDataAdapter adp = new SqlDataAdapter(select);
                DataTable dtLevel = new DataTable();
                adp.Fill(dtLevel);
                Level level = new Level();
                level.LevelID = Int32.Parse(dtLevel.Rows[0]["LevelID"].ToString());
                level.Name = dtLevel.Rows[0]["Name"].ToString();
                return level;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Level> searchFromDB(string keyword)
        {
            try
            {
                SqlCommand select = new SqlCommand();
                select.Connection = connection;
                select.CommandText = "SELECT * FROM Levels WHERE Name LIKE @Keyword";
                select.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataAdapter adp = new SqlDataAdapter(select);
                DataTable dtLevels = new DataTable();
                adp.Fill(dtLevels);
                List<Level> levels = new List<Level>();
                foreach (DataRow row in dtLevels.Rows)
                {
                    Level level = new Level();
                    level.LevelID = Int32.Parse(row["LevelID"].ToString());
                    level.Name = row["Name"].ToString();
                    levels.Add(level);
                }
                return levels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
