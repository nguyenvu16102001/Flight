
namespace FlightManager
{
    partial class FSearch
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
            this.cbArrivalAirport = new System.Windows.Forms.ComboBox();
            this.cbDepartureAirport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPDepartureDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.dGVFlight = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Chuyến Bay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbArrivalAirport);
            this.groupBox1.Controls.Add(this.cbDepartureAirport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dTPDepartureDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(77, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbArrivalAirport
            // 
            this.cbArrivalAirport.FormattingEnabled = true;
            this.cbArrivalAirport.Location = new System.Drawing.Point(234, 122);
            this.cbArrivalAirport.Name = "cbArrivalAirport";
            this.cbArrivalAirport.Size = new System.Drawing.Size(392, 37);
            this.cbArrivalAirport.TabIndex = 5;
            // 
            // cbDepartureAirport
            // 
            this.cbDepartureAirport.FormattingEnabled = true;
            this.cbDepartureAirport.Location = new System.Drawing.Point(234, 60);
            this.cbDepartureAirport.Name = "cbDepartureAirport";
            this.cbDepartureAirport.Size = new System.Drawing.Size(392, 37);
            this.cbDepartureAirport.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian bay:";
            // 
            // dTPDepartureDay
            // 
            this.dTPDepartureDay.CustomFormat = "dd/MM/yyyy";
            this.dTPDepartureDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDepartureDay.Location = new System.Drawing.Point(234, 185);
            this.dTPDepartureDay.Name = "dTPDepartureDay";
            this.dTPDepartureDay.Size = new System.Drawing.Size(392, 34);
            this.dTPDepartureDay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sân bay đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sân bay đi:";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(934, 315);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(142, 42);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Tìm Kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dGVFlight
            // 
            this.dGVFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFlight.Location = new System.Drawing.Point(77, 378);
            this.dGVFlight.Name = "dGVFlight";
            this.dGVFlight.RowHeadersWidth = 51;
            this.dGVFlight.RowTemplate.Height = 24;
            this.dGVFlight.Size = new System.Drawing.Size(1058, 333);
            this.dGVFlight.TabIndex = 3;
            this.dGVFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVFlight_CellClick);
            // 
            // FSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 732);
            this.Controls.Add(this.dGVFlight);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbArrivalAirport;
        private System.Windows.Forms.ComboBox cbDepartureAirport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPDepartureDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dGVFlight;
    }
}