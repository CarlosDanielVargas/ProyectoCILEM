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
                    minor.EnteredDate = Convert.ToDateTime(row["EnterDate"]);
                    minor.GraduationDate = Convert.ToDateTime(row["LeaveDate"]);
                    minor.Gender = row["Gender"].ToString();
                    minor.HasSchoolarship = row["HasSchoolarship"].ToString();
                    minor.RecommendationMethod = row["RecommendationMethod"].ToString();
                    minor.Residency = row["Residency"].ToString();
                    minor.LevelID = Int32.Parse(row["LevelID"].ToString());
                    minor.CurrentPayment = Convert.ToDouble(row["CurrentPayment"]);

                    // Get Level
                    DAO_Level daoLevel = new DAO_Level();
                    minor.Level = daoLevel.loadFromDB(minor.LevelID);

                    // Get Representatives
                    DAO_Representative DAO_Representative = new DAO_Representative();
                    minor.Representatives = DAO_Representative.searchRepresentativesByMinorID(minor.MinorID);
                    minors.Add(minor);

                    // Get RepresentativeMinors
                    DAO_RepresentativeMinor DAO_RepresentativeMinor = new DAO_RepresentativeMinor();
                    minor.RepresentativeMinors = DAO_RepresentativeMinor.searchByMinor(minor.MinorID);

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
                // Minor insertion to DB
                SqlCommand insertMinor = new SqlCommand();
                insertMinor.Connection = connection;
                insertMinor.CommandText = "INSERT INTO [Minors] ([MinorID], [Name], [BirthDate], [EnterDate], [LeaveDate], [Residency], [Gender], [HasSchoolarship], [LevelID], [CurrentPayment], [RecommendationMethod]) VALUES (@MinorID, @Name, @BirthDate, @EnterDate, @LeaveDate, @Residency, @Gender, @HasSchoolarship, @LevelID, @CurrentPayment, @RecommendationMethod)";
                insertMinor.Parameters.AddWithValue("@MinorID", minor.MinorID);
                insertMinor.Parameters.AddWithValue("@Name", minor.Name);
                insertMinor.Parameters.AddWithValue("@BirthDate", minor.BirthDate);
                insertMinor.Parameters.AddWithValue("@EnterDate", minor.EnteredDate);
                insertMinor.Parameters.AddWithValue("@LeaveDate", minor.GraduationDate);
                insertMinor.Parameters.AddWithValue("@Gender", minor.Gender);
                insertMinor.Parameters.AddWithValue("@RecommendationMethod", minor.RecommendationMethod);
                insertMinor.Parameters.AddWithValue("@Residency", minor.Residency);
                insertMinor.Parameters.AddWithValue("@HasSchoolarship", minor.HasSchoolarship);
                insertMinor.Parameters.AddWithValue("@LevelID", minor.LevelID);
                insertMinor.Parameters.AddWithValue("@CurrentPayment", minor.CurrentPayment);

                connection.Open();
                insertMinor.ExecuteNonQuery();
                connection.Close();

                //Creation and insertion representativeMinors to DB
                List<RepresentativeMinor> representativeMinors = minor.RepresentativeMinors;
                foreach (RepresentativeMinor representativeMinor in representativeMinors)
                {
                    SqlCommand insertRepresentativeMinors = new SqlCommand();
                    insertRepresentativeMinors.Connection = connection;
                    insertRepresentativeMinors.CommandText = "INSERT INTO RepresentativeMinors(MinorID, RepresentativeID, Relationship) VALUES (@MinorID, @RepresentativeID, @Relationship)";
                    insertRepresentativeMinors.Parameters.AddWithValue("@MinorID", minor.MinorID);
                    insertRepresentativeMinors.Parameters.AddWithValue("@RepresentativeID", representativeMinor.RepresentativeID);
                    insertRepresentativeMinors.Parameters.AddWithValue("@Relationship", representativeMinor.Relationship);

                    connection.Open();
                    insertRepresentativeMinors.ExecuteNonQuery();

                    connection.Close();
                }
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
                update.CommandText = "UPDATE Minors SET Name = @Name, BirthDate = @BirthDate, EnterDate = @EnteredDate, LeaveDate = @GraduationDate, Gender = @Gender, Residency = @Residency, LevelID = @LevelID, RecommendationMethod = @RecommendationMethod WHERE MinorID = @MinorID";
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

                //Creation and insertion representativeMinors to DB
                List<RepresentativeMinor> representativeMinors = minor.RepresentativeMinors;
                SqlCommand insertRepresentativeMinors = new SqlCommand();
                insertRepresentativeMinors.Connection = connection;
                insertRepresentativeMinors.CommandText = "INSERT INTO RepresentativeMinors(MinorID, RepresentativeID, Relationship) VALUES (@MinorID, @RepresentativeID, @Relationship)";
                foreach (RepresentativeMinor representativeMinor in representativeMinors)
                {
                    insertRepresentativeMinors.Parameters.AddWithValue("@MinorID", minor.MinorID);
                    insertRepresentativeMinors.Parameters.AddWithValue("@RepresentativeID", representativeMinor.RepresentativeID);
                    insertRepresentativeMinors.Parameters.AddWithValue("@Relationship", representativeMinor.Relationship);

                    connection.Open();
                    insertRepresentativeMinors.ExecuteNonQuery();

                    connection.Close();
                }

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

                // Delete representativeMinors
                SqlCommand deleteRepresentativeMinors = new SqlCommand();
                deleteRepresentativeMinors.Connection = connection;
                deleteRepresentativeMinors.CommandText = "DELETE FROM RepresentativeMinors WHERE MinorID = @MinorID";
                deleteRepresentativeMinors.Parameters.AddWithValue("@MinorID", minor.MinorID);

                connection.Open();
                deleteRepresentativeMinors.ExecuteNonQuery();
                connection.Close();

                // Delete minor
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
                    query += " AND MinorID = '" + id + "'";
                if (!string.IsNullOrEmpty(name))
                    query += " AND Name = '" + name + "'";
                if (!string.IsNullOrEmpty(gender))
                    query += " AND Gender = '" + gender + "'";
                if (!string.IsNullOrEmpty(recommendationMethod))
                    query += " AND RecommendationMethod = '" + recommendationMethod + "'";
                if (levelID != 0)
                    query += " AND LevelID = '" + levelID + "'";

                SqlDataAdapter adp = new SqlDataAdapter(query, connection);
                adp.Fill(dtMinors);
                List<Minor> minors = new List<Minor>();
                foreach (DataRow row in dtMinors.Rows)
                {
                    Minor minor = new Minor();
                    minor.MinorID = row["MinorID"].ToString();
                    minor.Name = row["Name"].ToString();
                    minor.BirthDate = Convert.ToDateTime(row["BirthDate"]);
                    minor.EnteredDate = Convert.ToDateTime(row["EnterDate"]);
                    minor.GraduationDate = Convert.ToDateTime(row["LeaveDate"]);
                    minor.Gender = row["Gender"].ToString();
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
            SELECT *
            FROM Representatives r
            INNER JOIN RepresentativeMinors rm ON r.RepresentativeID = rm.RepresentativeID
            INNER JOIN Minors m ON rm.MinorID = m.MinorID
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
                    minor.EnteredDate = Convert.ToDateTime(row["EnterDate"]);
                    minor.GraduationDate = Convert.ToDateTime(row["LeaveDate"]);
                    minor.Gender = row["Gender"].ToString();
                    minor.RecommendationMethod = row["RecommendationMethod"].ToString();
                    minor.Relationship = row["Relationship"].ToString();
                    minor.Residency = row["Residency"].ToString();
                    minor.LevelID = Int32.Parse(row["LevelID"].ToString());

                    // Get level
                    Level level = new Level();
                    DAO_Level daoLevel = new DAO_Level();
                    level = daoLevel.loadFromDB(minor.LevelID);
                    minor.Level = level;
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
