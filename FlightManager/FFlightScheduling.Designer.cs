
namespace FlightManager
{
    partial class FFlightScheduling
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFlightScheduling = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnote2 = new System.Windows.Forms.TextBox();
            this.txtnote1 = new System.Windows.Forms.TextBox();
            this.nUDTimmingStop2 = new System.Windows.Forms.NumericUpDown();
            this.nUDTimmingStop1 = new System.Windows.Forms.NumericUpDown();
            this.dTPArrivalDay2 = new System.Windows.Forms.DateTimePicker();
            this.dTPArrivalDay1 = new System.Windows.Forms.DateTimePicker();
            this.cbTransitAirport2 = new System.Windows.Forms.ComboBox();
            this.cbTransitAirport1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nUDEconomyClass = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nUDBusinessClass = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nUDFlightTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dTPDepartureDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbArrivalAirport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDepartureAirport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAirplaneID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTimmingStop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTimmingStop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEconomyClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBusinessClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFlightTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập Lịch Chuyến Bay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFlightScheduling);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.nUDEconomyClass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nUDBusinessClass);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nUDFlightTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dTPDepartureDay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbArrivalAirport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbDepartureAirport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbAirplaneID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFlightID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 648);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btFlightScheduling
            // 
            this.btFlightScheduling.ForeColor = System.Drawing.Color.Red;
            this.btFlightScheduling.Location = new System.Drawing.Point(838, 601);
            this.btFlightScheduling.Name = "btFlightScheduling";
            this.btFlightScheduling.Size = new System.Drawing.Size(238, 41);
            this.btFlightScheduling.TabIndex = 18;
            this.btFlightScheduling.Text = "Lập lịch chuyến bay";
            this.btFlightScheduling.UseVisualStyleBackColor = true;
            this.btFlightScheduling.Click += new System.EventHandler(this.btFlightScheduling_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnote2);
            this.groupBox2.Controls.Add(this.txtnote1);
            this.groupBox2.Controls.Add(this.nUDTimmingStop2);
            this.groupBox2.Controls.Add(this.nUDTimmingStop1);
            this.groupBox2.Controls.Add(this.dTPArrivalDay2);
            this.groupBox2.Controls.Add(this.dTPArrivalDay1);
            this.groupBox2.Controls.Add(this.cbTransitAirport2);
            this.groupBox2.Controls.Add(this.cbTransitAirport1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(25, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 262);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sân bay trung gian";
            // 
            // txtnote2
            // 
            this.txtnote2.Location = new System.Drawing.Point(798, 193);
            this.txtnote2.Name = "txtnote2";
            this.txtnote2.Size = new System.Drawing.Size(253, 34);
            this.txtnote2.TabIndex = 28;
            // 
            // txtnote1
            // 
            this.txtnote1.Location = new System.Drawing.Point(798, 118);
            this.txtnote1.Name = "txtnote1";
            this.txtnote1.Size = new System.Drawing.Size(253, 34);
            this.txtnote1.TabIndex = 18;
            // 
            // nUDTimmingStop2
            // 
            this.nUDTimmingStop2.Location = new System.Drawing.Point(605, 193);
            this.nUDTimmingStop2.Name = "nUDTimmingStop2";
            this.nUDTimmingStop2.Size = new System.Drawing.Size(169, 34);
            this.nUDTimmingStop2.TabIndex = 27;
            // 
            // nUDTimmingStop1
            // 
            this.nUDTimmingStop1.Location = new System.Drawing.Point(605, 116);
            this.nUDTimmingStop1.Name = "nUDTimmingStop1";
            this.nUDTimmingStop1.Size = new System.Drawing.Size(169, 34);
            this.nUDTimmingStop1.TabIndex = 18;
            // 
            // dTPArrivalDay2
            // 
            this.dTPArrivalDay2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dTPArrivalDay2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPArrivalDay2.Location = new System.Drawing.Point(334, 193);
            this.dTPArrivalDay2.Name = "dTPArrivalDay2";
            this.dTPArrivalDay2.Size = new System.Drawing.Size(245, 34);
            this.dTPArrivalDay2.TabIndex = 26;
            // 
            // dTPArrivalDay1
            // 
            this.dTPArrivalDay1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dTPArrivalDay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPArrivalDay1.Location = new System.Drawing.Point(334, 116);
            this.dTPArrivalDay1.Name = "dTPArrivalDay1";
            this.dTPArrivalDay1.Size = new System.Drawing.Size(245, 34);
            this.dTPArrivalDay1.TabIndex = 18;
            // 
            // cbTransitAirport2
            // 
            this.cbTransitAirport2.FormattingEnabled = true;
            this.cbTransitAirport2.Location = new System.Drawing.Point(63, 190);
            this.cbTransitAirport2.Name = "cbTransitAirport2";
            this.cbTransitAirport2.Size = new System.Drawing.Size(242, 37);
            this.cbTransitAirport2.TabIndex = 25;
            // 
            // cbTransitAirport1
            // 
            this.cbTransitAirport1.FormattingEnabled = true;
            this.cbTransitAirport1.Location = new System.Drawing.Point(63, 116);
            this.cbTransitAirport1.Name = "cbTransitAirport1";
            this.cbTransitAirport1.Size = new System.Drawing.Size(242, 37);
            this.cbTransitAirport1.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 29);
            this.label16.TabIndex = 24;
            this.label16.Text = "2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 29);
            this.label15.TabIndex = 23;
            this.label15.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(872, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 29);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ghi chú";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(383, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 29);
            this.label13.TabIndex = 21;
            this.label13.Text = "Thời gian đến";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(611, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Thời gian dừng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Sân bay trung gian";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "STT";
            // 
            // nUDEconomyClass
            // 
            this.nUDEconomyClass.Location = new System.Drawing.Point(876, 264);
            this.nUDEconomyClass.Name = "nUDEconomyClass";
            this.nUDEconomyClass.Size = new System.Drawing.Size(178, 34);
            this.nUDEconomyClass.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số lượng ghế hạng 2:";
            // 
            // nUDBusinessClass
            // 
            this.nUDBusinessClass.Location = new System.Drawing.Point(333, 264);
            this.nUDBusinessClass.Name = "nUDBusinessClass";
            this.nUDBusinessClass.Size = new System.Drawing.Size(178, 34);
            this.nUDBusinessClass.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng ghế hạng 1:";
            // 
            // nUDFlightTime
            // 
            this.nUDFlightTime.Location = new System.Drawing.Point(782, 205);
            this.nUDFlightTime.Name = "nUDFlightTime";
            this.nUDFlightTime.Size = new System.Drawing.Size(272, 34);
            this.nUDFlightTime.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thời gian bay:";
            // 
            // dTPDepartureDay
            // 
            this.dTPDepartureDay.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dTPDepartureDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDepartureDay.Location = new System.Drawing.Point(239, 202);
            this.dTPDepartureDay.Name = "dTPDepartureDay";
            this.dTPDepartureDay.Size = new System.Drawing.Size(272, 34);
            this.dTPDepartureDay.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày - giờ:";
            // 
            // cbArrivalAirport
            // 
            this.cbArrivalAirport.FormattingEnabled = true;
            this.cbArrivalAirport.Location = new System.Drawing.Point(782, 122);
            this.cbArrivalAirport.Name = "cbArrivalAirport";
            this.cbArrivalAirport.Size = new System.Drawing.Size(272, 37);
            this.cbArrivalAirport.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sân bay đến:";
            // 
            // cbDepartureAirport
            // 
            this.cbDepartureAirport.FormattingEnabled = true;
            this.cbDepartureAirport.Location = new System.Drawing.Point(239, 120);
            this.cbDepartureAirport.Name = "cbDepartureAirport";
            this.cbDepartureAirport.Size = new System.Drawing.Size(272, 37);
            this.cbDepartureAirport.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sân bay đi:";
            // 
            // cbAirplaneID
            // 
            this.cbAirplaneID.FormattingEnabled = true;
            this.cbAirplaneID.Location = new System.Drawing.Point(782, 36);
            this.cbAirplaneID.Name = "cbAirplaneID";
            this.cbAirplaneID.Size = new System.Drawing.Size(272, 37);
            this.cbAirplaneID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã máy bay:";
            // 
            // txtFlightID
            // 
            this.txtFlightID.Location = new System.Drawing.Point(239, 39);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(272, 34);
            this.txtFlightID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chuyến bay:";
            // 
            // FFlightScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 743);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FFlightScheduling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Lịch Chuyến Bay";
            this.Load += new System.EventHandler(this.FFlightScheduling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTimmingStop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTimmingStop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEconomyClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBusinessClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFlightTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTPDepartureDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbArrivalAirport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartureAirport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAirplaneID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDFlightTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDEconomyClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nUDBusinessClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnote2;
        private System.Windows.Forms.TextBox txtnote1;
        private System.Windows.Forms.NumericUpDown nUDTimmingStop2;
        private System.Windows.Forms.NumericUpDown nUDTimmingStop1;
        private System.Windows.Forms.DateTimePicker dTPArrivalDay2;
        private System.Windows.Forms.DateTimePicker dTPArrivalDay1;
        private System.Windows.Forms.ComboBox cbTransitAirport2;
        private System.Windows.Forms.ComboBox cbTransitAirport1;
        private System.Windows.Forms.Button btFlightScheduling;
    }
}