
namespace FlightManager
{
    partial class FSchedule
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
            this.gVSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdeparture = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtScheduleid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_seatnumber = new System.Windows.Forms.Label();
            this.lb_scheduleId = new System.Windows.Forms.Label();
            this.lb_seat_class = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVSchedule)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(465, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 33;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(378, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 34;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(291, 408);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 32);
            this.btn_Them.TabIndex = 35;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVSchedule);
            this.groupBox2.Location = new System.Drawing.Point(30, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 206);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gVSchedule
            // 
            this.gVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVSchedule.Location = new System.Drawing.Point(6, 21);
            this.gVSchedule.Name = "gVSchedule";
            this.gVSchedule.RowHeadersWidth = 51;
            this.gVSchedule.RowTemplate.Height = 24;
            this.gVSchedule.Size = new System.Drawing.Size(875, 179);
            this.gVSchedule.TabIndex = 0;
            this.gVSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVSchedule_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdeparture);
            this.groupBox1.Controls.Add(this.txtArrival);
            this.groupBox1.Controls.Add(this.txtScheduleid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_seatnumber);
            this.groupBox1.Controls.Add(this.lb_scheduleId);
            this.groupBox1.Location = new System.Drawing.Point(30, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 133);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtdeparture
            // 
            this.txtdeparture.Location = new System.Drawing.Point(544, 17);
            this.txtdeparture.Name = "txtdeparture";
            this.txtdeparture.Size = new System.Drawing.Size(248, 22);
            this.txtdeparture.TabIndex = 5;
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(142, 47);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(248, 22);
            this.txtArrival.TabIndex = 5;
            // 
            // txtScheduleid
            // 
            this.txtScheduleid.Location = new System.Drawing.Point(142, 16);
            this.txtScheduleid.Name = "txtScheduleid";
            this.txtScheduleid.Size = new System.Drawing.Size(248, 22);
            this.txtScheduleid.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Departure Airport:";
            // 
            // lb_seatnumber
            // 
            this.lb_seatnumber.AutoSize = true;
            this.lb_seatnumber.Location = new System.Drawing.Point(28, 52);
            this.lb_seatnumber.Name = "lb_seatnumber";
            this.lb_seatnumber.Size = new System.Drawing.Size(98, 17);
            this.lb_seatnumber.TabIndex = 0;
            this.lb_seatnumber.Text = "Arrival Airport:";
            // 
            // lb_scheduleId
            // 
            this.lb_scheduleId.AutoSize = true;
            this.lb_scheduleId.Location = new System.Drawing.Point(28, 22);
            this.lb_scheduleId.Name = "lb_scheduleId";
            this.lb_scheduleId.Size = new System.Drawing.Size(88, 17);
            this.lb_scheduleId.TabIndex = 0;
            this.lb_scheduleId.Text = "Schedule ID:";
            // 
            // lb_seat_class
            // 
            this.lb_seat_class.AutoSize = true;
            this.lb_seat_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seat_class.ForeColor = System.Drawing.Color.Red;
            this.lb_seat_class.Location = new System.Drawing.Point(329, 11);
            this.lb_seat_class.Name = "lb_seat_class";
            this.lb_seat_class.Size = new System.Drawing.Size(232, 44);
            this.lb_seat_class.TabIndex = 30;
            this.lb_seat_class.Text = "SCHEDULE";
            // 
            // FSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_seat_class);
            this.Name = "FSchedule";
            this.Text = "FSchedule";
            this.Load += new System.EventHandler(this.FSchedule_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVSchedule)).EndInit();
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
        private System.Windows.Forms.DataGridView gVSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdeparture;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtScheduleid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_seatnumber;
        private System.Windows.Forms.Label lb_scheduleId;
        private System.Windows.Forms.Label lb_seat_class;
    }
}