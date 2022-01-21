
namespace FlightManager
{
    partial class FFlight
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
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gVFlight = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUDFlightTime = new System.Windows.Forms.NumericUpDown();
            this.txtAirplaneid = new System.Windows.Forms.TextBox();
            this.txtScheduleid = new System.Windows.Forms.TextBox();
            this.txtFlightid = new System.Windows.Forms.TextBox();
            this.nEmptySeat = new System.Windows.Forms.NumericUpDown();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.dtbDeparture = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_flightid = new System.Windows.Forms.Label();
            this.lb_flight = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVFlight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFlightTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEmptySeat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(473, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(386, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(299, 408);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 32);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVFlight);
            this.groupBox2.Location = new System.Drawing.Point(38, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 206);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gVFlight
            // 
            this.gVFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVFlight.Location = new System.Drawing.Point(6, 21);
            this.gVFlight.Name = "gVFlight";
            this.gVFlight.RowHeadersWidth = 51;
            this.gVFlight.RowTemplate.Height = 24;
            this.gVFlight.Size = new System.Drawing.Size(875, 179);
            this.gVFlight.TabIndex = 0;
            this.gVFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVFlight_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUDFlightTime);
            this.groupBox1.Controls.Add(this.txtAirplaneid);
            this.groupBox1.Controls.Add(this.txtScheduleid);
            this.groupBox1.Controls.Add(this.txtFlightid);
            this.groupBox1.Controls.Add(this.nEmptySeat);
            this.groupBox1.Controls.Add(this.dtpArrival);
            this.groupBox1.Controls.Add(this.dtbDeparture);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_flightid);
            this.groupBox1.Location = new System.Drawing.Point(38, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // nUDFlightTime
            // 
            this.nUDFlightTime.Location = new System.Drawing.Point(508, 48);
            this.nUDFlightTime.Name = "nUDFlightTime";
            this.nUDFlightTime.Size = new System.Drawing.Size(248, 22);
            this.nUDFlightTime.TabIndex = 6;
            // 
            // txtAirplaneid
            // 
            this.txtAirplaneid.Location = new System.Drawing.Point(508, 16);
            this.txtAirplaneid.Name = "txtAirplaneid";
            this.txtAirplaneid.Size = new System.Drawing.Size(248, 22);
            this.txtAirplaneid.TabIndex = 5;
            // 
            // txtScheduleid
            // 
            this.txtScheduleid.Location = new System.Drawing.Point(142, 47);
            this.txtScheduleid.Name = "txtScheduleid";
            this.txtScheduleid.Size = new System.Drawing.Size(248, 22);
            this.txtScheduleid.TabIndex = 5;
            // 
            // txtFlightid
            // 
            this.txtFlightid.Location = new System.Drawing.Point(142, 16);
            this.txtFlightid.Name = "txtFlightid";
            this.txtFlightid.Size = new System.Drawing.Size(248, 22);
            this.txtFlightid.TabIndex = 5;
            // 
            // nEmptySeat
            // 
            this.nEmptySeat.Location = new System.Drawing.Point(142, 104);
            this.nEmptySeat.Name = "nEmptySeat";
            this.nEmptySeat.Size = new System.Drawing.Size(248, 22);
            this.nEmptySeat.TabIndex = 4;
            // 
            // dtpArrival
            // 
            this.dtpArrival.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrival.Location = new System.Drawing.Point(508, 75);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(248, 22);
            this.dtpArrival.TabIndex = 2;
            // 
            // dtbDeparture
            // 
            this.dtbDeparture.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtbDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbDeparture.Location = new System.Drawing.Point(142, 75);
            this.dtbDeparture.Name = "dtbDeparture";
            this.dtbDeparture.Size = new System.Drawing.Size(248, 22);
            this.dtbDeparture.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ghế trống:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày khởi hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hành trình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian bay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã máy bay:";
            // 
            // lb_flightid
            // 
            this.lb_flightid.AutoSize = true;
            this.lb_flightid.Location = new System.Drawing.Point(28, 22);
            this.lb_flightid.Name = "lb_flightid";
            this.lb_flightid.Size = new System.Drawing.Size(108, 17);
            this.lb_flightid.TabIndex = 0;
            this.lb_flightid.Text = "Mã chuyến bay:";
            // 
            // lb_flight
            // 
            this.lb_flight.AutoSize = true;
            this.lb_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_flight.ForeColor = System.Drawing.Color.Red;
            this.lb_flight.Location = new System.Drawing.Point(357, 11);
            this.lb_flight.Name = "lb_flight";
            this.lb_flight.Size = new System.Drawing.Size(160, 44);
            this.lb_flight.TabIndex = 6;
            this.lb_flight.Text = "FLIGHT";
            // 
            // FFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_flight);
            this.Name = "FFlight";
            this.Text = "FFlight";
            this.Load += new System.EventHandler(this.FFlight_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVFlight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFlightTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEmptySeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gVFlight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAirplaneid;
        private System.Windows.Forms.TextBox txtScheduleid;
        private System.Windows.Forms.TextBox txtFlightid;
        private System.Windows.Forms.NumericUpDown nEmptySeat;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.DateTimePicker dtbDeparture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_flightid;
        private System.Windows.Forms.Label lb_flight;
        private System.Windows.Forms.NumericUpDown nUDFlightTime;
    }
}