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
    public class DAO_MonthlyPayments
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);

        public void saveToDB(MonthlyPayment monthlyPayment)
        {
            try
            {
                SqlCommand insertMonthlyPayment = new SqlCommand();
                insertMonthlyPayment.Connection = connection;
                insertMonthlyPayment.CommandText = "INSERT INTO [MonthlyPayments] ([Value], [Month], [Date], [MinorID], [Observation], [DepositNumber]) VALUES (@Value, @Month, @Date, @MinorID, @Observation, @DepositNumber)";
                insertMonthlyPayment.Parameters.AddWithValue("@Value", monthlyPayment.Value);
                insertMonthlyPayment.Parameters.AddWithValue("@Month", monthlyPayment.Month);
                insertMonthlyPayment.Parameters.AddWithValue("@Date", monthlyPayment.PaymentDate);
                insertMonthlyPayment.Parameters.AddWithValue("@MinorID", monthlyPayment.MinorID);
                insertMonthlyPayment.Parameters.AddWithValue("@Observation", monthlyPayment.Observation);
                insertMonthlyPayment.Parameters.AddWithValue("@DepositNumber", monthlyPayment.DepositNumber);

                connection.Open();
                insertMonthlyPayment.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MonthlyPayment> searchByMinorID(string minorID)
        {
            try
            {
                DataTable dtMonthlyPayments = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM MonthlyPayments WHERE MinorID = @MinorID", connection);
                adp.SelectCommand.Parameters.AddWithValue("@MinorID", minorID);
                adp.Fill(dtMonthlyPayments);

                List<MonthlyPayment> monthlyPaymentsList = new List<MonthlyPayment>();
                foreach (DataRow row in dtMonthlyPayments.Rows)
                {
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.MonthlyPaymentID = Convert.ToInt32(row["MonthlyPaymentID"]);
                    monthlyPayment.Value = Convert.ToDouble(row["Value"]);
                    monthlyPayment.Month = row["Month"].ToString();
                    monthlyPayment.PaymentDate = Convert.ToDateTime(row["Date"]);
                    monthlyPayment.MinorID = row["MinorID"].ToString();
                    monthlyPayment.Observation = row["Observation"].ToString();
                    monthlyPayment.DepositNumber = row["DepositNumber"].ToString();

                    monthlyPaymentsList.Add(monthlyPayment);
                }

                return monthlyPaymentsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}