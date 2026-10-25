namespace Lab_Sheet_04_Belgado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            grpNumberOf = new GroupBox();
            txtChildren = new TextBox();
            txtAdults = new TextBox();
            txtNights = new TextBox();
            txtRooms = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpCharges = new GroupBox();
            txtTotalDue = new TextBox();
            txtResortFee = new TextBox();
            txtTax = new TextBox();
            txtRoomCharge = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpNumberOf.SuspendLayout();
            grpCharges.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 438);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpNumberOf
            // 
            grpNumberOf.Controls.Add(txtChildren);
            grpNumberOf.Controls.Add(txtAdults);
            grpNumberOf.Controls.Add(txtNights);
            grpNumberOf.Controls.Add(txtRooms);
            grpNumberOf.Controls.Add(label4);
            grpNumberOf.Controls.Add(label3);
            grpNumberOf.Controls.Add(label2);
            grpNumberOf.Controls.Add(label1);
            grpNumberOf.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpNumberOf.Location = new Point(286, 25);
            grpNumberOf.Name = "grpNumberOf";
            grpNumberOf.Size = new Size(260, 276);
            grpNumberOf.TabIndex = 1;
            grpNumberOf.TabStop = false;
            grpNumberOf.Text = "Number Of:";
            // 
            // txtChildren
            // 
            txtChildren.Location = new Point(154, 199);
            txtChildren.Name = "txtChildren";
            txtChildren.Size = new Size(91, 31);
            txtChildren.TabIndex = 7;
            // 
            // txtAdults
            // 
            txtAdults.Location = new Point(17, 199);
            txtAdults.Name = "txtAdults";
            txtAdults.Size = new Size(91, 31);
            txtAdults.TabIndex = 6;
            // 
            // txtNights
            // 
            txtNights.Location = new Point(154, 90);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(91, 31);
            txtNights.TabIndex = 5;
            // 
            // txtRooms
            // 
            txtRooms.Location = new Point(17, 90);
            txtRooms.Name = "txtRooms";
            txtRooms.Size = new Size(91, 31);
            txtRooms.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 161);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = "Children:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 161);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Adults (18+):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 50);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "Nights:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Rooms:";
            // 
            // grpCharges
            // 
            grpCharges.Controls.Add(txtTotalDue);
            grpCharges.Controls.Add(txtResortFee);
            grpCharges.Controls.Add(txtTax);
            grpCharges.Controls.Add(txtRoomCharge);
            grpCharges.Controls.Add(label8);
            grpCharges.Controls.Add(label7);
            grpCharges.Controls.Add(label6);
            grpCharges.Controls.Add(label5);
            grpCharges.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpCharges.Location = new Point(566, 30);
            grpCharges.Name = "grpCharges";
            grpCharges.Size = new Size(314, 271);
            grpCharges.TabIndex = 2;
            grpCharges.TabStop = false;
            grpCharges.Text = "Charges";
            // 
            // txtTotalDue
            // 
            txtTotalDue.Location = new Point(153, 210);
            txtTotalDue.Name = "txtTotalDue";
            txtTotalDue.Size = new Size(155, 31);
            txtTotalDue.TabIndex = 11;
            // 
            // txtResortFee
            // 
            txtResortFee.Location = new Point(153, 153);
            txtResortFee.Name = "txtResortFee";
            txtResortFee.Size = new Size(155, 31);
            txtResortFee.TabIndex = 10;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(153, 96);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(155, 31);
            txtTax.TabIndex = 9;
            // 
            // txtRoomCharge
            // 
            txtRoomCharge.Location = new Point(153, 42);
            txtRoomCharge.Name = "txtRoomCharge";
            txtRoomCharge.Size = new Size(155, 31);
            txtRoomCharge.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 216);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 7;
            label8.Text = "Total Due:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 159);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 6;
            label7.Text = "Resort Fee:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 102);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 5;
            label6.Text = "Tax:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 45);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 4;
            label5.Text = "Room:";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(342, 338);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(168, 43);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(635, 338);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 43);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 475);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(grpCharges);
            Controls.Add(grpNumberOf);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpNumberOf.ResumeLayout(false);
            grpNumberOf.PerformLayout();
            grpCharges.ResumeLayout(false);
            grpCharges.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox grpNumberOf;
        private GroupBox grpCharges;
        private Button btnCalculate;
        private Button btnExit;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox txtChildren;
        private TextBox txtAdults;
        private TextBox txtNights;
        private TextBox txtRooms;
        private TextBox txtTotalDue;
        private TextBox txtResortFee;
        private TextBox txtTax;
        private TextBox txtRoomCharge;
    }
}
