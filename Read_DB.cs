using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AlarmSystem
{
    public class Read_DB
    {
        public int AlarmId { get; set; }
        public string TagName { get; set; }
        public string Active { get; set; }
        public string ActivationTime { get; set; }
        public string AckTime { get; set; }
        public string AckedBy { get; set; }
        public string alarmReason { get; set; }
        public static bool AlarmActive_Temperature { get; set; }

        public static List<Read_DB> Read_Alarm_Log_DB()
        {
            string conString = ConfigurationManager.ConnectionStrings["DB_Measurements"].ConnectionString;       
            var con = new SqlConnection(conString);
            string selectSQL;

            selectSQL = "SELECT AlarmId,TagName, Active ,ActivationTime, AckTime, AckedBy , AlarmReason FROM VIEW_TEMPERATURE_ALARM WHERE ActivationTime = (SELECT MAX(ActivationTime) FROM VIEW_TEMPERATURE_ALARM) AND AlarmId = 1";

            con.Open();
            var cmd = new SqlCommand(selectSQL, con);
            var SqlDataReader = cmd.ExecuteReader();

            var sensorDataList = new List<Read_DB>();
            if (SqlDataReader != null)
            {
                while (SqlDataReader.Read())
                {
                    Read_DB sensorData = new Read_DB();
                    {
                        sensorData.AlarmId = Convert.ToInt32(SqlDataReader["AlarmId"]);
                        sensorData.TagName = Convert.ToString(SqlDataReader["TagName"]);
                        sensorData.Active = Convert.ToString(SqlDataReader["Active"]);
                        if (SqlDataReader["ActivationTime"] != null)
                        {
                            sensorData.ActivationTime = Convert.ToString(SqlDataReader["ActivationTime"]);
                        }
                        else
                        {
                            sensorData.ActivationTime = null;
                        }
                        sensorData.AckTime = Convert.ToString(SqlDataReader["AckTime"]);
                        sensorData.AckedBy = Convert.ToString(SqlDataReader["AckedBy"]);
                        sensorData.alarmReason = Convert.ToString(SqlDataReader["AlarmReason"]);
                    }
                    sensorDataList.Add(sensorData);
                }
            }
            con.Close();
            return sensorDataList;
        }
        public bool is_Active(string selectSQL)
        {
            string conString = ConfigurationManager.ConnectionStrings["DB_Measurements"].ConnectionString;
            var con = new SqlConnection(conString);

            con.Open();
            var cmd = new SqlCommand(selectSQL, con);
            var SqlDataReader = cmd.ExecuteReader();

            if (SqlDataReader != null)
            {
                while (SqlDataReader.Read())
                {
                    AlarmActive_Temperature = Convert.ToBoolean(SqlDataReader["Active"]);
                }
            }
            con.Close();
            return AlarmActive_Temperature;
        }
    }
}
