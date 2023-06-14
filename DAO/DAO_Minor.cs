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
    public class DAO_Minor
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public List<Minor> loadAllFromDB()
        {
            try
            {
                DataTable dtMinors = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Minors", connection);
                adp.Fill(dtMinors);
                List<Minor> minors = new List<Minor>();
                foreach (DataRow row in dtMinors.Rows)
                {
                    Minor minor = new Minor();
                    minor.MinorID = row["MinorID"].ToString();
                    minor.Name = row["Name"].ToString();
                    minor.BirthDate = Convert.ToDateTime(row["BirthDate"]);
                    minor.EnteredDate = Convert.ToDateTime(row["EnteredDate"]);
                    minor.GraduationDate = Convert.ToDateTime(row["GraduationDate"]);
                    minor.Gender = Convert.ToChar(row["Gender"]);
                    minor.RecommendationMethod = row["RecomendationMethod"].ToString();
                    minor.Residency = row["Residency"].ToString();
                    minor.LevelID = Int32.Parse(row["LevelID"].ToString());
                    minors.Add(minor);
                }
                return minors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(Minor minor)
        {
            try
            {
                SqlCommand insert = new SqlCommand();
                insert.Connection = connection;
                insert.CommandText = "INSERT INTO Minors(MinorID, Name, BirthDate, EnteredDate, GraduationDate, Gender, RecommendationMethod, Residency, LevelID, HasSchoolarship) VALUES @MinorID, @Name, @BirthDate, @EnteredDate, @GraduationDate, @Gender, @RecommendationMethod, @Residency, @LevelID, @HasSchoolarship";
                insert.Parameters.AddWithValue("@MinorID", minor.MinorID);
                insert.Parameters.AddWithValue("@Name", minor.Name);
                insert.Parameters.AddWithValue("@BirthDate", minor.BirthDate);
                insert.Parameters.AddWithValue("@EnteredDate", minor.EnteredDate);
                insert.Parameters.AddWithValue("@GraduationDate", minor.GraduationDate);
                insert.Parameters.AddWithValue("@Gender", minor.Gender);
                insert.Parameters.AddWithValue("@RecommendationMethod", minor.RecommendationMethod);
                insert.Parameters.AddWithValue("@Residency", minor.Residency);
                insert.Parameters.AddWithValue("@LevelID", minor.LevelID);
                insert.Parameters.AddWithValue("@HasSchoolarship", minor.HasSchoolarship);

                connection.Open();
                insert.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateToDB(Minor minor)
        {
            try
            {
                SqlCommand update = new SqlCommand();
                update.Connection = connection;
                update.CommandText = "UPDATE Minors SET Name = @Name, BirthDate = @BirthDate, EnteredDate = @EnteredDate, GraduationDate = @GraduationDate, Gender = @Gender, RecommendationMethod = @RecommendationMethod, Residency = @Residency, LevelID = @LevelID WHERE MinorID = @MinorID";
                update.Parameters.AddWithValue("@MinorID", minor.MinorID);
                update.Parameters.AddWithValue("@Name", minor.Name);
                update.Parameters.AddWithValue("@BirthDate", minor.BirthDate);
                update.Parameters.AddWithValue("@EnteredDate", minor.EnteredDate);
                update.Parameters.AddWithValue("@GraduationDate", minor.GraduationDate);
                update.Parameters.AddWithValue("@Gender", minor.Gender);
                update.Parameters.AddWithValue("@RecommendationMethod", minor.RecommendationMethod);
                update.Parameters.AddWithValue("@Residency", minor.Residency);
                update.Parameters.AddWithValue("@LevelID", minor.LevelID);

                connection.Open();
                update.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteFromDB(Minor minor)
        {
            try
            {
                SqlCommand delete = new SqlCommand();
                delete.Connection = connection;
                delete.CommandText = "DELETE FROM Minors WHERE MinorID = @MinorID";
                delete.Parameters.AddWithValue("@MinorID", minor.MinorID);

                connection.Open();
                delete.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Minor> searchBy(string id, string name, string gender, string recommendationMethod, int levelID)
        {
            try
            {
                DataTable dtMinors = new DataTable();
                string query = "SELECT * FROM Minors WHERE 1=1";

                // Add conditions based on the provided parameters
                if (!string.IsNullOrEmpty(id))
                    query += " AND MinorID = " + id;
                if (!string.IsNullOrEmpty(name))
                    query += " AND Name = '" + name + "'";
                if (!string.IsNullOrEmpty(gender))
                    query += " AND Gender = '" + gender + "'";
                if (!string.IsNullOrEmpty(recommendationMethod))
                    query += " AND RecommendationMethod = '" + recommendationMethod + "'";
                if (levelID != 0)
                    query += " AND LevelID = " + levelID;

                SqlDataAdapter adp = new SqlDataAdapter(query, connection);
                adp.Fill(dtMinors);
                List<Minor> minors = new List<Minor>();
                foreach (DataRow row in dtMinors.Rows)
                {
                    Minor minor = new Minor();
                    minor.MinorID = row["MinorID"].ToString();
                    minor.Name = row["Name"].ToString();
                    minor.BirthDate = Convert.ToDateTime(row["BirthDate"]);
                    minor.EnteredDate = Convert.ToDateTime(row["EnteredDate"]);
                    minor.GraduationDate = Convert.ToDateTime(row["GraduationDate"]);
                    minor.Gender = Convert.ToChar(row["Gender"]);
                    minor.RecommendationMethod = row["RecommendationMethod"].ToString();
                    minor.Residency = row["Residency"].ToString();
                    minor.LevelID = Int32.Parse(row["LevelID"].ToString());
                    minors.Add(minor);
                }
                return minors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Minor> searchMinorsByRepresentativeID(string representativeID)
        {
            try
            {
                DataTable dtMinors = new DataTable();
                string query = @"
            SELECT m.*
            FROM Representative r
            INNER JOIN RepresentativeMinors rm ON r.RepresentativeID = rm.RepresentativeID
            INNER JOIN Minor m ON rm.MinorID = m.MinorID
            WHERE r.RepresentativeID = @RepresentativeID";

                SqlDataAdapter adp = new SqlDataAdapter(query, connection);
                adp.SelectCommand.Parameters.AddWithValue("@RepresentativeID", representativeID);
                adp.Fill(dtMinors);

                List<Minor> minors = new List<Minor>();
                foreach (DataRow row in dtMinors.Rows)
                {
                    Minor minor = new Minor();
                    minor.MinorID = row["MinorID"].ToString();
                    minor.Name = row["Name"].ToString();
                    minor.BirthDate = Convert.ToDateTime(row["BirthDate"]);
                    minor.EnteredDate = Convert.ToDateTime(row["EnteredDate"]);
                    minor.GraduationDate = Convert.ToDateTime(row["GraduationDate"]);
                    minor.Gender = Convert.ToChar(row["Gender"]);
                    minor.RecommendationMethod = row["RecommendationMethod"].ToString();
                    minor.Residency = row["Residency"].ToString();
                    minor.LevelID = Int32.Parse(row["LevelID"].ToString());

                    minors.Add(minor);
                }

                return minors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
