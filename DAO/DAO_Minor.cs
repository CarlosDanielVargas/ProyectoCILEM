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
                insert.CommandText = "INSERT INTO Minors(MinorID, Name, BirthDate, EnteredDate, GraduationDate, Gender, RecommendationMethod, Residency) VALUES @MinorID, @Name, @BirthDate, @EnteredDate, @GraduationDate, @Gender, @RecommendationMethod, @Residency";
                insert.Parameters.AddWithValue("@MinorID", minor.MinorID);
                insert.Parameters.AddWithValue("@Name", minor.Name);
                insert.Parameters.AddWithValue("@BirthDate", minor.BirthDate);
                insert.Parameters.AddWithValue("@EnteredDate", minor.EnteredDate);
                insert.Parameters.AddWithValue("@GraduationDate", minor.GraduationDate);
                insert.Parameters.AddWithValue("@Gender", minor.Gender);
                insert.Parameters.AddWithValue("@RecommendationMethod", minor.RecommendationMethod);
                insert.Parameters.AddWithValue("@Residency", minor.Residency);

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
                update.CommandText = "UPDATE Minors SET Name = @Name, BirthDate = @BirthDate, EnteredDate = @EnteredDate, GraduationDate = @GraduationDate, Gender = @Gender, RecommendationMethod = @RecommendationMethod, Residency = @Residency WHERE MinorID = @MinorID";
                update.Parameters.AddWithValue("@MinorID", minor.MinorID);
                update.Parameters.AddWithValue("@Name", minor.Name);
                update.Parameters.AddWithValue("@BirthDate", minor.BirthDate);
                update.Parameters.AddWithValue("@EnteredDate", minor.EnteredDate);
                update.Parameters.AddWithValue("@GraduationDate", minor.GraduationDate);
                update.Parameters.AddWithValue("@Gender", minor.Gender);
                update.Parameters.AddWithValue("@RecommendationMethod", minor.RecommendationMethod);
                update.Parameters.AddWithValue("@Residency", minor.Residency);

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

        public List<Minor> searchByID(string id)
        {
            try
            {
                DataTable dtMinors = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Minors WHERE MinorID = " + id, connection);
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
                    minors.Add(minor);
                }
                return minors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<Minor> searchByGender(string gender)
        {
            try
            {
                DataTable dtMinors = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Minors WHERE Gender = " + gender, connection);
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
