using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ReservationManagementForm : Form
    {
        private Database db;

        public ReservationManagementForm()
        {
            InitializeComponent();
            db = new Database();
            LoadReservations();
        }

        private void LoadReservations()
        {
            var reservations = db.GetReservations();
            dgvReservations.DataSource = reservations;
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                ClientName = txtClientName.Text,
                RoomId = int.Parse(txtRoom.Text),
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            db.AddReservation(reservation);
            LoadReservations();
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            var reservation = new Reservation
            {
                Id = int.Parse(dgvReservations.SelectedRows[0].Cells[0].Value.ToString()),
                ClientName = txtClientName.Text,
                RoomId = int.Parse(txtRoom.Text),
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            db.UpdateReservation(reservation);
            LoadReservations();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            int reservationId = int.Parse(dgvReservations.SelectedRows[0].Cells[0].Value.ToString());
            db.DeleteReservation(reservationId);
            LoadReservations();
        }
    }
}
