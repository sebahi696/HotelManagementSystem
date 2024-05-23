using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class BillingForm : Form
    {
        private Database db;

        public BillingForm()
        {
            InitializeComponent();
            db = new Database();
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            var bills = db.GetBills();
            dgvBillDetails.DataSource = bills;
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            var bill = new Bill
            {
                ClientName = txtClientName.Text,
                TotalAmount = decimal.Parse(txtTotalAmount.Text),
                Date = DateTime.Now
            };

            db.AddBill(bill);
            LoadBillDetails();
        }
    }
}
