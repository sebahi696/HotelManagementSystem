using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class RoomManagementForm : Form
    {
        private Database db;

        public RoomManagementForm()
        {
            InitializeComponent();
            db = new Database();
            LoadRooms();
        }

        private void LoadRooms()
        {
            var rooms = db.GetRooms();
            dgvRooms.DataSource = rooms;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var room = new Room
            {
                Floor = int.Parse(txtFloor.Text),
                Type = txtType.Text,
                Price = decimal.Parse(txtPrice.Text),
                Status = txtStatus.Text,
                Beds = int.Parse(txtBeds.Text)
            };

            db.AddRoom(room);
            LoadRooms();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            var room = new Room
            {
                Id = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString()),
                Floor = int.Parse(txtFloor.Text),
                Type = txtType.Text,
                Price = decimal.Parse(txtPrice.Text),
                Status = txtStatus.Text,
                Beds = int.Parse(txtBeds.Text)
            };

            db.UpdateRoom(room);
            LoadRooms();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            int roomId = int.Parse(dgvRooms.SelectedRows[0].Cells[0].Value.ToString());
            db.DeleteRoom(roomId);
            LoadRooms();
        }
    }
}
