namespace HotelManagementSystem.UserControls
{
    partial class RoomUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomIdTextBox = new System.Windows.Forms.TextBox();
            this.roomIdSearchBtn = new System.Windows.Forms.Button();
            this.RoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clearFieldRoomsBtn = new System.Windows.Forms.Button();
            this.roomIdLabel = new System.Windows.Forms.Label();
            this.roomIdKeyLabel = new System.Windows.Forms.Label();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.roomPriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteRoomBtn = new System.Windows.Forms.Button();
            this.editRoomBtn = new System.Windows.Forms.Button();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.clearFieldsBtn = new System.Windows.Forms.Button();
            this.roomTypeTextBox = new System.Windows.Forms.TextBox();
            this.roomPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(424, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms Informations";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 92);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1224, 421);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1216, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Controls.Add(this.roomIdTextBox);
            this.panel3.Controls.Add(this.roomIdSearchBtn);
            this.panel3.Controls.Add(this.RoomsDataGridView);
            this.panel3.Location = new System.Drawing.Point(400, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 389);
            this.panel3.TabIndex = 0;
            // 
            // roomIdTextBox
            // 
            this.roomIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomIdTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomIdTextBox.Location = new System.Drawing.Point(137, 6);
            this.roomIdTextBox.Name = "roomIdTextBox";
            this.roomIdTextBox.Size = new System.Drawing.Size(451, 33);
            this.roomIdTextBox.TabIndex = 23;
            this.roomIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomIdTextBox_KeyPress);
            // 
            // roomIdSearchBtn
            // 
            this.roomIdSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roomIdSearchBtn.Location = new System.Drawing.Point(621, 6);
            this.roomIdSearchBtn.Name = "roomIdSearchBtn";
            this.roomIdSearchBtn.Size = new System.Drawing.Size(144, 32);
            this.roomIdSearchBtn.TabIndex = 22;
            this.roomIdSearchBtn.Text = "Search";
            this.roomIdSearchBtn.UseVisualStyleBackColor = true;
            // 
            // RoomsDataGridView
            // 
            this.RoomsDataGridView.AllowUserToAddRows = false;
            this.RoomsDataGridView.AllowUserToDeleteRows = false;
            this.RoomsDataGridView.AllowUserToOrderColumns = true;
            this.RoomsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomsDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.RoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDataGridView.Location = new System.Drawing.Point(0, 46);
            this.RoomsDataGridView.Name = "RoomsDataGridView";
            this.RoomsDataGridView.ReadOnly = true;
            this.RoomsDataGridView.RowHeadersWidth = 51;
            this.RoomsDataGridView.RowTemplate.Height = 25;
            this.RoomsDataGridView.Size = new System.Drawing.Size(808, 343);
            this.RoomsDataGridView.TabIndex = 21;
            this.RoomsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsDataGridView_CellClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Controls.Add(this.clearFieldRoomsBtn);
            this.panel4.Controls.Add(this.roomIdLabel);
            this.panel4.Controls.Add(this.roomIdKeyLabel);
            this.panel4.Controls.Add(this.roomTypeComboBox);
            this.panel4.Controls.Add(this.roomPriceLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.deleteRoomBtn);
            this.panel4.Controls.Add(this.editRoomBtn);
            this.panel4.Controls.Add(this.addRoomBtn);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 389);
            this.panel4.TabIndex = 1;
            // 
            // clearFieldRoomsBtn
            // 
            this.clearFieldRoomsBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clearFieldRoomsBtn.BackColor = System.Drawing.Color.DarkGray;
            this.clearFieldRoomsBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);


            this.clearFieldRoomsBtn.Location = new System.Drawing.Point(88, 286);
            this.clearFieldRoomsBtn.Name = "clearFieldRoomsBtn";
            this.clearFieldRoomsBtn.Size = new System.Drawing.Size(210, 41);
            this.clearFieldRoomsBtn.TabIndex = 29;
            this.clearFieldRoomsBtn.Text = "Clear Fields";
            this.clearFieldRoomsBtn.UseVisualStyleBackColor = false;
            this.clearFieldRoomsBtn.Click += new System.EventHandler(this.clearFieldRoomsBtn_Click);
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roomIdLabel.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomIdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomIdLabel.Location = new System.Drawing.Point(176, 14);
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(207, 21);
            this.roomIdLabel.TabIndex = 28;
            this.roomIdLabel.Visible = false;
            // 
            // roomIdKeyLabel
            // 
            this.roomIdKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roomIdKeyLabel.AutoSize = true;
            this.roomIdKeyLabel.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomIdKeyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomIdKeyLabel.Location = new System.Drawing.Point(14, 14);
            this.roomIdKeyLabel.Name = "roomIdKeyLabel";
            this.roomIdKeyLabel.Size = new System.Drawing.Size(106, 27);
            this.roomIdKeyLabel.TabIndex = 27;
            this.roomIdKeyLabel.Text = "Room Id:";
            this.roomIdKeyLabel.Visible = false;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.ItemHeight = 15;
            this.roomTypeComboBox.Location = new System.Drawing.Point(148, 61);
            this.roomTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(208, 23);
            this.roomTypeComboBox.TabIndex = 26;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // roomPriceLabel
            // 
            this.roomPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomPriceLabel.BackColor = System.Drawing.Color.White;
            this.roomPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomPriceLabel.Location = new System.Drawing.Point(148, 106);
            this.roomPriceLabel.Name = "roomPriceLabel";
            this.roomPriceLabel.Size = new System.Drawing.Size(207, 30);
            this.roomPriceLabel.TabIndex = 25;
            this.roomPriceLabel.Text = "0";
            this.roomPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "RoomPrice:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "RoomType:";
            // 
            // deleteRoomBtn
            // 
            this.deleteRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteRoomBtn.BackColor = System.Drawing.Color.DarkGray;
            this.deleteRoomBtn.FlatAppearance.BorderSize = 5;
            this.deleteRoomBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteRoomBtn.Location = new System.Drawing.Point(254, 229);
            this.deleteRoomBtn.Name = "deleteRoomBtn";
            this.deleteRoomBtn.Size = new System.Drawing.Size(110, 41);
            this.deleteRoomBtn.TabIndex = 18;
            this.deleteRoomBtn.Text = "Delete";
            this.deleteRoomBtn.UseVisualStyleBackColor = false;
            this.deleteRoomBtn.Click += new System.EventHandler(this.deleteRoomBtn_Click);
            // 
            // editRoomBtn
            // 
            this.editRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editRoomBtn.BackColor = System.Drawing.Color.DarkGray;
            this.editRoomBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editRoomBtn.Location = new System.Drawing.Point(137, 229);
            this.editRoomBtn.Name = "editRoomBtn";
            this.editRoomBtn.Size = new System.Drawing.Size(110, 41);
            this.editRoomBtn.TabIndex = 17;
            this.editRoomBtn.Text = "Edit";
            this.editRoomBtn.UseVisualStyleBackColor = false;
            this.editRoomBtn.Click += new System.EventHandler(this.editRoomBtn_Click);
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addRoomBtn.BackColor = System.Drawing.Color.DarkGray;
            this.addRoomBtn.FlatAppearance.BorderSize = 0;
            this.addRoomBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addRoomBtn.Location = new System.Drawing.Point(21, 229);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(110, 41);
            this.addRoomBtn.TabIndex = 16;
            this.addRoomBtn.Text = "Add";
            this.addRoomBtn.UseVisualStyleBackColor = false;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1216, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Room Type";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Controls.Add(this.clearFieldsBtn);
            this.panel5.Controls.Add(this.roomTypeTextBox);
            this.panel5.Controls.Add(this.roomPriceTextBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Controls.Add(this.editBtn);
            this.panel5.Controls.Add(this.addBtn);
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 389);
            this.panel5.TabIndex = 2;
            // 
            // clearFieldsBtn
            // 
            this.clearFieldsBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clearFieldsBtn.BackColor = System.Drawing.Color.DarkGray;
            this.clearFieldsBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearFieldsBtn.Location = new System.Drawing.Point(85, 288);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.Size = new System.Drawing.Size(210, 41);
            this.clearFieldsBtn.TabIndex = 28;
            this.clearFieldsBtn.Text = "Clear Fields";
            this.clearFieldsBtn.UseVisualStyleBackColor = false;
            this.clearFieldsBtn.Click += new System.EventHandler(this.clearFieldsBtn_Click);
            // 
            // roomTypeTextBox
            // 
            this.roomTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomTypeTextBox.BackColor = System.Drawing.Color.White;
            this.roomTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomTypeTextBox.Location = new System.Drawing.Point(157, 61);
            this.roomTypeTextBox.Name = "roomTypeTextBox";
            this.roomTypeTextBox.Size = new System.Drawing.Size(208, 33);
            this.roomTypeTextBox.TabIndex = 27;
            // 
            // roomPriceTextBox
            // 
            this.roomPriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roomPriceTextBox.BackColor = System.Drawing.Color.White;
            this.roomPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomPriceTextBox.Location = new System.Drawing.Point(157, 104);
            this.roomPriceTextBox.Name = "roomPriceTextBox";
            this.roomPriceTextBox.Size = new System.Drawing.Size(208, 33);
            this.roomPriceTextBox.TabIndex = 26;
            this.roomPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomPriceTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(14, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "RoomPrice:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(14, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "RoomType:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteBtn.BackColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.FlatAppearance.BorderSize = 5;
            this.deleteBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(253, 232);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 41);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editBtn.BackColor = System.Drawing.Color.DarkGray;
            this.editBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(137, 232);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(110, 41);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Edit Price";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.BackColor = System.Drawing.Color.DarkGray;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(21, 232);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(110, 41);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.roomTypeDataGridView);
            this.panel2.Location = new System.Drawing.Point(391, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 389);
            this.panel2.TabIndex = 1;
            // 
            // roomTypeDataGridView
            // 
            this.roomTypeDataGridView.AllowUserToAddRows = false;
            this.roomTypeDataGridView.AllowUserToDeleteRows = false;
            this.roomTypeDataGridView.AllowUserToOrderColumns = true;
            this.roomTypeDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roomTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTypeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.roomTypeDataGridView.Name = "roomTypeDataGridView";
            this.roomTypeDataGridView.ReadOnly = true;
            this.roomTypeDataGridView.RowHeadersWidth = 51;
            this.roomTypeDataGridView.RowTemplate.Height = 25;
            this.roomTypeDataGridView.Size = new System.Drawing.Size(816, 389);
            this.roomTypeDataGridView.TabIndex = 22;
            this.roomTypeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomTypeDataGridView_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RoomUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoomUserControl";
            this.Size = new System.Drawing.Size(1216, 515);
            this.Load += new System.EventHandler(this.RoomUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Panel panel3;
        private DataGridView RoomsDataGridView;
        private Panel panel4;
        private Label label2;
        private Button deleteRoomBtn;
        private Button editRoomBtn;
        private Button addRoomBtn;
        private Label label3;
        private Label roomPriceLabel;
        private Panel panel2;
        private DataGridView roomTypeDataGridView;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private TextBox roomPriceTextBox;
        private TextBox roomTypeTextBox;
        private ErrorProvider errorProvider1;
        private TextBox roomIdTextBox;
        private Button roomIdSearchBtn;
        private Button clearFieldsBtn;
        private ComboBox roomTypeComboBox;
        private Label roomIdLabel;
        private Label roomIdKeyLabel;
        private Button clearFieldRoomsBtn;
    }
}
