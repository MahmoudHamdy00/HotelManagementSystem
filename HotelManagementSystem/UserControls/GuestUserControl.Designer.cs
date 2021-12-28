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
            this.panelGuestTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGuestTitel
            // 
            this.panelGuestTitel.BackColor = System.Drawing.Color.CadetBlue;
            this.panelGuestTitel.Controls.Add(this.labelGuestDiscripe);
            this.panelGuestTitel.Location = new System.Drawing.Point(0, -1);
            this.panelGuestTitel.Name = "panelGuestTitel";
            this.panelGuestTitel.Size = new System.Drawing.Size(935, 124);
            this.panelGuestTitel.TabIndex = 0;
            // 
            // labelGuestDiscripe
            // 
            this.labelGuestDiscripe.AutoSize = true;
            this.labelGuestDiscripe.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGuestDiscripe.Location = new System.Drawing.Point(237, 19);
            this.labelGuestDiscripe.Name = "labelGuestDiscripe";
            this.labelGuestDiscripe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGuestDiscripe.Size = new System.Drawing.Size(471, 86);
            this.labelGuestDiscripe.TabIndex = 0;
            this.labelGuestDiscripe.Text = "Manage Guest";
            this.labelGuestDiscripe.Click += new System.EventHandler(this.labelGuestDiscripe_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(113, 139);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(45, 30);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID :";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(167, 147);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(190, 33);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.Location = new System.Drawing.Point(167, 194);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(190, 33);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(34, 187);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(124, 30);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name :";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(167, 238);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(190, 33);
            this.textBoxLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(35, 231);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(123, 30);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(167, 278);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(190, 33);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(75, 269);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(83, 30);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone :";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCountry.Location = new System.Drawing.Point(167, 324);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(190, 33);
            this.textBoxCountry.TabIndex = 10;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.Location = new System.Drawing.Point(55, 317);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(103, 30);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country  :";
            // 
            // labelBOD
            // 
            this.labelBOD.AutoSize = true;
            this.labelBOD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBOD.Location = new System.Drawing.Point(20, 360);
            this.labelBOD.Name = "labelBOD";
            this.labelBOD.Size = new System.Drawing.Size(138, 30);
            this.labelBOD.TabIndex = 11;
            this.labelBOD.Text = "Birth Of Day :";
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBirthDay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(167, 360);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(190, 33);
            this.dateTimePickerBirthDay.TabIndex = 12;
            // 
            // dataGridViewGuestInfo
            // 
            this.dataGridViewGuestInfo.AllowUserToAddRows = false;
            this.dataGridViewGuestInfo.AllowUserToDeleteRows = false;
            this.dataGridViewGuestInfo.AllowUserToOrderColumns = true;
            this.dataGridViewGuestInfo.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridViewGuestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestInfo.Location = new System.Drawing.Point(433, 174);
            this.dataGridViewGuestInfo.Name = "dataGridViewGuestInfo";
            this.dataGridViewGuestInfo.ReadOnly = true;
            this.dataGridViewGuestInfo.RowTemplate.Height = 25;
            this.dataGridViewGuestInfo.Size = new System.Drawing.Size(499, 328);
            this.dataGridViewGuestInfo.TabIndex = 13;
            this.dataGridViewGuestInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuestInfo_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(459, 131);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(134, 33);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(20, 401);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 41);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Brown;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(152, 399);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 43);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(290, 401);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 41);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(633, 129);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(101, 32);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Yellow;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(88, 448);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(187, 36);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Clear Field";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // GuestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
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
            this.Size = new System.Drawing.Size(935, 505);
            this.Load += new System.EventHandler(this.GuestUserControl_Load);
            this.panelGuestTitel.ResumeLayout(false);
            this.panelGuestTitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestInfo)).EndInit();
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
    }
}
