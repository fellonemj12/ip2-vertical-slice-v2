using System;
using System.Windows.Forms;

namespace Lab_Sheet_04_Belgado
{
    public partial class Form1 : Form
    {
     
        const int intMAX_PER_ROOM = 6;
        const decimal decDAILY_ROOM_CHARGE = 6275.0M;
        const decimal decTAX_RATE = 0.1625M;
        const decimal decDAILY_RESORT_FEE = 625.5M;
        const string strMAX_MSG = "You have exceeded the maximum guests per room";

       
        private int totalTransactions = 0;
        private int totalRooms = 0;
        private int totalGuests = 0;
        private decimal totalTransactionAmount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
               
                int intRoomReserved = int.Parse(txtRooms.Text);
                int intNights = int.Parse(txtNights.Text);
                int intAdults = int.Parse(txtAdults.Text);
                int intChildren = int.Parse(txtChildren.Text);

                int intNumOfGuests = intAdults + intChildren; 
                double dblRoomsRequired = intNumOfGuests / (double)intMAX_PER_ROOM; 

                if (intRoomReserved < dblRoomsRequired) 
                {
                    MessageBox.Show(strMAX_MSG, "Treeline Resort",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                  
                    decimal decTotalRoomCharge = intRoomReserved * intNights * decDAILY_ROOM_CHARGE; 
                    decimal decTax = decTotalRoomCharge * decTAX_RATE; 
                    decimal decTotalResortFee = intRoomReserved * intNights * decDAILY_RESORT_FEE; 
                    decimal decTotalDue = decTotalRoomCharge + decTax + decTotalResortFee; 

                  
                    txtRoomCharge.Text = decTotalRoomCharge.ToString("n2"); 
                    txtTax.Text = decTax.ToString("n2"); 
                    txtResortFee.Text = decTotalResortFee.ToString("n2"); 
                    txtTotalDue.Text = decTotalDue.ToString("n2"); 

                   
                    totalTransactions++;
                    totalRooms += intRoomReserved;
                    totalGuests += intNumOfGuests;
                    totalTransactionAmount += decTotalDue;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numeric values in all input fields.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRooms.Clear();
            txtNights.Clear();
            txtAdults.Clear();
            txtChildren.Clear();

            txtRoomCharge.Clear();
            txtTax.Clear();
            txtResortFee.Clear();
            txtTotalDue.Clear();

            txtRooms.Focus();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string summaryMessage = $"Total Transactions: {totalTransactions}\n" +
                                   $"Total Rooms: {totalRooms}\n" +
                                   $"Total Guests: {totalGuests}\n" +
                                   $"Transaction Amount: {totalTransactionAmount:n2}";

            MessageBox.Show(summaryMessage, "Transaction Summary Today",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}