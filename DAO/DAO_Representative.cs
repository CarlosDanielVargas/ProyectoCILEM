﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOM;

namespace DAO
{
    public class DAO_Representative
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionStringCopy);

        public List<Representative> loadAllFromDB()
        {
            try
            {
                DataTable dtRepresentatives = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Representatives", connection);
                adp.Fill(dtRepresentatives);
                List<Representative> representatives = new List<Representative>();
                foreach (DataRow row in dtRepresentatives.Rows)
                {
                    Representative representative = new Representative();
                    representative.RepresentativeID = row["RepresentativeID"].ToString();
                    representative.Name = row["Name"].ToString();
                    representative.Gender = row["Gender"].ToString();
                    representative.Residency = row["Residency"].ToString();
                    representative.Mail = row["Mail"].ToString();
                    representative.Phone = row["Phone"].ToString();
                    representative.MaritalStatus = row["MaritalStatus"].ToString();
                    representative.Occupation = row["Occupation"].ToString();
                    representative.WorkPlace = row["WorkPlace"].ToString();
                    representatives.Add(representative);

                    // Get all minors of this representative
                    List<Minor> minors = new List<Minor>();
                    DAO_Minor daoMinor = new DAO_Minor();
                    minors = daoMinor.searchMinorsByRepresentativeID(representative.RepresentativeID);
                    representative.Minors = minors;

                    // Get representativeMinors of this representative
                    List<RepresentativeMinor> representativeMinors = new List<RepresentativeMinor>();
                    DAO_RepresentativeMinor daoRepresentativeMinor = new DAO_RepresentativeMinor();
                    representativeMinors = daoRepresentativeMinor.searchByRepresentative(representative.RepresentativeID);
                    representative.RepresentativeMinors = representativeMinors;
                }
                return representatives;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void saveToDB(Representative representative)
        {
            try
            {
                SqlCommand insert = new SqlCommand();
                insert.Connection = connection;
                insert.CommandText = "INSERT INTO Representatives(RepresentativeID, Name, Mail, Phone, MaritalStatus, Gender, Occupation, Residency, WorkPlace) VALUES (@RepresentativeID, @Name, @Mail, @Phone, @MaritalStatus, @Gender, @Occupation, @Residency, @WorkPlace)";
                insert.Parameters.AddWithValue("@RepresentativeID", representative.RepresentativeID);
                insert.Parameters.AddWithValue("@Name", representative.Name);
                insert.Parameters.AddWithValue("@Mail", representative.Mail);
                insert.Parameters.AddWithValue("@Phone", representative.Phone);
                insert.Parameters.AddWithValue("@MaritalStatus", representative.MaritalStatus);
                insert.Parameters.AddWithValue("@Gender", representative.Gender);
                insert.Parameters.AddWithValue("@Occupation", representative.Occupation);
                insert.Parameters.AddWithValue("@Residency", representative.Residency);
                insert.Parameters.AddWithValue("@WorkPlace", representative.WorkPlace);

                connection.Open();
                insert.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateToDB(Representative representative)
        {
            try
            {
                SqlCommand update = new SqlCommand();
                update.Connection = connection;
                update.CommandText = "UPDATE Representatives SET Name = @Name, Mail = @Mail, Phone = @Phone, MaritalStatus = @MaritalStatus, Gender = @Gender, Occupation = @Occupation, Residency = @Residency, WorkPlace = @WorkPlace WHERE RepresentativeID = @RepresentativeID";
                update.Parameters.AddWithValue("@RepresentativeID", representative.RepresentativeID);
                update.Parameters.AddWithValue("@Name", representative.Name);
                update.Parameters.AddWithValue("@Mail", representative.Mail);
                update.Parameters.AddWithValue("@Phone", representative.Phone);
                update.Parameters.AddWithValue("@MaritalStatus", representative.MaritalStatus);
                update.Parameters.AddWithValue("@Gender", representative.Gender);
                update.Parameters.AddWithValue("@Occupation", representative.Occupation);
                update.Parameters.AddWithValue("@Residency", representative.Residency);
                update.Parameters.AddWithValue("@WorkPlace", representative.WorkPlace);

                connection.Open();
                update.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteFromDB(Representative representative)
        {
            try
            {
                SqlCommand delete = new SqlCommand();
                delete.Connection = connection;
                delete.CommandText = "DELETE FROM Representatives WHERE RepresentativeID = @RepresentativeID";
                delete.Parameters.AddWithValue("@RepresentativeID", representative.RepresentativeID);

                connection.Open();
                delete.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Representative searchByID(string id)
        {
            try
            {
                SqlCommand search = new SqlCommand();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Representatives WHERE RepresentativeID = '" + id + "'", connection);
                DataTable dtRepresentatives = new DataTable();
                adp.Fill(dtRepresentatives);
                List<Representative> representatives = new List<Representative>();
                foreach (DataRow row in dtRepresentatives.Rows)
                {
                    Representative representative = new Representative();
                    representative.RepresentativeID = row["RepresentativeID"].ToString();
                    representative.Name = row["Name"].ToString();
                    representative.Gender = row["Gender"].ToString();
                    representative.Residency = row["Residency"].ToString();
                    representative.Mail = row["Mail"].ToString();
                    representative.Phone = row["Phone"].ToString();
                    representative.MaritalStatus = row["MaritalStatus"].ToString();
                    representative.Occupation = row["Occupation"].ToString();
                    representative.WorkPlace = row["WorkPlace"].ToString();
                    representatives.Add(representative);
                }
                return representatives[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Representative> searchByName(string name)
        {
            try
            {
                DataTable dtRepresentatives = new DataTable();
                string query = "SELECT * FROM Representatives WHERE Name LIKE @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", "%" + name + "%");

                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(dtRepresentatives);

                List<Representative> representatives = new List<Representative>();
                foreach (DataRow row in dtRepresentatives.Rows)
                {
                    Representative representative = new Representative();
                    representative.RepresentativeID = row["RepresentativeID"].ToString();
                    representative.Name = row["Name"].ToString();
                    representative.Gender = row["Gender"].ToString();
                    representative.Residency = row["Residency"].ToString();
                    representative.Mail = row["Mail"].ToString();
                    representative.Phone = row["Phone"].ToString();
                    representative.MaritalStatus = row["MaritalStatus"].ToString();
                    representative.Occupation = row["Occupation"].ToString();
                    representative.WorkPlace = row["WorkPlace"].ToString();

                    representatives.Add(representative);
                }

                return representatives;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Representative> searchByPhone(string phone)
        {
            try
            {
                DataTable dtRepresentatives = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Representatives WHERE Phone = " + phone, connection);
                adp.Fill(dtRepresentatives);
                List<Representative> representatives = new List<Representative>();
                foreach (DataRow row in dtRepresentatives.Rows)
                {
                    Representative representative = new Representative();
                    representative.RepresentativeID = row["RepresentativeID"].ToString();
                    representative.Name = row["Name"].ToString();
                    representative.Gender =     row["Gender"].ToString();
                    representative.Residency = row["Residency"].ToString();
                    representative.Mail = row["Mail"].ToString();
                    representative.Phone = row["Phone"].ToString();
                    representative.MaritalStatus = row["MaritalStatus"].ToString();
                    representative.Occupation = row["Occupation"].ToString();
                    representative.WorkPlace = row["WorkPlace"].ToString();
                    representatives.Add(representative);
                }
                return representatives;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Representative> searchRepresentativesByMinorID(string minorID)
        {
            try
            {
                DataTable dtRepresentatives = new DataTable();
                string query = @"
                                SELECT r.*, rm.*
                                FROM Minors m
                                INNER JOIN RepresentativeMinors rm ON m.MinorID = rm.MinorID
                                INNER JOIN Representatives r ON rm.RepresentativeID = r.RepresentativeID
                                WHERE m.MinorID = @MinorID";

                SqlDataAdapter adp = new SqlDataAdapter(query, connection);
                adp.SelectCommand.Parameters.AddWithValue("@MinorID", minorID);
                adp.Fill(dtRepresentatives);

                List<Representative> representatives = new List<Representative>();
                foreach (DataRow row in dtRepresentatives.Rows)
                {
                    Representative representative = new Representative();
                    representative.RepresentativeID = row["RepresentativeID"].ToString();
                    representative.Name = row["Name"].ToString();
                    representative.Gender = row["Gender"].ToString();
                    representative.Residency = row["Residency"].ToString();
                    representative.Mail = row["Mail"].ToString();
                    representative.Phone = row["Phone"].ToString();
                    representative.MaritalStatus = row["MaritalStatus"].ToString();
                    representative.Occupation = row["Occupation"].ToString();
                    representative.WorkPlace = row["WorkPlace"].ToString();
                    representative.Relationship = row["Relationship"].ToString();

                    representatives.Add(representative);
                }

                return representatives;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
