using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            RoomManagementForm roomForm = new RoomManagementForm();
            roomForm.Show();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            ReservationManagementForm reservationForm = new ReservationManagementForm();
            reservationForm.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();
        }
    }
}
