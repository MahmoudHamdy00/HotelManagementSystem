namespace HotelManagementSystem.UserControls
{
    partial class ReservationUserControl
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
            this.components = new System.ComponentModel.Container();
            this.addReservBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.roomIdLabel = new System.Windows.Forms.Label();
            this.checkInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkInLabel = new System.Windows.Forms.Label();
            this.roomIdComboBox = new System.Windows.Forms.ComboBox();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelBOD = new System.Windows.Forms.Label();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.mobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guestInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab2checkInDateTimeLabel = new System.Windows.Forms.Label();
            this.tab2RoomIdLabel = new System.Windows.Forms.Label();
            this.tab2ReservationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2checkOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tab2SSNTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guestInfoGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addReservBtn
            // 
            this.addReservBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addReservBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addReservBtn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addReservBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addReservBtn.Location = new System.Drawing.Point(280, 448);
            this.addReservBtn.Name = "addReservBtn";
            this.addReservBtn.Size = new System.Drawing.Size(153, 55);
            this.addReservBtn.TabIndex = 2;
            this.addReservBtn.Text = "Add Reservation";
            this.addReservBtn.UseVisualStyleBackColor = false;
            this.addReservBtn.Click += new System.EventHandler(this.addReservBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SSNTextBox.Location = new System.Drawing.Point(307, 151);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.PlaceholderText = "Type an SSN then press Enter";
            this.SSNTextBox.Size = new System.Drawing.Size(209, 27);
            this.SSNTextBox.TabIndex = 3;
            this.SSNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SSNTextBox_KeyPress);
            // 
            // SSNLabel
            // 
            this.SSNLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSNLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SSNLabel.Location = new System.Drawing.Point(189, 151);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(56, 24);
            this.SSNLabel.TabIndex = 4;
            this.SSNLabel.Text = "SSN:";
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomIdLabel.AutoSize = true;
            this.roomIdLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomIdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomIdLabel.Location = new System.Drawing.Point(189, 299);
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(94, 24);
            this.roomIdLabel.TabIndex = 5;
            this.roomIdLabel.Text = "Room Id:";
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkInDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkInDateTimePicker.Location = new System.Drawing.Point(307, 372);
            this.checkInDateTimePicker.MinDate = new System.DateTime(2022, 1, 3, 0, 0, 0, 0);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(263, 27);
            this.checkInDateTimePicker.TabIndex = 7;
            // 
            // checkInLabel
            // 
            this.checkInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkInLabel.AutoSize = true;
            this.checkInLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkInLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkInLabel.Location = new System.Drawing.Point(189, 372);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(97, 24);
            this.checkInLabel.TabIndex = 8;
            this.checkInLabel.Text = "Check In:";
            // 
            // roomIdComboBox
            // 
            this.roomIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomIdComboBox.FormattingEnabled = true;
            this.roomIdComboBox.Location = new System.Drawing.Point(307, 297);
            this.roomIdComboBox.Name = "roomIdComboBox";
            this.roomIdComboBox.Size = new System.Drawing.Size(151, 28);
            this.roomIdComboBox.TabIndex = 11;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Location = new System.Drawing.Point(307, 224);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(151, 28);
            this.roomTypeComboBox.TabIndex = 12;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomTypeLabel.Location = new System.Drawing.Point(189, 225);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(115, 24);
            this.roomTypeLabel.TabIndex = 13;
            this.roomTypeLabel.Text = "Room Type";
            this.roomTypeLabel.Click += new System.EventHandler(this.roomTypeLabel_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTextBox.Location = new System.Drawing.Point(197, 149);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(217, 39);
            this.addressTextBox.TabIndex = 39;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAddress.Location = new System.Drawing.Point(19, 157);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(116, 28);
            this.labelAddress.TabIndex = 38;
            this.labelAddress.Text = "Address :";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Teal;
            this.labelGender.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGender.Location = new System.Drawing.Point(19, 208);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(107, 28);
            this.labelGender.TabIndex = 37;
            this.labelGender.Text = "Gender :";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Enabled = false;
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(197, 197);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(217, 40);
            this.genderComboBox.TabIndex = 36;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.birthDateDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthDateDateTimePicker.Enabled = false;
            this.birthDateDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(197, 293);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(217, 39);
            this.birthDateDateTimePicker.TabIndex = 35;
            // 
            // labelBOD
            // 
            this.labelBOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBOD.AutoSize = true;
            this.labelBOD.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBOD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBOD.Location = new System.Drawing.Point(19, 304);
            this.labelBOD.Name = "labelBOD";
            this.labelBOD.Size = new System.Drawing.Size(166, 28);
            this.labelBOD.TabIndex = 34;
            this.labelBOD.Text = "Birth Of Day :";
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nationalityTextBox.Enabled = false;
            this.nationalityTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationalityTextBox.Location = new System.Drawing.Point(197, 341);
            this.nationalityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(217, 39);
            this.nationalityTextBox.TabIndex = 33;
            // 
            // labelCountry
            // 
            this.labelCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCountry.Location = new System.Drawing.Point(19, 353);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(161, 28);
            this.labelCountry.TabIndex = 32;
            this.labelCountry.Text = "Nationalatiy :";
            // 
            // mobileNumberTextBox
            // 
            this.mobileNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mobileNumberTextBox.Enabled = false;
            this.mobileNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mobileNumberTextBox.Location = new System.Drawing.Point(197, 245);
            this.mobileNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mobileNumberTextBox.Name = "mobileNumberTextBox";
            this.mobileNumberTextBox.Size = new System.Drawing.Size(217, 39);
            this.mobileNumberTextBox.TabIndex = 31;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPhone.Location = new System.Drawing.Point(19, 256);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(94, 28);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Phone :";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.Location = new System.Drawing.Point(197, 101);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(217, 39);
            this.lastNameTextBox.TabIndex = 29;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastName.Location = new System.Drawing.Point(19, 109);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(141, 28);
            this.labelLastName.TabIndex = 28;
            this.labelLastName.Text = "Last Name :";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.Location = new System.Drawing.Point(197, 53);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(217, 39);
            this.firstNameTextBox.TabIndex = 27;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(19, 61);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(144, 28);
            this.labelFirstName.TabIndex = 26;
            this.labelFirstName.Text = "First Name :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1369, 724);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.guestInfoGroupBox);
            this.tabPage1.Controls.Add(this.SSNLabel);
            this.tabPage1.Controls.Add(this.addReservBtn);
            this.tabPage1.Controls.Add(this.SSNTextBox);
            this.tabPage1.Controls.Add(this.roomIdLabel);
            this.tabPage1.Controls.Add(this.checkInDateTimePicker);
            this.tabPage1.Controls.Add(this.checkInLabel);
            this.tabPage1.Controls.Add(this.roomIdComboBox);
            this.tabPage1.Controls.Add(this.roomTypeComboBox);
            this.tabPage1.Controls.Add(this.roomTypeLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1361, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check-In";
            // 
            // guestInfoGroupBox
            // 
            this.guestInfoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guestInfoGroupBox.Controls.Add(this.addressTextBox);
            this.guestInfoGroupBox.Controls.Add(this.labelFirstName);
            this.guestInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.guestInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.guestInfoGroupBox.Controls.Add(this.labelAddress);
            this.guestInfoGroupBox.Controls.Add(this.mobileNumberTextBox);
            this.guestInfoGroupBox.Controls.Add(this.nationalityTextBox);
            this.guestInfoGroupBox.Controls.Add(this.labelGender);
            this.guestInfoGroupBox.Controls.Add(this.birthDateDateTimePicker);
            this.guestInfoGroupBox.Controls.Add(this.genderComboBox);
            this.guestInfoGroupBox.Controls.Add(this.labelLastName);
            this.guestInfoGroupBox.Controls.Add(this.labelPhone);
            this.guestInfoGroupBox.Controls.Add(this.labelBOD);
            this.guestInfoGroupBox.Controls.Add(this.labelCountry);
            this.guestInfoGroupBox.Location = new System.Drawing.Point(717, 119);
            this.guestInfoGroupBox.Name = "guestInfoGroupBox";
            this.guestInfoGroupBox.Size = new System.Drawing.Size(434, 397);
            this.guestInfoGroupBox.TabIndex = 40;
            this.guestInfoGroupBox.TabStop = false;
            this.guestInfoGroupBox.Text = "Guest Info";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.tab2checkInDateTimeLabel);
            this.tabPage2.Controls.Add(this.tab2RoomIdLabel);
            this.tabPage2.Controls.Add(this.tab2ReservationLabel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.checkOutButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tab2checkOutDateTimePicker);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tab2SSNTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1361, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check-Out";
            // 
            // tab2checkInDateTimeLabel
            // 
            this.tab2checkInDateTimeLabel.AutoSize = true;
            this.tab2checkInDateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab2checkInDateTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tab2checkInDateTimeLabel.Location = new System.Drawing.Point(155, 300);
            this.tab2checkInDateTimeLabel.Name = "tab2checkInDateTimeLabel";
            this.tab2checkInDateTimeLabel.Size = new System.Drawing.Size(21, 25);
            this.tab2checkInDateTimeLabel.TabIndex = 26;
            this.tab2checkInDateTimeLabel.Text = "?";
            // 
            // tab2RoomIdLabel
            // 
            this.tab2RoomIdLabel.AutoSize = true;
            this.tab2RoomIdLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab2RoomIdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tab2RoomIdLabel.Location = new System.Drawing.Point(155, 209);
            this.tab2RoomIdLabel.Name = "tab2RoomIdLabel";
            this.tab2RoomIdLabel.Size = new System.Drawing.Size(21, 25);
            this.tab2RoomIdLabel.TabIndex = 25;
            this.tab2RoomIdLabel.Text = "?";
            // 
            // tab2ReservationLabel
            // 
            this.tab2ReservationLabel.AutoSize = true;
            this.tab2ReservationLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab2ReservationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tab2ReservationLabel.Location = new System.Drawing.Point(155, 144);
            this.tab2ReservationLabel.Name = "tab2ReservationLabel";
            this.tab2ReservationLabel.Size = new System.Drawing.Size(21, 25);
            this.tab2ReservationLabel.TabIndex = 24;
            this.tab2ReservationLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Reservation Id:";
            // 
            // checkOutButton
            // 
            this.checkOutButton.BackColor = System.Drawing.Color.SlateGray;
            this.checkOutButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkOutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkOutButton.Location = new System.Drawing.Point(105, 495);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(185, 55);
            this.checkOutButton.TabIndex = 20;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = false;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Check Out:";
            // 
            // tab2checkOutDateTimePicker
            // 
            this.tab2checkOutDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab2checkOutDateTimePicker.Location = new System.Drawing.Point(155, 381);
            this.tab2checkOutDateTimePicker.MinDate = new System.DateTime(2022, 1, 3, 0, 0, 0, 0);
            this.tab2checkOutDateTimePicker.Name = "tab2checkOutDateTimePicker";
            this.tab2checkOutDateTimePicker.Size = new System.Drawing.Size(228, 27);
            this.tab2checkOutDateTimePicker.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Room Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Check In:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(434, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(922, 688);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "SSN:";
            // 
            // tab2SSNTextBox
            // 
            this.tab2SSNTextBox.Location = new System.Drawing.Point(155, 75);
            this.tab2SSNTextBox.Name = "tab2SSNTextBox";
            this.tab2SSNTextBox.PlaceholderText = "Type an SSN then press Enter";
            this.tab2SSNTextBox.Size = new System.Drawing.Size(209, 27);
            this.tab2SSNTextBox.TabIndex = 5;
            this.tab2SSNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tab2SSNTextBox_KeyPress);
            // 
            // ReservationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ReservationUserControl";
            this.Size = new System.Drawing.Size(1369, 724);
            this.Load += new System.EventHandler(this.ReservationUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.guestInfoGroupBox.ResumeLayout(false);
            this.guestInfoGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button addReservBtn;
        private ErrorProvider errorProvider1;
        private Label SSNLabel;
        private TextBox SSNTextBox;
        private Label roomIdLabel;
        private DateTimePicker checkInDateTimePicker;
        private Label checkInLabel;
        private ComboBox roomIdComboBox;
        private Label roomTypeLabel;
        private ComboBox roomTypeComboBox;
        private TextBox addressTextBox;
        private Label labelAddress;
        private Label labelGender;
        private ComboBox genderComboBox;
        private DateTimePicker birthDateDateTimePicker;
        private Label labelBOD;
        private TextBox nationalityTextBox;
        private Label labelCountry;
        private TextBox mobileNumberTextBox;
        private Label labelPhone;
        private TextBox lastNameTextBox;
        private Label labelLastName;
        private TextBox firstNameTextBox;
        private Label labelFirstName;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox guestInfoGroupBox;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox tab2SSNTextBox;
        private Label label2;
        private DateTimePicker tab2checkOutDateTimePicker;
        private Label label3;
        private Label label4;
        private Button checkOutButton;
        private Label label5;
        private Label tab2checkInDateTimeLabel;
        private Label tab2RoomIdLabel;
        private Label tab2ReservationLabel;
    }
}
