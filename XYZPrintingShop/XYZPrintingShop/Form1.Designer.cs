namespace XYZPrintingShop
{
    partial class Form1
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
            label1 = new Label();
            lblCustomer = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            rbColored = new RadioButton();
            rbBlackWhite = new RadioButton();
            groupBox2 = new GroupBox();
            chkRush = new CheckBox();
            chkCover = new CheckBox();
            chkBinding = new CheckBox();
            chkLamination = new CheckBox();
            groupBox3 = new GroupBox();
            rbLong = new RadioButton();
            rbA4 = new RadioButton();
            rbShort = new RadioButton();
            lblPages = new Label();
            btnCompute = new Button();
            btnNewTransaction = new Button();
            btnExit = new Button();
            listBox1 = new ListBox();
            txtCustomer = new TextBox();
            txtPages = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 37);
            label1.Name = "label1";
            label1.Size = new Size(344, 32);
            label1.TabIndex = 0;
            label1.Text = "Customer's Billing Calculator";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(15, 93);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(108, 25);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer:  ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbColored);
            groupBox1.Controls.Add(rbBlackWhite);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 108);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // rbColored
            // 
            rbColored.AutoSize = true;
            rbColored.Location = new Point(24, 65);
            rbColored.Name = "rbColored";
            rbColored.Size = new Size(154, 29);
            rbColored.TabIndex = 1;
            rbColored.TabStop = true;
            rbColored.Text = "Colored (5.00)";
            rbColored.UseVisualStyleBackColor = true;
            // 
            // rbBlackWhite
            // 
            rbBlackWhite.AutoSize = true;
            rbBlackWhite.Location = new Point(24, 30);
            rbBlackWhite.Name = "rbBlackWhite";
            rbBlackWhite.Size = new Size(220, 29);
            rbBlackWhite.TabIndex = 0;
            rbBlackWhite.TabStop = true;
            rbBlackWhite.Text = "Black and White (2.00)";
            rbBlackWhite.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkRush);
            groupBox2.Controls.Add(chkCover);
            groupBox2.Controls.Add(chkBinding);
            groupBox2.Controls.Add(chkLamination);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(330, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 179);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extras";
            // 
            // chkRush
            // 
            chkRush.AutoSize = true;
            chkRush.Location = new Point(20, 142);
            chkRush.Name = "chkRush";
            chkRush.Size = new Size(130, 29);
            chkRush.TabIndex = 3;
            chkRush.Text = "Rush (20%)";
            chkRush.UseVisualStyleBackColor = true;
            // 
            // chkCover
            // 
            chkCover.AutoSize = true;
            chkCover.Location = new Point(20, 101);
            chkCover.Name = "chkCover";
            chkCover.Size = new Size(144, 29);
            chkCover.TabIndex = 2;
            chkCover.Text = "Cover (10.00)";
            chkCover.UseVisualStyleBackColor = true;
            // 
            // chkBinding
            // 
            chkBinding.AutoSize = true;
            chkBinding.Location = new Point(20, 66);
            chkBinding.Name = "chkBinding";
            chkBinding.Size = new Size(164, 29);
            chkBinding.TabIndex = 1;
            chkBinding.Text = "Binding (50.00)";
            chkBinding.UseVisualStyleBackColor = true;
            // 
            // chkLamination
            // 
            chkLamination.AutoSize = true;
            chkLamination.Location = new Point(20, 31);
            chkLamination.Name = "chkLamination";
            chkLamination.Size = new Size(192, 29);
            chkLamination.TabIndex = 0;
            chkLamination.Text = "Lamination (20.00)";
            chkLamination.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbLong);
            groupBox3.Controls.Add(rbA4);
            groupBox3.Controls.Add(rbShort);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(29, 278);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(284, 141);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Size";
            // 
            // rbLong
            // 
            rbLong.AutoSize = true;
            rbLong.Location = new Point(24, 100);
            rbLong.Name = "rbLong";
            rbLong.Size = new Size(127, 29);
            rbLong.TabIndex = 4;
            rbLong.TabStop = true;
            rbLong.Text = "Long (1.00)";
            rbLong.UseVisualStyleBackColor = true;
            // 
            // rbA4
            // 
            rbA4.AutoSize = true;
            rbA4.Location = new Point(24, 65);
            rbA4.Name = "rbA4";
            rbA4.Size = new Size(110, 29);
            rbA4.TabIndex = 3;
            rbA4.TabStop = true;
            rbA4.Text = "A4 (0.50)";
            rbA4.UseVisualStyleBackColor = true;
            // 
            // rbShort
            // 
            rbShort.AutoSize = true;
            rbShort.Location = new Point(24, 30);
            rbShort.Name = "rbShort";
            rbShort.Size = new Size(83, 29);
            rbShort.TabIndex = 2;
            rbShort.TabStop = true;
            rbShort.Text = "Short";
            rbShort.UseVisualStyleBackColor = true;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPages.Location = new Point(330, 354);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(98, 25);
            lblPages.TabIndex = 4;
            lblPages.Text = "# of Pages";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.FromArgb(192, 255, 192);
            btnCompute.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(29, 445);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(119, 53);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += button1_Click;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.BackColor = Color.White;
            btnNewTransaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewTransaction.Location = new Point(163, 445);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(163, 53);
            btnNewTransaction.TabIndex = 6;
            btnNewTransaction.Text = "New Transaction";
            btnNewTransaction.UseVisualStyleBackColor = false;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(832, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 53);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(548, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(403, 379);
            listBox1.TabIndex = 8;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(129, 90);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(351, 31);
            txtCustomer.TabIndex = 9;
            // 
            // txtPages
            // 
            txtPages.Location = new Point(330, 388);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(155, 31);
            txtPages.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(975, 519);
            Controls.Add(txtPages);
            Controls.Add(txtCustomer);
            Controls.Add(listBox1);
            Controls.Add(btnExit);
            Controls.Add(btnNewTransaction);
            Controls.Add(btnCompute);
            Controls.Add(lblPages);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblCustomer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "XYZ Printing";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCustomer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblPages;
        private Button btnCompute;
        private Button btnNewTransaction;
        private RadioButton rbColored;
        private RadioButton rbBlackWhite;
        private CheckBox chkRush;
        private CheckBox chkCover;
        private CheckBox chkBinding;
        private CheckBox chkLamination;
        private RadioButton rbLong;
        private RadioButton rbA4;
        private RadioButton rbShort;
        private Button btnExit;
        private ListBox listBox1;
        private TextBox txtCustomer;
        private TextBox txtPages;
    }
}
