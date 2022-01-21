
namespace FlightManager
{
    partial class FBill
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
            this.gVBill = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBillid = new System.Windows.Forms.TextBox();
            this.dtbPayment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_billid = new System.Windows.Forms.Label();
            this.lb_bill = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(500, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(413, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(326, 408);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 32);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVBill);
            this.groupBox2.Location = new System.Drawing.Point(65, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 206);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gVBill
            // 
            this.gVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVBill.Location = new System.Drawing.Point(6, 21);
            this.gVBill.Name = "gVBill";
            this.gVBill.RowHeadersWidth = 51;
            this.gVBill.RowTemplate.Height = 24;
            this.gVBill.Size = new System.Drawing.Size(875, 179);
            this.gVBill.TabIndex = 0;
            this.gVBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVBill_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.txtEmpId);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtBillid);
            this.groupBox1.Controls.Add(this.dtbPayment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_billid);
            this.groupBox1.Location = new System.Drawing.Point(65, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 133);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbStatus.Location = new System.Drawing.Point(142, 76);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 6;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(508, 16);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(248, 22);
            this.txtEmpId.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(508, 43);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(248, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // txtBillid
            // 
            this.txtBillid.Location = new System.Drawing.Point(142, 16);
            this.txtBillid.Name = "txtBillid";
            this.txtBillid.Size = new System.Drawing.Size(248, 22);
            this.txtBillid.TabIndex = 5;
            // 
            // dtbPayment
            // 
            this.dtbPayment.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtbPayment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbPayment.Location = new System.Drawing.Point(142, 48);
            this.dtbPayment.Name = "dtbPayment";
            this.dtbPayment.Size = new System.Drawing.Size(248, 22);
            this.dtbPayment.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date of Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // lb_billid
            // 
            this.lb_billid.AutoSize = true;
            this.lb_billid.Location = new System.Drawing.Point(28, 22);
            this.lb_billid.Name = "lb_billid";
            this.lb_billid.Size = new System.Drawing.Size(47, 17);
            this.lb_billid.TabIndex = 0;
            this.lb_billid.Text = "Bill ID:";
            // 
            // lb_bill
            // 
            this.lb_bill.AutoSize = true;
            this.lb_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bill.ForeColor = System.Drawing.Color.Red;
            this.lb_bill.Location = new System.Drawing.Point(384, 11);
            this.lb_bill.Name = "lb_bill";
            this.lb_bill.Size = new System.Drawing.Size(101, 44);
            this.lb_bill.TabIndex = 12;
            this.lb_bill.Text = "BILL";
            // 
            // FBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_bill);
            this.Name = "FBill";
            this.Text = "FBill";
            this.Load += new System.EventHandler(this.FBill_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVBill)).EndInit();
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
        private System.Windows.Forms.DataGridView gVBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtBillid;
        private System.Windows.Forms.DateTimePicker dtbPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_billid;
        private System.Windows.Forms.Label lb_bill;
    }
}