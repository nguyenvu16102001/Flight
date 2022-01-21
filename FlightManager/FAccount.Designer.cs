
namespace FlightManager
{
    partial class FAccount
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
            this.gVAccount = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_UserRole = new System.Windows.Forms.ComboBox();
            this.cbActive = new System.Windows.Forms.ComboBox();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAccountid = new System.Windows.Forms.TextBox();
            this.dtbJointdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_jointdate = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lb_accountid = new System.Windows.Forms.Label();
            this.lb_flight = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(468, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(381, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(294, 408);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 32);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVAccount);
            this.groupBox2.Location = new System.Drawing.Point(33, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 206);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gVAccount
            // 
            this.gVAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVAccount.Location = new System.Drawing.Point(6, 21);
            this.gVAccount.Name = "gVAccount";
            this.gVAccount.RowHeadersWidth = 51;
            this.gVAccount.RowTemplate.Height = 24;
            this.gVAccount.Size = new System.Drawing.Size(875, 179);
            this.gVAccount.TabIndex = 0;
            this.gVAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVAccount_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_UserRole);
            this.groupBox1.Controls.Add(this.cbActive);
            this.groupBox1.Controls.Add(this.txtUserid);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtAccountid);
            this.groupBox1.Controls.Add(this.dtbJointdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_jointdate);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.lb_accountid);
            this.groupBox1.Location = new System.Drawing.Point(33, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 133);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cb_UserRole
            // 
            this.cb_UserRole.FormattingEnabled = true;
            this.cb_UserRole.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_UserRole.Location = new System.Drawing.Point(138, 106);
            this.cb_UserRole.Name = "cb_UserRole";
            this.cb_UserRole.Size = new System.Drawing.Size(110, 24);
            this.cb_UserRole.TabIndex = 6;
            // 
            // cbActive
            // 
            this.cbActive.FormattingEnabled = true;
            this.cbActive.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbActive.Location = new System.Drawing.Point(504, 75);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(110, 24);
            this.cbActive.TabIndex = 6;
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(504, 16);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(248, 22);
            this.txtUserid.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(504, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(138, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(248, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtAccountid
            // 
            this.txtAccountid.Location = new System.Drawing.Point(138, 16);
            this.txtAccountid.Name = "txtAccountid";
            this.txtAccountid.Size = new System.Drawing.Size(248, 22);
            this.txtAccountid.TabIndex = 5;
            // 
            // dtbJointdate
            // 
            this.dtbJointdate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtbJointdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbJointdate.Location = new System.Drawing.Point(138, 75);
            this.dtbJointdate.Name = "dtbJointdate";
            this.dtbJointdate.Size = new System.Drawing.Size(248, 22);
            this.dtbJointdate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // lb_jointdate
            // 
            this.lb_jointdate.AutoSize = true;
            this.lb_jointdate.Location = new System.Drawing.Point(24, 80);
            this.lb_jointdate.Name = "lb_jointdate";
            this.lb_jointdate.Size = new System.Drawing.Size(72, 17);
            this.lb_jointdate.TabIndex = 0;
            this.lb_jointdate.Text = "Join Date:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(24, 52);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 17);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Active:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(392, 19);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(59, 17);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "User ID:";
            // 
            // lb_accountid
            // 
            this.lb_accountid.AutoSize = true;
            this.lb_accountid.Location = new System.Drawing.Point(24, 22);
            this.lb_accountid.Name = "lb_accountid";
            this.lb_accountid.Size = new System.Drawing.Size(80, 17);
            this.lb_accountid.TabIndex = 0;
            this.lb_accountid.Text = "Account ID:";
            // 
            // lb_flight
            // 
            this.lb_flight.AutoSize = true;
            this.lb_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_flight.ForeColor = System.Drawing.Color.Red;
            this.lb_flight.Location = new System.Drawing.Point(352, 11);
            this.lb_flight.Name = "lb_flight";
            this.lb_flight.Size = new System.Drawing.Size(213, 44);
            this.lb_flight.TabIndex = 12;
            this.lb_flight.Text = "ACCOUNT";
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_flight);
            this.Name = "FAccount";
            this.Text = "FAccount";
            this.Load += new System.EventHandler(this.FAccount_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVAccount)).EndInit();
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
        private System.Windows.Forms.DataGridView gVAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAccountid;
        private System.Windows.Forms.DateTimePicker dtbJointdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_jointdate;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lb_accountid;
        private System.Windows.Forms.Label lb_flight;
        private System.Windows.Forms.ComboBox cbActive;
        private System.Windows.Forms.ComboBox cb_UserRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
    }
}