using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace LabSheet5_Belgado
{
    public partial class Form1 : Form
    {
      
        private const decimal RATE_TWO_QUEEN_STANDARD = 1500.00m;
        private const decimal RATE_TWO_QUEEN_ATRIUM = 2500.00m;
        private const decimal RATE_ONE_KING_STANDARD = 1900.00m;
        private const decimal RATE_ONE_KING_ATRIUM = 3200.00m;

        private const decimal PARKING_FEE_PER_NIGHT = 300.00m;
        private const decimal RESORT_FEE_PER_ROOM_NIGHT = 2000.00m;
        private const decimal TAX_RATE = 0.1525m; 
        private const int MAX_GUESTS_PER_ROOM = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                int rooms = int.Parse(txtRooms.Text);
                int nights = int.Parse(txtNights.Text);
                int adults = int.Parse(txtAdults.Text);
                int children = int.Parse(txtChildren.Text);


                if (rooms <= 0 || nights <= 0 || adults < 0 || children < 0)
                {
                    MessageBox.Show("Please enter valid positive numbers for rooms, nights, and guests.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalGuests = adults + children;
                int maxCapacity = rooms * MAX_GUESTS_PER_ROOM;

                if (totalGuests > maxCapacity)
                {
                    MessageBox.Show($"Insufficient rooms! Total guests ({totalGuests}) exceed the maximum capacity for {rooms} room(s) (Max capacity: {maxCapacity}). Please reserve more rooms.", "Capacity Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal ratePerRoomPerNight = 0.0m;

                if (rbTwoQueen.Checked)
                {
                    if (rbStandard.Checked)
                        ratePerRoomPerNight = RATE_TWO_QUEEN_STANDARD;
                    else if (rbAtrium.Checked)
                        ratePerRoomPerNight = RATE_TWO_QUEEN_ATRIUM;
                }
                else if (rbOneKing.Checked)
                {
                    if (rbStandard.Checked)
                        ratePerRoomPerNight = RATE_ONE_KING_STANDARD;
                    else if (rbAtrium.Checked)
                        ratePerRoomPerNight = RATE_ONE_KING_ATRIUM;
                }
                else
                {
                    MessageBox.Show("Please select a bed type (Two Queen or One King).", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!rbStandard.Checked && !rbAtrium.Checked)
                {
                    MessageBox.Show("Please select a view type (Standard or Atrium).", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                decimal totalRoomCharge = ratePerRoomPerNight * rooms * nights;
                decimal salesTax = totalRoomCharge * TAX_RATE;
                decimal resortFee = RESORT_FEE_PER_ROOM_NIGHT * rooms * nights;

                decimal totalParkingFee = 0.0m;
                if (chkParking.Checked)
                {
                    totalParkingFee = PARKING_FEE_PER_NIGHT * nights;
                }

                decimal totalDue = totalRoomCharge + salesTax + resortFee + totalParkingFee;


                textBox5.Text = totalRoomCharge.ToString("C2");
                textBox6.Text = salesTax.ToString("C2");
                textBox7.Text = resortFee.ToString("C2");
                textBox8.Text = totalParkingFee.ToString("C2");
                textBox9.Text = totalDue.ToString("C2");
            
            }
                catch (FormatException)
            {
                MessageBox.Show("Please ensure all input text boxes contain valid numbers.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}