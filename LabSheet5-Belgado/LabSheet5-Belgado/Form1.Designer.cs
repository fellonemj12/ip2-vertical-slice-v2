namespace LabSheet5_Belgado
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            rbOneKing = new RadioButton();
            rbTwoQueen = new RadioButton();
            groupBox2 = new GroupBox();
            rbAtrium = new RadioButton();
            rbStandard = new RadioButton();
            groupBox3 = new GroupBox();
            txtChildren = new TextBox();
            txtAdults = new TextBox();
            txtNights = new TextBox();
            txtRooms = new TextBox();
            lblChildren = new Label();
            lblAdults = new Label();
            lblNights = new Label();
            lblRooms = new Label();
            groupBox4 = new GroupBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            lblTotalDue = new Label();
            lblParkingFee = new Label();
            lblResortFee = new Label();
            lblSalesTax = new Label();
            lblTotalRoomCharge = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            chkParking = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOneKing);
            groupBox1.Controls.Add(rbTwoQueen);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(152, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type";
            // 
            // rbOneKing
            // 
            rbOneKing.AutoSize = true;
            rbOneKing.Location = new Point(11, 67);
            rbOneKing.Name = "rbOneKing";
            rbOneKing.Size = new Size(111, 29);
            rbOneKing.TabIndex = 1;
            rbOneKing.TabStop = true;
            rbOneKing.Text = "One King";
            rbOneKing.UseVisualStyleBackColor = true;
            // 
            // rbTwoQueen
            // 
            rbTwoQueen.AutoSize = true;
            rbTwoQueen.Location = new Point(11, 32);
            rbTwoQueen.Name = "rbTwoQueen";
            rbTwoQueen.Size = new Size(128, 29);
            rbTwoQueen.TabIndex = 0;
            rbTwoQueen.TabStop = true;
            rbTwoQueen.Text = "Two Queen";
            rbTwoQueen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbAtrium);
            groupBox2.Controls.Add(rbStandard);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(187, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(141, 120);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "View";
            // 
            // rbAtrium
            // 
            rbAtrium.AutoSize = true;
            rbAtrium.Location = new Point(6, 67);
            rbAtrium.Name = "rbAtrium";
            rbAtrium.Size = new Size(93, 29);
            rbAtrium.TabIndex = 1;
            rbAtrium.TabStop = true;
            rbAtrium.Text = "Atrium";
            rbAtrium.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            rbStandard.AutoSize = true;
            rbStandard.Location = new Point(6, 32);
            rbStandard.Name = "rbStandard";
            rbStandard.Size = new Size(109, 29);
            rbStandard.TabIndex = 0;
            rbStandard.TabStop = true;
            rbStandard.Text = "Standard";
            rbStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtChildren);
            groupBox3.Controls.Add(txtAdults);
            groupBox3.Controls.Add(txtNights);
            groupBox3.Controls.Add(txtRooms);
            groupBox3.Controls.Add(lblChildren);
            groupBox3.Controls.Add(lblAdults);
            groupBox3.Controls.Add(lblNights);
            groupBox3.Controls.Add(lblRooms);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(21, 189);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(307, 271);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Number Of";
            // 
            // txtChildren
            // 
            txtChildren.BackColor = Color.FromArgb(224, 224, 224);
            txtChildren.Location = new Point(196, 189);
            txtChildren.Name = "txtChildren";
            txtChildren.Size = new Size(72, 32);
            txtChildren.TabIndex = 7;
            // 
            // txtAdults
            // 
            txtAdults.BackColor = Color.FromArgb(224, 224, 224);
            txtAdults.Location = new Point(24, 189);
            txtAdults.Name = "txtAdults";
            txtAdults.Size = new Size(72, 32);
            txtAdults.TabIndex = 6;
            // 
            // txtNights
            // 
            txtNights.BackColor = Color.FromArgb(224, 224, 224);
            txtNights.Location = new Point(196, 91);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(72, 32);
            txtNights.TabIndex = 5;
            // 
            // txtRooms
            // 
            txtRooms.BackColor = Color.FromArgb(224, 224, 224);
            txtRooms.Location = new Point(24, 91);
            txtRooms.Name = "txtRooms";
            txtRooms.Size = new Size(72, 32);
            txtRooms.TabIndex = 4;
            // 
            // lblChildren
            // 
            lblChildren.AutoSize = true;
            lblChildren.Location = new Point(196, 161);
            lblChildren.Name = "lblChildren";
            lblChildren.Size = new Size(83, 25);
            lblChildren.TabIndex = 3;
            lblChildren.Text = "Children:";
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Location = new Point(24, 161);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(114, 25);
            lblAdults.TabIndex = 2;
            lblAdults.Text = "Adults (18+):";
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Location = new Point(196, 63);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(69, 25);
            lblNights.TabIndex = 1;
            lblNights.Text = "Nights:";
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Location = new Point(24, 63);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(71, 25);
            lblRooms.TabIndex = 0;
            lblRooms.Text = "Rooms:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox9);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(lblTotalDue);
            groupBox4.Controls.Add(lblParkingFee);
            groupBox4.Controls.Add(lblResortFee);
            groupBox4.Controls.Add(lblSalesTax);
            groupBox4.Controls.Add(lblTotalRoomCharge);
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(348, 189);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(307, 296);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Charges";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(144, 231);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(157, 32);
            textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(144, 180);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(157, 32);
            textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(144, 136);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(157, 32);
            textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(144, 88);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(157, 32);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(144, 38);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(157, 32);
            textBox5.TabIndex = 6;
            // 
            // lblTotalDue
            // 
            lblTotalDue.AutoSize = true;
            lblTotalDue.Location = new Point(26, 237);
            lblTotalDue.Name = "lblTotalDue";
            lblTotalDue.Size = new Size(94, 25);
            lblTotalDue.TabIndex = 5;
            lblTotalDue.Text = "Total Due:";
            // 
            // lblParkingFee
            // 
            lblParkingFee.AutoSize = true;
            lblParkingFee.Location = new Point(26, 189);
            lblParkingFee.Name = "lblParkingFee";
            lblParkingFee.Size = new Size(78, 25);
            lblParkingFee.TabIndex = 4;
            lblParkingFee.Text = "Parking:";
            // 
            // lblResortFee
            // 
            lblResortFee.AutoSize = true;
            lblResortFee.Location = new Point(26, 142);
            lblResortFee.Name = "lblResortFee";
            lblResortFee.Size = new Size(99, 25);
            lblResortFee.TabIndex = 3;
            lblResortFee.Text = "Resort Fee:";
            // 
            // lblSalesTax
            // 
            lblSalesTax.AutoSize = true;
            lblSalesTax.Location = new Point(26, 91);
            lblSalesTax.Name = "lblSalesTax";
            lblSalesTax.Size = new Size(45, 25);
            lblSalesTax.TabIndex = 2;
            lblSalesTax.Text = "Tax:";
            // 
            // lblTotalRoomCharge
            // 
            lblTotalRoomCharge.AutoSize = true;
            lblTotalRoomCharge.Location = new Point(26, 44);
            lblTotalRoomCharge.Name = "lblTotalRoomCharge";
            lblTotalRoomCharge.Size = new Size(63, 25);
            lblTotalRoomCharge.TabIndex = 1;
            lblTotalRoomCharge.Text = "Room:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.PowderBlue;
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(20, 514);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 40);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(532, 514);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // chkParking
            // 
            chkParking.AutoSize = true;
            chkParking.BackColor = Color.White;
            chkParking.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkParking.Location = new Point(403, 65);
            chkParking.Name = "chkParking";
            chkParking.Size = new Size(208, 29);
            chkParking.TabIndex = 6;
            chkParking.Text = "Vehicle  Parking Fee";
            chkParking.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(672, 577);
            Controls.Add(chkParking);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Lily's Resort";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnCalculate;
        private Button btnExit;
        private TextBox txtChildren;
        private TextBox txtAdults;
        private TextBox txtNights;
        private TextBox txtRooms;
        private Label lblChildren;
        private Label lblAdults;
        private Label lblNights;
        private Label lblRooms;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label lblTotalDue;
        private Label lblParkingFee;
        private Label lblResortFee;
        private Label lblSalesTax;
        private Label lblTotalRoomCharge;
        private RadioButton rbOneKing;
        private RadioButton rbTwoQueen;
        private RadioButton rbAtrium;
        private RadioButton rbStandard;
        private CheckBox chkParking;
    }
}
