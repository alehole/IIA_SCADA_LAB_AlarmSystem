using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlarmSystem
{
    public partial class Form1 : Form
    {
        readonly Write_DB _WriteDb = new Write_DB();
        readonly Read_DB _ReadDb = new Read_DB();

        private bool Temperature_Alarm_Active = false;
        string SQLCMD;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            is_AlarmsActive();
        }

        private void is_AlarmsActive()
        {
            SQLCMD = "SELECT Active FROM ALARM WHERE AlarmId = 1 ";
            Temperature_Alarm_Active_ = _ReadDb.is_Active(SQLCMD);
        }

        public bool Temperature_Alarm_Active_
        {
            get
            {
                return Temperature_Alarm_Active;
            }
            set
            {
                if (Temperature_Alarm_Active != value)
                {
                    Temperature_Alarm_Active = value;
                    Read_AlarmView();
                }
            }
        }
        public void Read_AlarmView()
        {
            List<Read_DB> Db_Values = Read_DB.Read_Alarm_Log_DB();
            int AlarmId = -1;
            string TagName = "";
            string AckTime = "";
            string ActivitionTime = "";
            string AlarmReason = "";
            foreach (var measurement in Db_Values)
            {
                AlarmId = measurement.AlarmId;
                TagName = measurement.TagName;
                AckTime = measurement.AckTime;
                ActivitionTime = measurement.ActivationTime;
                AlarmReason = measurement.alarmReason;
            }
            UpdateDataGrid_Temp(AlarmId.ToString(), TagName , Temperature_Alarm_Active, AckTime, ActivitionTime, txtBx_Operator.Text, AlarmReason);

            if (Temperature_Alarm_Active)
            {
                txtbx_AlarmActive.BackColor = System.Drawing.Color.IndianRed;
                txtbx_AlarmActive.Text = "Alarm active!";
            }
            else
            {
                txtbx_AlarmActive.Text = "No Alarm!";
                txtbx_AlarmActive.BackColor = DefaultBackColor;
            }
        }
        private void UpdateDataGrid_Temp(string AlarmId, string tagName, bool Active , string AckTime , string ActiviationTime, string AckedBy, string AlarmReason)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv_Alarms);
            row.Cells[0].Value = AlarmId;
            row.Cells[1].Value = AlarmReason;
            row.Cells[2].Value = tagName;
            row.Cells[3].Value = Active;
            row.Cells[4].Value = ActiviationTime;
            row.Cells[5].Value = AckTime;
            row.Cells[6].Value = AckedBy;
            dgv_Alarms.Rows.Add(row);
            dgv_Alarms.Sort(dgv_Alarms.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }
        private void btn_AckAlarms_Click(object sender, EventArgs e)
        {
            _WriteDb.AckAlarm(1, txtBx_Operator.Text);
        }
    }
}