using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Resort_Booking__Bill_Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click_Click(object sender, EventArgs e)
        {
            int numOfRooms = 0;
            int lengthOfStay = 0;
            int adultGuests = 0;
            int childGuests = 0;

            double roomRatePerNight = 1000.00;
            double adultRatePerNight = 150.00;
            double childRatePerNight = 75.00;
            double resortFee = 300.00;
            double taxRate = 0.15;

            int.TryParse(txtRooms.Text, out numOfRooms);
            int.TryParse(txtStay.Text, out lengthOfStay);
            int.TryParse(txtAdults.Text, out adultGuests);
            int.TryParse(txtChild.Text, out childGuests);

            double nightlyRoomCost = (numOfRooms * roomRatePerNight) +
                                     (adultGuests * adultRatePerNight) +
                                     (childRatePerNight * childGuests);

            double subTotal = nightlyRoomCost * lengthOfStay;
            double tax = subTotal * taxRate;
            double grandTotal = subTotal + tax + resortFee;

            txtSuubTotal.Text = subTotal.ToString("N2");
            txtTax.Text = tax.ToString("N2");
            txtResortFee.Text = resortFee.ToString("N2");
            txtGrandTotal.Text = grandTotal.ToString("N2");
        }

        private void btnClear_Click_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtRooms.Clear();
            txtStay.Clear();
            txtAdults.Clear();
            txtChild.Clear();

            txtSuubTotal.Text = "0.00";
            txtTax.Text = "0.00";
            txtResortFee.Text = "0.00";
            txtGrandTotal.Text = "0.00";

            txtName.Focus();
        }
        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            DialogResult resulr = MessageBox.Show("Are You Sure You Want To Exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
