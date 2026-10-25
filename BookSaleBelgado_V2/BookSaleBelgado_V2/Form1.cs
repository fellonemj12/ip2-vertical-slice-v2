using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BookSaleBelgado_V2
{
    public partial class frmBookSale : Form
    {
       
        private int totalBooksSold = 0;
        private decimal totalDiscountGiven = 0m;
        private decimal totalDiscountedAmount = 0m;
        private int totalTransactions = 0;

        // Standard 15% discount constant
        private const decimal DISCOUNT_RATE = 0.15m;

        public frmBookSale()
        {
            InitializeComponent();

            // Wire up event handlers for buttons
            btnClear.Click += btnClear_Click;
            btnPrint.Click += btnPrint_Click;
            btnExit.Click += btnExit_Click;
        }

        // --- Calculate Button Event ---
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Validate Inputs
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer for Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a Book Title.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                txtPrice.SelectAll();
                return;
            }

            // 2. Perform Current Sale Calculations
            decimal extendedPrice = quantity * price;
            decimal discountAmount = extendedPrice * DISCOUNT_RATE;
            decimal discountedPrice = extendedPrice - discountAmount;

            // 3. Accumulate Running Summary Totals
            totalBooksSold += quantity;
            totalDiscountGiven += discountAmount;
            totalDiscountedAmount += discountedPrice;
            totalTransactions++;

            decimal averageDiscount = totalDiscountGiven / totalTransactions;

            // 4. Output Current Sale Results
            txtExtPrice.Text = extendedPrice.ToString("N2");
            txtDiscount.Text = discountAmount.ToString("N2");
            txtDiscPrice.Text = discountedPrice.ToString("N2");

            // 5. Output Summary Results
            txtNumofBooks.Text = totalBooksSold.ToString();
            txtDiscGiven.Text = totalDiscountGiven.ToString("N2");
            txtDiscAmount.Text = totalDiscountedAmount.ToString("N2");
            txtAveDisc.Text = averageDiscount.ToString("N2");

            // Lock Input TextBoxes until 'Clear Sale' is clicked
            txtQuantity.ReadOnly = true;
            txtTitle.ReadOnly = true;
            txtPrice.ReadOnly = true;
        }

        // --- Clear Sale Button Event ---
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear current inputs
            txtQuantity.Clear();
            txtTitle.Clear();
            txtPrice.Clear();

            // Re-enable input controls
            txtQuantity.ReadOnly = false;
            txtTitle.ReadOnly = false;
            txtPrice.ReadOnly = false;

            // Clear current sale output fields
            txtExtPrice.Clear();
            txtDiscount.Clear();
            txtDiscPrice.Clear();

            // Move focus to Quantity for next entry
            txtQuantity.Focus();
        }

        // --- Print Form Button Event ---
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintForm_PrintPage);

            PrintPreviewDialog previewDlg = new PrintPreviewDialog
            {
                Document = printDoc
            };
            previewDlg.ShowDialog();
        }

        private void PrintForm_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap memoryImage = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(memoryImage, new Rectangle(0, 0, this.Width, this.Height));
            if (e.Graphics != null)
            {
                e.Graphics.DrawImage(memoryImage, 0, 0);
            }
        }

        // --- Exit Button Event ---
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}