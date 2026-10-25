namespace Resort_Booking__Bill_Calculator_
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            lblName = new Label();
            lblRooms = new Label();
            lblAdultGuests = new Label();
            lblStay = new Label();
            groupBox2 = new GroupBox();
            lblChildGuests = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnExit_Click = new Button();
            btnCompute_Click = new Button();
            btnClear_Click = new Button();
            txtName = new TextBox();
            txtRooms = new TextBox();
            txtAdults = new TextBox();
            txtStay = new TextBox();
            txtChild = new TextBox();
            txtSuubTotal = new TextBox();
            txtTax = new TextBox();
            txtResortFee = new TextBox();
            txtGrandTotal = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChild);
            groupBox1.Controls.Add(txtStay);
            groupBox1.Controls.Add(txtAdults);
            groupBox1.Controls.Add(txtRooms);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnClear_Click);
            groupBox1.Controls.Add(btnCompute_Click);
            groupBox1.Controls.Add(lblChildGuests);
            groupBox1.Controls.Add(lblStay);
            groupBox1.Controls.Add(lblAdultGuests);
            groupBox1.Controls.Add(lblRooms);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(26, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 26);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 2;
            label1.Text = "Resort Booking Application";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(157, 25);
            lblName.TabIndex = 3;
            lblName.Text = "Customer's Name:";
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Location = new Point(66, 82);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(127, 25);
            lblRooms.TabIndex = 4;
            lblRooms.Text = "No. of Rooms:";
            // 
            // lblAdultGuests
            // 
            lblAdultGuests.AutoSize = true;
            lblAdultGuests.Location = new Point(51, 190);
            lblAdultGuests.Name = "lblAdultGuests";
            lblAdultGuests.Size = new Size(172, 25);
            lblAdultGuests.TabIndex = 5;
            lblAdultGuests.Text = "No. of Adult Guests:";
            // 
            // lblStay
            // 
            lblStay.AutoSize = true;
            lblStay.Location = new Point(334, 82);
            lblStay.Name = "lblStay";
            lblStay.Size = new Size(130, 25);
            lblStay.TabIndex = 6;
            lblStay.Text = "Length of Stay:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGrandTotal);
            groupBox2.Controls.Add(txtResortFee);
            groupBox2.Controls.Add(txtTax);
            groupBox2.Controls.Add(txtSuubTotal);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(26, 405);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(526, 274);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // lblChildGuests
            // 
            lblChildGuests.AutoSize = true;
            lblChildGuests.Location = new Point(323, 190);
            lblChildGuests.Name = "lblChildGuests";
            lblChildGuests.Size = new Size(169, 25);
            lblChildGuests.TabIndex = 6;
            lblChildGuests.Text = "No. of Child Guests:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 46);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 5;
            label7.Text = "Subtotal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 103);
            label8.Name = "label8";
            label8.Size = new Size(194, 25);
            label8.TabIndex = 4;
            label8.Text = "Sales And Lodging Tax:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(191, 154);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 3;
            label9.Text = "Resort Fee:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 218);
            label10.Name = "label10";
            label10.Size = new Size(131, 25);
            label10.TabIndex = 6;
            label10.Text = "GRAND TOTAL:";
            // 
            // btnExit_Click
            // 
            btnExit_Click.Location = new Point(427, 700);
            btnExit_Click.Name = "btnExit_Click";
            btnExit_Click.Size = new Size(125, 49);
            btnExit_Click.TabIndex = 4;
            btnExit_Click.Text = "EXIT";
            btnExit_Click.UseVisualStyleBackColor = true;
            // 
            // btnCompute_Click
            // 
            btnCompute_Click.Location = new Point(98, 279);
            btnCompute_Click.Name = "btnCompute_Click";
            btnCompute_Click.Size = new Size(125, 49);
            btnCompute_Click.TabIndex = 5;
            btnCompute_Click.Text = "COMPUTE";
            btnCompute_Click.UseVisualStyleBackColor = true;
            btnCompute_Click.Click += btnCompute_Click_Click;
            // 
            // btnClear_Click
            // 
            btnClear_Click.Location = new Point(238, 279);
            btnClear_Click.Name = "btnClear_Click";
            btnClear_Click.Size = new Size(125, 49);
            btnClear_Click.TabIndex = 7;
            btnClear_Click.Text = "CLEAR";
            btnClear_Click.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(334, 31);
            txtName.TabIndex = 8;
            // 
            // txtRooms
            // 
            txtRooms.Location = new Point(80, 120);
            txtRooms.Name = "txtRooms";
            txtRooms.Size = new Size(100, 31);
            txtRooms.TabIndex = 9;
            // 
            // txtAdults
            // 
            txtAdults.Location = new Point(80, 229);
            txtAdults.Name = "txtAdults";
            txtAdults.Size = new Size(100, 31);
            txtAdults.TabIndex = 10;
            // 
            // txtStay
            // 
            txtStay.Location = new Point(344, 120);
            txtStay.Name = "txtStay";
            txtStay.Size = new Size(100, 31);
            txtStay.TabIndex = 11;
            // 
            // txtChild
            // 
            txtChild.Location = new Point(344, 229);
            txtChild.Name = "txtChild";
            txtChild.Size = new Size(100, 31);
            txtChild.TabIndex = 12;
            // 
            // txtSuubTotal
            // 
            txtSuubTotal.Location = new Point(297, 40);
            txtSuubTotal.Name = "txtSuubTotal";
            txtSuubTotal.Size = new Size(127, 31);
            txtSuubTotal.TabIndex = 13;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(297, 97);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(127, 31);
            txtTax.TabIndex = 14;
            // 
            // txtResortFee
            // 
            txtResortFee.Location = new Point(297, 148);
            txtResortFee.Name = "txtResortFee";
            txtResortFee.Size = new Size(127, 31);
            txtResortFee.TabIndex = 15;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(297, 212);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.Size = new Size(127, 31);
            txtGrandTotal.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 759);
            Controls.Add(btnExit_Click);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Resort Booking Application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private Button btnClear_Click;
        private Button btnCompute_Click;
        private Label lblChildGuests;
        private Label lblStay;
        private Label lblAdultGuests;
        private Label lblRooms;
        private Label lblName;
        private Label label1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnExit_Click;
        private TextBox txtChild;
        private TextBox txtStay;
        private TextBox txtAdults;
        private TextBox txtRooms;
        private TextBox txtGrandTotal;
        private TextBox txtResortFee;
        private TextBox txtTax;
        private TextBox txtSuubTotal;
    }
}
