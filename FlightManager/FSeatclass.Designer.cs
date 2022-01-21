
namespace FlightManager
{
    partial class FSeatclass
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
            this.gVSeat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeattype = new System.Windows.Forms.TextBox();
            this.txtSeatnumber = new System.Windows.Forms.TextBox();
            this.txtFlightid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_seatnumber = new System.Windows.Forms.Label();
            this.lb_flightId = new System.Windows.Forms.Label();
            this.lb_seat_class = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVSeat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(473, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(386, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(299, 408);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 32);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVSeat);
            this.groupBox2.Location = new System.Drawing.Point(38, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 206);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gVSeat
            // 
            this.gVSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVSeat.Location = new System.Drawing.Point(6, 21);
            this.gVSeat.Name = "gVSeat";
            this.gVSeat.RowHeadersWidth = 51;
            this.gVSeat.RowTemplate.Height = 24;
            this.gVSeat.Size = new System.Drawing.Size(875, 179);
            this.gVSeat.TabIndex = 0;
            this.gVSeat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVSeat_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeattype);
            this.groupBox1.Controls.Add(this.txtSeatnumber);
            this.groupBox1.Controls.Add(this.txtFlightid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_seatnumber);
            this.groupBox1.Controls.Add(this.lb_flightId);
            this.groupBox1.Location = new System.Drawing.Point(38, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 133);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtSeattype
            // 
            this.txtSeattype.Location = new System.Drawing.Point(508, 16);
            this.txtSeattype.Name = "txtSeattype";
            this.txtSeattype.Size = new System.Drawing.Size(248, 22);
            this.txtSeattype.TabIndex = 5;
            // 
            // txtSeatnumber
            // 
            this.txtSeatnumber.Location = new System.Drawing.Point(142, 47);
            this.txtSeatnumber.Name = "txtSeatnumber";
            this.txtSeatnumber.Size = new System.Drawing.Size(248, 22);
            this.txtSeatnumber.TabIndex = 5;
            // 
            // txtFlightid
            // 
            this.txtFlightid.Location = new System.Drawing.Point(142, 16);
            this.txtFlightid.Name = "txtFlightid";
            this.txtFlightid.Size = new System.Drawing.Size(248, 22);
            this.txtFlightid.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seat Type:";
            // 
            // lb_seatnumber
            // 
            this.lb_seatnumber.AutoSize = true;
            this.lb_seatnumber.Location = new System.Drawing.Point(28, 52);
            this.lb_seatnumber.Name = "lb_seatnumber";
            this.lb_seatnumber.Size = new System.Drawing.Size(95, 17);
            this.lb_seatnumber.TabIndex = 0;
            this.lb_seatnumber.Text = "Seat Number:";
            // 
            // lb_flightId
            // 
            this.lb_flightId.AutoSize = true;
            this.lb_flightId.Location = new System.Drawing.Point(28, 22);
            this.lb_flightId.Name = "lb_flightId";
            this.lb_flightId.Size = new System.Drawing.Size(63, 17);
            this.lb_flightId.TabIndex = 0;
            this.lb_flightId.Text = "Flight ID:";
            // 
            // lb_seat_class
            // 
            this.lb_seat_class.AutoSize = true;
            this.lb_seat_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seat_class.ForeColor = System.Drawing.Color.Red;
            this.lb_seat_class.Location = new System.Drawing.Point(337, 11);
            this.lb_seat_class.Name = "lb_seat_class";
            this.lb_seat_class.Size = new System.Drawing.Size(261, 44);
            this.lb_seat_class.TabIndex = 24;
            this.lb_seat_class.Text = "SEAT CLASS";
            // 
            // FSeatclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_seat_class);
            this.Name = "FSeatclass";
            this.Text = "FSeatclass";
            this.Load += new System.EventHandler(this.FSeatclass_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVSeat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gVSeat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSeattype;
        private System.Windows.Forms.TextBox txtSeatnumber;
        private System.Windows.Forms.TextBox txtFlightid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_seatnumber;
        private System.Windows.Forms.Label lb_flightId;
        private System.Windows.Forms.Label lb_seat_class;
    }
}