namespace HotelManagementSystem
{
    partial class GuestUserControl
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
            this.panelGuestTitel = new System.Windows.Forms.Panel();
            this.labelGuestDiscripe = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelBOD = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewGuestInfo = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGuestTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGuestTitel
            // 
            this.panelGuestTitel.BackColor = System.Drawing.Color.Teal;
            this.panelGuestTitel.Controls.Add(this.labelGuestDiscripe);
            this.panelGuestTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGuestTitel.Location = new System.Drawing.Point(0, 0);
            this.panelGuestTitel.Name = "panelGuestTitel";
            this.panelGuestTitel.Size = new System.Drawing.Size(1200, 98);
            this.panelGuestTitel.TabIndex = 0;
            // 
            // labelGuestDiscripe
            // 
            this.labelGuestDiscripe.AutoSize = true;
            this.labelGuestDiscripe.Font = new System.Drawing.Font("Book Antiqua", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGuestDiscripe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelGuestDiscripe.Location = new System.Drawing.Point(379, 25);
            this.labelGuestDiscripe.Name = "labelGuestDiscripe";
            this.labelGuestDiscripe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGuestDiscripe.Size = new System.Drawing.Size(276, 47);
            this.labelGuestDiscripe.TabIndex = 0;
            this.labelGuestDiscripe.Text = "Manage Guest";
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelID.Location = new System.Drawing.Point(21, 125);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(61, 26);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "SSN :";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxID.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(167, 122);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(190, 31);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFirstName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.Location = new System.Drawing.Point(167, 163);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(190, 31);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFirstName.Location = new System.Drawing.Point(21, 166);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(126, 26);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name :";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLastName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(167, 206);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(190, 31);
            this.textBoxLastName.TabIndex = 6;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLastName.Location = new System.Drawing.Point(21, 213);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(124, 26);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPhone.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(167, 249);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(190, 31);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPhone.Location = new System.Drawing.Point(21, 256);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(80, 26);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone :";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCountry.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountry.Location = new System.Drawing.Point(167, 295);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(190, 31);
            this.textBoxCountry.TabIndex = 10;
            this.textBoxCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCountry_KeyPress);
            // 
            // labelCountry
            // 
            this.labelCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCountry.Location = new System.Drawing.Point(19, 302);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(139, 26);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Nationalatiy :";
            // 
            // labelBOD
            // 
            this.labelBOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBOD.AutoSize = true;
            this.labelBOD.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBOD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBOD.Location = new System.Drawing.Point(19, 389);
            this.labelBOD.Name = "labelBOD";
            this.labelBOD.Size = new System.Drawing.Size(141, 26);
            this.labelBOD.TabIndex = 11;
            this.labelBOD.Text = "Birth Of Day :";
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerBirthDay.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBirthDay.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(167, 383);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(190, 31);
            this.dateTimePickerBirthDay.TabIndex = 12;
            // 
            // dataGridViewGuestInfo
            // 
            this.dataGridViewGuestInfo.AllowUserToAddRows = false;
            this.dataGridViewGuestInfo.AllowUserToDeleteRows = false;
            this.dataGridViewGuestInfo.AllowUserToOrderColumns = true;
            this.dataGridViewGuestInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGuestInfo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGuestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestInfo.Location = new System.Drawing.Point(379, 153);
            this.dataGridViewGuestInfo.Name = "dataGridViewGuestInfo";
            this.dataGridViewGuestInfo.ReadOnly = true;
            this.dataGridViewGuestInfo.RowHeadersWidth = 51;
            this.dataGridViewGuestInfo.RowTemplate.Height = 25;
            this.dataGridViewGuestInfo.Size = new System.Drawing.Size(821, 547);
            this.dataGridViewGuestInfo.TabIndex = 13;
            this.dataGridViewGuestInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuestInfo_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(188, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Enter A SSN";
            this.textBoxSearch.Size = new System.Drawing.Size(385, 33);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(19, 535);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 41);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(252, 535);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 41);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(136, 535);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 41);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.Silver;
            this.buttonSearch.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(601, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(144, 36);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReset.BackColor = System.Drawing.Color.DarkGray;
            this.buttonReset.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(98, 582);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(187, 41);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Clear Field";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(167, 431);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(190, 31);
            this.comboBoxGender.TabIndex = 20;
            this.comboBoxGender.TextChanged += new System.EventHandler(this.comboBoxGender_TextChanged);
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.DarkCyan;
            this.labelGender.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGender.Location = new System.Drawing.Point(19, 434);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(91, 26);
            this.labelGender.TabIndex = 21;
            this.labelGender.Text = "Gender :";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAddress.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(167, 338);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(190, 31);
            this.textBoxAddress.TabIndex = 23;
            this.textBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_KeyPress);
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAddress.Location = new System.Drawing.Point(21, 345);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(100, 26);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Address :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Location = new System.Drawing.Point(379, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 60);
            this.panel1.TabIndex = 24;
            // 
            // GuestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewGuestInfo);
            this.Controls.Add(this.dateTimePickerBirthDay);
            this.Controls.Add(this.labelBOD);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.panelGuestTitel);
            this.Name = "GuestUserControl";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.GuestUserControl_Load);
            this.panelGuestTitel.ResumeLayout(false);
            this.panelGuestTitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelGuestTitel;
        private Label labelGuestDiscripe;
        private Label labelID;
        private TextBox textBoxID;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private TextBox textBoxCountry;
        private Label labelCountry;
        private Label labelBOD;
        private DateTimePicker dateTimePickerBirthDay;
        private DataGridView dataGridViewGuestInfo;
        private TextBox textBoxSearch;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonSearch;
        private Button buttonReset;
        private ComboBox comboBoxGender;
        private Label labelGender;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private ErrorProvider errorProvider1;
        private Panel panel1;
    }
}
