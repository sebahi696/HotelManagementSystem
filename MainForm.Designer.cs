namespace HotelManagementSystem
{
    partial class MainForm
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
            this.btnManageRooms = new System.Windows.Forms.Button();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.Location = new System.Drawing.Point(50, 50);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(200, 50);
            this.btnManageRooms.TabIndex = 0;
            this.btnManageRooms.Text = "Manage Rooms";
            this.btnManageRooms.UseVisualStyleBackColor = true;
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.Location = new System.Drawing.Point(50, 130);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(200, 50);
            this.btnManageReservations.TabIndex = 1;
            this.btnManageReservations.Text = "Manage Reservations";
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(50, 210);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(200, 50);
            this.btnBilling.TabIndex = 2;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.btnManageRooms);
            this.Name = "MainForm";
            this.Text = "Hotel Management System";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnManageRooms;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnBilling;
    }
}
