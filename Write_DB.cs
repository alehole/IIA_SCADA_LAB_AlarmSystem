using System.Configuration;
using System.Data.SqlClient;

namespace AlarmSystem
{
    class Write_DB
    {
        private string conString = ConfigurationManager.ConnectionStrings["DB_Measurements"].ConnectionString;

        public void SQL_Query(string sqlQuery)
        {
            SqlConnection _con = new SqlConnection(conString);
            _con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public void AckAlarm(int alarmId, string user) // Stored proc
        {
            SqlConnection _con = new SqlConnection(conString);
            _con.Open();
            SqlCommand cmd = new SqlCommand("Usp_AckAlarm", _con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AlarmId", alarmId));
            cmd.Parameters.Add(new SqlParameter("@AckedBy", user));
            cmd.ExecuteNonQuery();
            _con.Close();
        }
    }
}
