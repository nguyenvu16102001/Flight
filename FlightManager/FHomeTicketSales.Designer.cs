
namespace FlightManager
{
    partial class FHomeTicketSales
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
            this.btnFlightScheduling = new System.Windows.Forms.Button();
            this.btnTicketSales = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFlightScheduling
            // 
            this.btnFlightScheduling.Location = new System.Drawing.Point(100, 371);
            this.btnFlightScheduling.Name = "btnFlightScheduling";
            this.btnFlightScheduling.Size = new System.Drawing.Size(305, 51);
            this.btnFlightScheduling.TabIndex = 0;
            this.btnFlightScheduling.Text = "Lập Lịch Chuyến Bay";
            this.btnFlightScheduling.UseVisualStyleBackColor = true;
            this.btnFlightScheduling.Click += new System.EventHandler(this.btnFlightScheduling_Click);
            // 
            // btnTicketSales
            // 
            this.btnTicketSales.Location = new System.Drawing.Point(100, 174);
            this.btnTicketSales.Name = "btnTicketSales";
            this.btnTicketSales.Size = new System.Drawing.Size(305, 51);
            this.btnTicketSales.TabIndex = 1;
            this.btnTicketSales.Text = "Bán Vé";
            this.btnTicketSales.UseVisualStyleBackColor = true;
            this.btnTicketSales.Click += new System.EventHandler(this.btnTicketSales_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(100, 271);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(305, 51);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trang Chủ";
            // 
            // FHomeTicketSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTicketSales);
            this.Controls.Add(this.btnFlightScheduling);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FHomeTicketSales";
            this.Text = "FHomeTicketSales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlightScheduling;
        private System.Windows.Forms.Button btnTicketSales;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}