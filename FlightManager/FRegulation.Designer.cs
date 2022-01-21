
namespace FlightManager
{
    partial class FRegulation
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
            this.gVRegu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberAirport = new System.Windows.Forms.TextBox();
            this.txtSaleTime = new System.Windows.Forms.TextBox();
            this.txtMinTimeStop = new System.Windows.Forms.TextBox();
            this.txtMinTime = new System.Windows.Forms.TextBox();
            this.txtBookTime = new System.Windows.Forms.TextBox();
            this.txtMaxTimeStop = new System.Windows.Forms.TextBox();
            this.txtMaxInterAp = new System.Windows.Forms.TextBox();
            this.txtReId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_flightid = new System.Windows.Forms.Label();
            this.lb_flight = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVRegu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(477, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(390, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(303, 408);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 32);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVRegu);
            this.groupBox2.Location = new System.Drawing.Point(42, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 206);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gVRegu
            // 
            this.gVRegu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVRegu.Location = new System.Drawing.Point(6, 21);
            this.gVRegu.Name = "gVRegu";
            this.gVRegu.RowHeadersWidth = 51;
            this.gVRegu.RowTemplate.Height = 24;
            this.gVRegu.Size = new System.Drawing.Size(875, 179);
            this.gVRegu.TabIndex = 0;
            this.gVRegu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVRegu_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumberAirport);
            this.groupBox1.Controls.Add(this.txtSaleTime);
            this.groupBox1.Controls.Add(this.txtMinTimeStop);
            this.groupBox1.Controls.Add(this.txtMinTime);
            this.groupBox1.Controls.Add(this.txtBookTime);
            this.groupBox1.Controls.Add(this.txtMaxTimeStop);
            this.groupBox1.Controls.Add(this.txtMaxInterAp);
            this.groupBox1.Controls.Add(this.txtReId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_flightid);
            this.groupBox1.Location = new System.Drawing.Point(42, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 133);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtNumberAirport
            // 
            this.txtNumberAirport.Location = new System.Drawing.Point(541, 16);
            this.txtNumberAirport.Name = "txtNumberAirport";
            this.txtNumberAirport.Size = new System.Drawing.Size(248, 22);
            this.txtNumberAirport.TabIndex = 5;
            // 
            // txtSaleTime
            // 
            this.txtSaleTime.Location = new System.Drawing.Point(142, 103);
            this.txtSaleTime.Name = "txtSaleTime";
            this.txtSaleTime.Size = new System.Drawing.Size(248, 22);
            this.txtSaleTime.TabIndex = 5;
            // 
            // txtMinTimeStop
            // 
            this.txtMinTimeStop.Location = new System.Drawing.Point(142, 75);
            this.txtMinTimeStop.Name = "txtMinTimeStop";
            this.txtMinTimeStop.Size = new System.Drawing.Size(248, 22);
            this.txtMinTimeStop.TabIndex = 5;
            // 
            // txtMinTime
            // 
            this.txtMinTime.Location = new System.Drawing.Point(142, 47);
            this.txtMinTime.Name = "txtMinTime";
            this.txtMinTime.Size = new System.Drawing.Size(248, 22);
            this.txtMinTime.TabIndex = 5;
            // 
            // txtBookTime
            // 
            this.txtBookTime.Location = new System.Drawing.Point(541, 103);
            this.txtBookTime.Name = "txtBookTime";
            this.txtBookTime.Size = new System.Drawing.Size(248, 22);
            this.txtBookTime.TabIndex = 5;
            // 
            // txtMaxTimeStop
            // 
            this.txtMaxTimeStop.Location = new System.Drawing.Point(541, 75);
            this.txtMaxTimeStop.Name = "txtMaxTimeStop";
            this.txtMaxTimeStop.Size = new System.Drawing.Size(248, 22);
            this.txtMaxTimeStop.TabIndex = 5;
            // 
            // txtMaxInterAp
            // 
            this.txtMaxInterAp.Location = new System.Drawing.Point(541, 47);
            this.txtMaxInterAp.Name = "txtMaxInterAp";
            this.txtMaxInterAp.Size = new System.Drawing.Size(248, 22);
            this.txtMaxInterAp.TabIndex = 5;
            // 
            // txtReId
            // 
            this.txtReId.Location = new System.Drawing.Point(142, 16);
            this.txtReId.Name = "txtReId";
            this.txtReId.Size = new System.Drawing.Size(248, 22);
            this.txtReId.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sale Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min Time Stop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min Flight time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Booking Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Time Stop:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max Intermediate Airport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airport\'s Number";
            // 
            // lb_flightid
            // 
            this.lb_flightid.AutoSize = true;
            this.lb_flightid.Location = new System.Drawing.Point(28, 22);
            this.lb_flightid.Name = "lb_flightid";
            this.lb_flightid.Size = new System.Drawing.Size(97, 17);
            this.lb_flightid.TabIndex = 0;
            this.lb_flightid.Text = "Regulation ID:";
            // 
            // lb_flight
            // 
            this.lb_flight.AutoSize = true;
            this.lb_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_flight.ForeColor = System.Drawing.Color.Red;
            this.lb_flight.Location = new System.Drawing.Point(361, 11);
            this.lb_flight.Name = "lb_flight";
            this.lb_flight.Size = new System.Drawing.Size(275, 44);
            this.lb_flight.TabIndex = 18;
            this.lb_flight.Text = "REGULATION";
            // 
            // FRegulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_flight);
            this.Name = "FRegulation";
            this.Text = "FRegulation";
            this.Load += new System.EventHandler(this.FRegulation_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVRegu)).EndInit();
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
        private System.Windows.Forms.DataGridView gVRegu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumberAirport;
        private System.Windows.Forms.TextBox txtSaleTime;
        private System.Windows.Forms.TextBox txtMinTimeStop;
        private System.Windows.Forms.TextBox txtMinTime;
        private System.Windows.Forms.TextBox txtBookTime;
        private System.Windows.Forms.TextBox txtMaxTimeStop;
        private System.Windows.Forms.TextBox txtMaxInterAp;
        private System.Windows.Forms.TextBox txtReId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_flightid;
        private System.Windows.Forms.Label lb_flight;
    }
}