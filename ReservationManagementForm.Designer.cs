namespace HotelManagementSystem
{
    partial class ReservationManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(50, 250);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(100, 30);
            this.btnAddReservation.TabIndex = 0;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.Location = new System.Drawing.Point(180, 250);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateReservation.TabIndex = 1;
            this.btnUpdateReservation.Text = "Update Reservation";
            this.btnUpdateReservation.UseVisualStyleBackColor = true;
            this.btnUpdateReservation.Click += new System.EventHandler(this.btnUpdateReservation_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(310, 250);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteReservation.TabIndex = 2;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(50, 50);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(600, 150);
            this.dgvReservations.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(50, 220);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(82, 17);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(138, 217);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 22);
            this.txtClientName.TabIndex = 5;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(250, 220);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(45, 17);
            this.lblRoom.TabIndex = 6;
            this.lblRoom.Text = "Room";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(301, 217);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 22);
            this.txtRoom.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(410, 220);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 17);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(488, 217);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 9;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(410, 260);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 17);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(488, 257);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 11;
            // 
            // ReservationManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnUpdateReservation);
            this.Controls.Add(this.btnAddReservation);
            this.Name = "ReservationManagementForm";
            this.Text = "Reservation Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}
