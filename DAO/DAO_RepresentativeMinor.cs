using DOM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_RepresentativeMinor
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public List<RepresentativeMinor> loadAllFromDB()
        {
            try
            {
                string query = "SELECT * FROM RepresentativeMinors";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtRepresentativeMinors = new DataTable();
                adapter.Fill(dtRepresentativeMinors);

                List<RepresentativeMinor> representativeMinors = new List<RepresentativeMinor>();
                foreach (DataRow row in dtRepresentativeMinors.Rows)
                {
                    RepresentativeMinor representativeMinor = new RepresentativeMinor();
                    representativeMinor.RepresentativeID = row["RepresentativeID"].ToString();
                    representativeMinor.MinorID = row["MinorID"].ToString();
                    representativeMinor.Relationship = row["Relationship"].ToString();
                    representativeMinors.Add(representativeMinor);
                }

                return representativeMinors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(RepresentativeMinor representativeMinor)
        {
            try
            {
                string query = "INSERT INTO RepresentativeMinors (RepresentativeID, MinorID, Relationship) VALUES (@RepresentativeID, @MinorID, @Relationship)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RepresentativeID", representativeMinor.RepresentativeID);
                command.Parameters.AddWithValue("@MinorID", representativeMinor.MinorID);
                command.Parameters.AddWithValue("@Relationship", representativeMinor.Relationship);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateToDB(RepresentativeMinor representativeMinor)
        {
            try
            {
                string query = "UPDATE RepresentativeMinors SET Relationship = @Relationship WHERE RepresentativeID = @RepresentativeID AND MinorID = @MinorID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Relationship", representativeMinor.Relationship);
                command.Parameters.AddWithValue("@RepresentativeID", representativeMinor.RepresentativeID);
                command.Parameters.AddWithValue("@MinorID", representativeMinor.MinorID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteFromDB(RepresentativeMinor representativeMinor)
        {
            try
            {
                string query = "DELETE FROM RepresentativeMinors WHERE RepresentativeID = @RepresentativeID AND MinorID = @MinorID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RepresentativeID", representativeMinor.RepresentativeID);
                command.Parameters.AddWithValue("@MinorID", representativeMinor.MinorID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RepresentativeMinor> searchByMinor(string minorID)
        {
            try
            {
                string query = "SELECT * FROM RepresentativeMinors WHERE MinorID = @MinorID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MinorID", minorID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtRepresentativeMinors = new DataTable();
                adapter.Fill(dtRepresentativeMinors);

                List<RepresentativeMinor> representativeMinors = new List<RepresentativeMinor>();
                foreach (DataRow row in dtRepresentativeMinors.Rows)
                {
                    RepresentativeMinor representativeMinor = new RepresentativeMinor();
                    representativeMinor.RepresentativeID = row["RepresentativeID"].ToString();
                    representativeMinor.MinorID = row["MinorID"].ToString();
                    representativeMinor.Relationship = row["Relationship"].ToString();
                    representativeMinors.Add(representativeMinor);
                }

                return representativeMinors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RepresentativeMinor> searchByRepresentative(string representativeID)
        {
            try
            {
                string query = "SELECT * FROM RepresentativeMinors WHERE RepresentativeID = @RepresentativeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RepresentativeID", representativeID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtRepresentativeMinors = new DataTable();
                adapter.Fill(dtRepresentativeMinors);

                List<RepresentativeMinor> representativeMinors = new List<RepresentativeMinor>();
                foreach (DataRow row in dtRepresentativeMinors.Rows)
                {
                    RepresentativeMinor representativeMinor = new RepresentativeMinor();
                    representativeMinor.RepresentativeID = row["RepresentativeID"].ToString();
                    representativeMinor.MinorID = row["MinorID"].ToString();
                    representativeMinor.Relationship = row["Relationship"].ToString();
                    representativeMinors.Add(representativeMinor);
                }

                return representativeMinors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public RepresentativeMinor searchInDB(string representativeID, string minorID)
        {
            try
            {
                string query = "SELECT * FROM RepresentativeMinors WHERE RepresentativeID = @RepresentativeID AND MinorID = @MinorID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RepresentativeID", representativeID);
                command.Parameters.AddWithValue("@MinorID", minorID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtRepresentativeMinors = new DataTable();
                adapter.Fill(dtRepresentativeMinors);

                RepresentativeMinor representativeMinor = new RepresentativeMinor();
                foreach (DataRow row in dtRepresentativeMinors.Rows)
                {
                    representativeMinor.RepresentativeID = row["RepresentativeID"].ToString();
                    representativeMinor.MinorID = row["MinorID"].ToString();
                    representativeMinor.Relationship = row["Relationship"].ToString();
                }

                return representativeMinor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
