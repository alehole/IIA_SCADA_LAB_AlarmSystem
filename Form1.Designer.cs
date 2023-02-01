
namespace AlarmSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_Alarms = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_AckAlarms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_Operator = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.txtbx_AlarmActive = new System.Windows.Forms.TextBox();
            this.AlarmId_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_alarmReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActTime_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AckTime_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AckedBy_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alarms)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Alarms
            // 
            this.dgv_Alarms.AllowUserToOrderColumns = true;
            this.dgv_Alarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlarmId_Col,
            this.col_alarmReason,
            this.TagName_Col,
            this.Active_Col,
            this.ActTime_Col,
            this.AckTime_Col,
            this.AckedBy_Col});
            this.dgv_Alarms.Location = new System.Drawing.Point(12, 11);
            this.dgv_Alarms.Name = "dgv_Alarms";
            this.dgv_Alarms.Size = new System.Drawing.Size(743, 215);
            this.dgv_Alarms.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_AckAlarms
            // 
            this.btn_AckAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AckAlarms.Location = new System.Drawing.Point(6, 19);
            this.btn_AckAlarms.Name = "btn_AckAlarms";
            this.btn_AckAlarms.Size = new System.Drawing.Size(106, 51);
            this.btn_AckAlarms.TabIndex = 1;
            this.btn_AckAlarms.Text = "Ack\r\nAlarms";
            this.btn_AckAlarms.UseVisualStyleBackColor = true;
            this.btn_AckAlarms.Click += new System.EventHandler(this.btn_AckAlarms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operator:";
            // 
            // txtBx_Operator
            // 
            this.txtBx_Operator.Location = new System.Drawing.Point(10, 103);
            this.txtBx_Operator.Name = "txtBx_Operator";
            this.txtBx_Operator.Size = new System.Drawing.Size(103, 20);
            this.txtBx_Operator.TabIndex = 3;
            this.txtBx_Operator.Text = "Aleksander Holthe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AckAlarms);
            this.groupBox1.Controls.Add(this.txtBx_Operator);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(770, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // led1
            // 
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led1.Location = new System.Drawing.Point(716, 222);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(8, 8);
            this.led1.TabIndex = 8;
            // 
            // txtbx_AlarmActive
            // 
            this.txtbx_AlarmActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_AlarmActive.Location = new System.Drawing.Point(771, 151);
            this.txtbx_AlarmActive.Name = "txtbx_AlarmActive";
            this.txtbx_AlarmActive.ReadOnly = true;
            this.txtbx_AlarmActive.Size = new System.Drawing.Size(117, 29);
            this.txtbx_AlarmActive.TabIndex = 9;
            this.txtbx_AlarmActive.Text = "No Alarm!";
            // 
            // AlarmId_Col
            // 
            this.AlarmId_Col.HeaderText = "AlarmId";
            this.AlarmId_Col.Name = "AlarmId_Col";
            // 
            // col_alarmReason
            // 
            this.col_alarmReason.HeaderText = "Alarm Reason";
            this.col_alarmReason.Name = "col_alarmReason";
            this.col_alarmReason.ReadOnly = true;
            // 
            // TagName_Col
            // 
            this.TagName_Col.HeaderText = "TagName";
            this.TagName_Col.Name = "TagName_Col";
            this.TagName_Col.ReadOnly = true;
            // 
            // Active_Col
            // 
            this.Active_Col.HeaderText = "Active";
            this.Active_Col.Name = "Active_Col";
            this.Active_Col.ReadOnly = true;
            // 
            // ActTime_Col
            // 
            this.ActTime_Col.HeaderText = "Activation time";
            this.ActTime_Col.Name = "ActTime_Col";
            this.ActTime_Col.ReadOnly = true;
            // 
            // AckTime_Col
            // 
            this.AckTime_Col.HeaderText = "Ack Time";
            this.AckTime_Col.Name = "AckTime_Col";
            this.AckTime_Col.ReadOnly = true;
            // 
            // AckedBy_Col
            // 
            this.AckedBy_Col.HeaderText = "Operator";
            this.AckedBy_Col.Name = "AckedBy_Col";
            this.AckedBy_Col.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 239);
            this.Controls.Add(this.dgv_Alarms);
            this.Controls.Add(this.txtbx_AlarmActive);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Alarm system";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alarms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Alarms;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_AckAlarms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_Operator;
        private System.Windows.Forms.GroupBox groupBox1;
        private NationalInstruments.UI.WindowsForms.Led led1;
        private System.Windows.Forms.TextBox txtbx_AlarmActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmId_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_alarmReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActTime_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn AckTime_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn AckedBy_Col;
    }
}

