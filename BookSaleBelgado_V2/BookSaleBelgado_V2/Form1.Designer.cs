namespace BookSaleBelgado_V2
{
    partial class frmBookSale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnPrint = new Button();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblQuantity = new Label();
            lblTitle = new Label();
            lblPrice = new Label();
            lblExtPrice = new Label();
            lblDiscount = new Label();
            lblDiscPrice = new Label();
            lblNumofBooks = new Label();
            lblDiscGiven = new Label();
            lblDiscAmount = new Label();
            lblAveDisc = new Label();
            txtQuantity = new TextBox();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtExtPrice = new TextBox();
            txtDiscount = new TextBox();
            txtDiscPrice = new TextBox();
            txtNumofBooks = new TextBox();
            txtDiscGiven = new TextBox();
            txtDiscAmount = new TextBox();
            txtAveDisc = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Location = new Point(18, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDiscPrice);
            groupBox2.Controls.Add(txtDiscount);
            groupBox2.Controls.Add(txtExtPrice);
            groupBox2.Controls.Add(lblDiscPrice);
            groupBox2.Controls.Add(lblDiscount);
            groupBox2.Controls.Add(lblExtPrice);
            groupBox2.Location = new Point(18, 212);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(555, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAveDisc);
            groupBox3.Controls.Add(txtDiscAmount);
            groupBox3.Controls.Add(txtDiscGiven);
            groupBox3.Controls.Add(txtNumofBooks);
            groupBox3.Controls.Add(lblAveDisc);
            groupBox3.Controls.Add(lblDiscAmount);
            groupBox3.Controls.Add(lblDiscGiven);
            groupBox3.Controls.Add(lblNumofBooks);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(18, 433);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(555, 242);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Summary";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(192, 255, 255);
            btnPrint.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(18, 698);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(115, 30);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print Form";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(192, 255, 255);
            btnCalculate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(163, 698);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(115, 30);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(316, 698);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 30);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear Sale";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(458, 698);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(37, 27);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(92, 25);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Quantity:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(37, 81);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(37, 133);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 25);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // lblExtPrice
            // 
            lblExtPrice.AutoSize = true;
            lblExtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtPrice.Location = new Point(129, 50);
            lblExtPrice.Name = "lblExtPrice";
            lblExtPrice.Size = new Size(144, 25);
            lblExtPrice.TabIndex = 3;
            lblExtPrice.Text = "Extended Price:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(134, 100);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(133, 25);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "15% Discount:";
            // 
            // lblDiscPrice
            // 
            lblDiscPrice.AutoSize = true;
            lblDiscPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscPrice.Location = new Point(112, 153);
            lblDiscPrice.Name = "lblDiscPrice";
            lblDiscPrice.Size = new Size(160, 25);
            lblDiscPrice.TabIndex = 5;
            lblDiscPrice.Text = "Discounted Price:";
            // 
            // lblNumofBooks
            // 
            lblNumofBooks.AutoSize = true;
            lblNumofBooks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumofBooks.Location = new Point(15, 41);
            lblNumofBooks.Name = "lblNumofBooks";
            lblNumofBooks.Size = new Size(216, 25);
            lblNumofBooks.TabIndex = 6;
            lblNumofBooks.Text = "Total Number Of Books:";
            // 
            // lblDiscGiven
            // 
            lblDiscGiven.AutoSize = true;
            lblDiscGiven.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscGiven.Location = new Point(15, 96);
            lblDiscGiven.Name = "lblDiscGiven";
            lblDiscGiven.Size = new Size(193, 25);
            lblDiscGiven.TabIndex = 7;
            lblDiscGiven.Text = "Total Discount Given:";
            // 
            // lblDiscAmount
            // 
            lblDiscAmount.AutoSize = true;
            lblDiscAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscAmount.Location = new Point(15, 150);
            lblDiscAmount.Name = "lblDiscAmount";
            lblDiscAmount.Size = new Size(239, 25);
            lblDiscAmount.TabIndex = 8;
            lblDiscAmount.Text = "Total Discounted  Amount:";
            // 
            // lblAveDisc
            // 
            lblAveDisc.AutoSize = true;
            lblAveDisc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAveDisc.Location = new Point(13, 201);
            lblAveDisc.Name = "lblAveDisc";
            lblAveDisc.Size = new Size(168, 25);
            lblAveDisc.TabIndex = 9;
            lblAveDisc.Text = "Average Discount:";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.ScrollBar;
            txtQuantity.ForeColor = SystemColors.WindowText;
            txtQuantity.Location = new Point(192, 21);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(144, 31);
            txtQuantity.TabIndex = 3;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.ScrollBar;
            txtTitle.Location = new Point(192, 75);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(349, 31);
            txtTitle.TabIndex = 4;
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.ScrollBar;
            txtPrice.Location = new Point(192, 127);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(144, 31);
            txtPrice.TabIndex = 5;
            txtPrice.Text = "0.00";
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtExtPrice
            // 
            txtExtPrice.BackColor = SystemColors.ScrollBar;
            txtExtPrice.Location = new Point(397, 44);
            txtExtPrice.Name = "txtExtPrice";
            txtExtPrice.Size = new Size(144, 31);
            txtExtPrice.TabIndex = 6;
            txtExtPrice.Text = "0.00";
            txtExtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = SystemColors.ScrollBar;
            txtDiscount.Location = new Point(397, 94);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(144, 31);
            txtDiscount.TabIndex = 7;
            txtDiscount.Text = "0.00";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDiscPrice
            // 
            txtDiscPrice.BackColor = SystemColors.ScrollBar;
            txtDiscPrice.Location = new Point(397, 147);
            txtDiscPrice.Name = "txtDiscPrice";
            txtDiscPrice.Size = new Size(144, 31);
            txtDiscPrice.TabIndex = 8;
            txtDiscPrice.Text = "0.00";
            txtDiscPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNumofBooks
            // 
            txtNumofBooks.BackColor = SystemColors.ScrollBar;
            txtNumofBooks.Location = new Point(319, 35);
            txtNumofBooks.Name = "txtNumofBooks";
            txtNumofBooks.Size = new Size(211, 31);
            txtNumofBooks.TabIndex = 10;
            txtNumofBooks.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDiscGiven
            // 
            txtDiscGiven.BackColor = SystemColors.ScrollBar;
            txtDiscGiven.Location = new Point(319, 90);
            txtDiscGiven.Name = "txtDiscGiven";
            txtDiscGiven.Size = new Size(211, 31);
            txtDiscGiven.TabIndex = 11;
            txtDiscGiven.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDiscAmount
            // 
            txtDiscAmount.BackColor = SystemColors.ScrollBar;
            txtDiscAmount.Location = new Point(319, 144);
            txtDiscAmount.Name = "txtDiscAmount";
            txtDiscAmount.Size = new Size(211, 31);
            txtDiscAmount.TabIndex = 12;
            txtDiscAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAveDisc
            // 
            txtAveDisc.BackColor = SystemColors.ScrollBar;
            txtAveDisc.Location = new Point(319, 195);
            txtAveDisc.Name = "txtAveDisc";
            txtAveDisc.Size = new Size(211, 31);
            txtAveDisc.TabIndex = 13;
            txtAveDisc.TextAlign = HorizontalAlignment.Right;
            // 
            // frmBookSale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 745);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(btnPrint);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBookSale";
            Text = "Book Sale Program";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPrice;
        private TextBox txtTitle;
        private TextBox txtQuantity;
        private Label lblPrice;
        private Label lblTitle;
        private Label lblQuantity;
        private TextBox txtDiscPrice;
        private TextBox txtDiscount;
        private TextBox txtExtPrice;
        private Label lblDiscPrice;
        private Label lblDiscount;
        private Label lblExtPrice;
        private GroupBox groupBox3;
        private Label lblAveDisc;
        private Label lblDiscAmount;
        private Label lblDiscGiven;
        private Label lblNumofBooks;
        private Button btnPrint;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtAveDisc;
        private TextBox txtDiscAmount;
        private TextBox txtDiscGiven;
        private TextBox txtNumofBooks;
    }
}
