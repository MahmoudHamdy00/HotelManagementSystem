namespace HotelManagementSystem
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.signInBtn = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.forgetPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.hotelManagmentSystemLabel = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(133, 373);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(173, 41);
            this.signInBtn.TabIndex = 0;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(114, 212);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(297, 27);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(114, 293);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '♥';
            this.passwordTextBox.Size = new System.Drawing.Size(297, 27);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameLabel.Location = new System.Drawing.Point(11, 212);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 23);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLabel.Location = new System.Drawing.Point(11, 293);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 23);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // forgetPasswordLinkLabel
            // 
            this.forgetPasswordLinkLabel.AutoSize = true;
            this.forgetPasswordLinkLabel.LinkColor = System.Drawing.Color.Transparent;
            this.forgetPasswordLinkLabel.Location = new System.Drawing.Point(198, 271);
            this.forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
            this.forgetPasswordLinkLabel.Size = new System.Drawing.Size(117, 20);
            this.forgetPasswordLinkLabel.TabIndex = 5;
            this.forgetPasswordLinkLabel.TabStop = true;
            this.forgetPasswordLinkLabel.Text = "Forget Password";
            this.forgetPasswordLinkLabel.Visible = false;
            this.forgetPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPasswordLinkLabel_LinkClicked);
            // 
            // usernameErrorProvider
            // 
            this.usernameErrorProvider.ContainerControl = this;
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // hotelManagmentSystemLabel
            // 
            this.hotelManagmentSystemLabel.AutoSize = true;
            this.hotelManagmentSystemLabel.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hotelManagmentSystemLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hotelManagmentSystemLabel.Location = new System.Drawing.Point(24, 131);
            this.hotelManagmentSystemLabel.Name = "hotelManagmentSystemLabel";
            this.hotelManagmentSystemLabel.Size = new System.Drawing.Size(422, 41);
            this.hotelManagmentSystemLabel.TabIndex = 6;
            this.hotelManagmentSystemLabel.Text = "Hotel Managment System";
            this.hotelManagmentSystemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(0, 435);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(62, 41);
            this.testBtn.TabIndex = 7;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Visible = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.logoForm;
            this.pictureBox1.Location = new System.Drawing.Point(150, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(437, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.hotelManagmentSystemLabel);
            this.Controls.Add(this.forgetPasswordLinkLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.signInBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.usernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button signInBtn;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private LinkLabel forgetPasswordLinkLabel;
        private ErrorProvider usernameErrorProvider;
        private ErrorProvider passwordErrorProvider;
        private Label hotelManagmentSystemLabel;
        private Button testBtn;
        private PictureBox pictureBox1;
    }
}