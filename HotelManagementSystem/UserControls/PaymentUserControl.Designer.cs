namespace HotelManagementSystem.UserControls
{
    partial class PaymentUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkInDateTimeLabel = new System.Windows.Forms.Label();
            this.RoomIdLabel = new System.Windows.Forms.Label();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkOutDateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(388, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(964, 775);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(140, 64);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.PlaceholderText = "Type an SSN then press Enter";
            this.SSNTextBox.Size = new System.Drawing.Size(209, 27);
            this.SSNTextBox.TabIndex = 9;
            this.SSNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tab2SSNTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 67);
            this.label1.Name = "label1";

            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "SSN:";
            // 
            // checkInDateTimeLabel
            // 
            this.checkInDateTimeLabel.AutoSize = true;
            this.checkInDateTimeLabel.Location = new System.Drawing.Point(206, 291);
            this.checkInDateTimeLabel.Name = "checkInDateTimeLabel";
            this.checkInDateTimeLabel.Size = new System.Drawing.Size(16, 20);
            this.checkInDateTimeLabel.TabIndex = 32;
            this.checkInDateTimeLabel.Text = "?";
            // 
            // RoomIdLabel
            // 
            this.RoomIdLabel.AutoSize = true;
            this.RoomIdLabel.Location = new System.Drawing.Point(206, 219);
            this.RoomIdLabel.Name = "RoomIdLabel";
            this.RoomIdLabel.Size = new System.Drawing.Size(16, 20);
            this.RoomIdLabel.TabIndex = 31;
            this.RoomIdLabel.Text = "?";
            // 
            // reservationLabel
            // 
            this.reservationLabel.AutoSize = true;
            this.reservationLabel.Location = new System.Drawing.Point(206, 147);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(16, 20);
            this.reservationLabel.TabIndex = 30;
            this.reservationLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Reservation Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Room Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Check In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Check Out:";
            // 
            // checkOutDateLabel
            // 
            this.checkOutDateLabel.AutoSize = true;
            this.checkOutDateLabel.Location = new System.Drawing.Point(206, 363);
            this.checkOutDateLabel.Name = "checkOutDateLabel";
            this.checkOutDateLabel.Size = new System.Drawing.Size(16, 20);
            this.checkOutDateLabel.TabIndex = 34;
            this.checkOutDateLabel.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Total Price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(206, 435);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(16, 20);
            this.totalPriceLabel.TabIndex = 36;
            this.totalPriceLabel.Text = "?";

            // 
            // PaymentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkOutDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkInDateTimeLabel);
            this.Controls.Add(this.RoomIdLabel);
            this.Controls.Add(this.reservationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);

            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaymentUserControl";
            this.Size = new System.Drawing.Size(1355, 781);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentUserControl";
            this.Size = new System.Drawing.Size(896, 440);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox SSNTextBox;
        private Label label1;
        private Label checkInDateTimeLabel;
        private Label RoomIdLabel;
        private Label reservationLabel;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label checkOutDateLabel;
        private Label label8;
        private Label totalPriceLabel;
    }
}
