using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZPrintingShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtPages.Text, out int pages) || pages <= 0)
            {
                MessageBox.Show("Please enter a valid number of pages.");
                return;
            }

            double baseRate = 0;
            string colorChoice = "";


            if (rbBlackWhite.Checked)
            {
                baseRate = 2.00;
                colorChoice = "Black and White (2.00)";
            }
            else if (rbColored.Checked)
            {
                baseRate = 5.00;
                colorChoice = "Colored (5.00)";
            }
            else
            {
                MessageBox.Show("Please select a color option.");
                return;
            }

            double subtotal = baseRate * pages;


            string sizeText = "Standard/Short";
            if (rbA4.Checked)
            {
                subtotal += (0.50 * pages);
                sizeText = "A4 (0.50)";
            }
            else if (rbLong.Checked)
            {
                subtotal += (1.00 * pages);
                sizeText = "Long (1.00)";
            }


            double extrasTotal = 0;
            string extrasList = "";

            if (chkLamination.Checked) { extrasTotal += 20.00; extrasList += "\n+ Lamination (20.00)"; }
            if (chkBinding.Checked) { extrasTotal += 50.00; extrasList += "\n+ Binding (50.00)"; }
            if (chkCover.Checked) { extrasTotal += 10.00; extrasList += "\n+ Cover (10.00)"; }

            double totalBeforeRush = subtotal + extrasTotal;


            if (chkRush.Checked)
            {
                totalBeforeRush += (totalBeforeRush * 0.20);
                extrasList += "\n+ Rush Fee (20%)";
            }


            listBox1.Items.Clear();
            listBox1.Items.Add("=== RECEIPT ===");
            listBox1.Items.Add("Customer: " + txtCustomer.Text);
            listBox1.Items.Add("Color: " + colorChoice);
            listBox1.Items.Add("Size: " + sizeText);
            listBox1.Items.Add("Pages: " + pages);
            if (!string.IsNullOrEmpty(extrasList))
            {
                listBox1.Items.Add("Extras selected:" + extrasList);
            }
            listBox1.Items.Add("-------------------");
            listBox1.Items.Add("Total Due: " + totalBeforeRush.ToString("C2"));
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {

            txtCustomer.Clear();
            txtPages.Clear();
            rbBlackWhite.Checked = false;
            rbColored.Checked = false;
            rbShort.Checked = false;
            rbA4.Checked = false;
            rbLong.Checked = false;
            chkLamination.Checked = false;
            chkBinding.Checked = false;
            chkCover.Checked = false;
            chkRush.Checked = false;
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}