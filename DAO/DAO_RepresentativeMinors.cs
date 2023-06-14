using DOM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_RepresentativeMinors
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void saveToDB(string minorID, string representativeID, string relationship)
        {
            try
            {
                SqlCommand insert = new SqlCommand();
                insert.Connection = connection;
                insert.CommandText = "INSERT INTO RepresentativeMinors(MinorID, RepresentativeID, Relationship) VALUES (@MinorID, @RepresentativeID, @Relationship)";
                insert.Parameters.AddWithValue("@MinorID", minorID);
                insert.Parameters.AddWithValue("@RepresentativeID", representativeID);
                insert.Parameters.AddWithValue("@Relationship", relationship);
                connection.Open();
                insert.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void deleteFromDB(string minorID, string representativeID)
        {
            try
            {
                SqlCommand delete = new SqlCommand();
                delete.Connection = connection;
                delete.CommandText = "DELETE FROM RepresentativeMinors WHERE MinorID = @MinorID AND RepresentativeID = @RepresentativeID";
                delete.Parameters.AddWithValue("@MinorID", minorID);
                delete.Parameters.AddWithValue("@RepresentativeID", representativeID);
                connection.Open();
                delete.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<RepresentativeMinor> loadAllFromDB(string MinorID, string RepresentativeID)
        {
            try
            {
                SqlCommand select = new SqlCommand();
                select.Connection = connection;
                string commandText = "SELECT * FROM RepresentativeMinors";
                if (MinorID != null && RepresentativeID != null)
                {
                    commandText += " WHERE MinorID = @MinorID AND RepresentativeID = @RepresentativeID";
                    select.Parameters.AddWithValue("@MinorID", MinorID);
                    select.Parameters.AddWithValue("@RepresentativeID", RepresentativeID);
                } else if (MinorID != null)
                {
                    commandText += " WHERE MinorID = @MinorID";
                    select.Parameters.AddWithValue("@MinorID", MinorID);
                } else if (RepresentativeID != null)
                {
                    commandText += " WHERE RepresentativeID = @RepresentativeID";
                    select.Parameters.AddWithValue("@RepresentativeID", RepresentativeID);
                }
                select.CommandText = commandText;
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(select);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);
                connection.Close();
                List<RepresentativeMinor> representativeMinors = new List<RepresentativeMinor>();
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    RepresentativeMinor representativeMinor = new RepresentativeMinor();
                    representativeMinor.MinorID = row["MinorID"].ToString();
                    representativeMinor.RepresentativeID = row["RepresentativeID"].ToString();
                    representativeMinors.Add(representativeMinor);
                }
                return representativeMinors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
    }
}
