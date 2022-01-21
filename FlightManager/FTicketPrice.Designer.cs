
namespace FlightManager
{
    partial class FTicketPrice
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
            this.gVPrice = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFlightid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.lb_flightId = new System.Windows.Forms.Label();
            this.lb_price_ticket = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(457, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(370, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(283, 408);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(81, 32);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gVPrice);
            this.groupBox2.Location = new System.Drawing.Point(22, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 206);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // gVPrice
            // 
            this.gVPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVPrice.Location = new System.Drawing.Point(6, 21);
            this.gVPrice.Name = "gVPrice";
            this.gVPrice.RowHeadersWidth = 51;
            this.gVPrice.RowTemplate.Height = 24;
            this.gVPrice.Size = new System.Drawing.Size(875, 179);
            this.gVPrice.TabIndex = 0;
            this.gVPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVPrice_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtFlightid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_Price);
            this.groupBox1.Controls.Add(this.lb_quantity);
            this.groupBox1.Controls.Add(this.lb_flightId);
            this.groupBox1.Location = new System.Drawing.Point(22, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 133);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(508, 16);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(248, 22);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(142, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(248, 22);
            this.txtPrice.TabIndex = 5;
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
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ticket Type:";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(28, 52);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(44, 17);
            this.lb_Price.TabIndex = 0;
            this.lb_Price.Text = "Price:";
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Location = new System.Drawing.Point(416, 50);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(65, 17);
            this.lb_quantity.TabIndex = 0;
            this.lb_quantity.Text = "Quantity:";
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
            // lb_price_ticket
            // 
            this.lb_price_ticket.AutoSize = true;
            this.lb_price_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price_ticket.ForeColor = System.Drawing.Color.Red;
            this.lb_price_ticket.Location = new System.Drawing.Point(321, 11);
            this.lb_price_ticket.Name = "lb_price_ticket";
            this.lb_price_ticket.Size = new System.Drawing.Size(289, 44);
            this.lb_price_ticket.TabIndex = 18;
            this.lb_price_ticket.Text = "TICKET PRICE";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(508, 45);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(248, 22);
            this.txtType.TabIndex = 5;
            // 
            // FTicketPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_price_ticket);
            this.Name = "FTicketPrice";
            this.Text = "FTicketPrice";
            this.Load += new System.EventHandler(this.FTicketPrice_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVPrice)).EndInit();
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
        private System.Windows.Forms.DataGridView gVPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFlightid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.Label lb_flightId;
        private System.Windows.Forms.Label lb_price_ticket;
        private System.Windows.Forms.TextBox txtType;
    }
}