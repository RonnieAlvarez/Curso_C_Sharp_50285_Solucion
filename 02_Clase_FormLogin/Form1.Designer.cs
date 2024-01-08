namespace _02_Clase_FormLogin
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
            groupBox1 = new GroupBox();
            lblProfile = new Label();
            lblMessage = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.SkyBlue;
            groupBox1.Controls.Add(lblProfile);
            groupBox1.Controls.Add(lblMessage);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(250, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblProfile
            // 
            lblProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfile.ForeColor = SystemColors.ActiveCaptionText;
            lblProfile.Location = new Point(90, 201);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(127, 23);
            lblProfile.TabIndex = 5;
            lblProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Bottom;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = SystemColors.ButtonHighlight;
            lblMessage.Location = new Point(3, 367);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(294, 30);
            lblMessage.TabIndex = 4;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(90, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(90, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password (8 Digits)";
            txtPassword.Size = new Size(127, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 239);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "UserName";
            txtName.Size = new Size(127, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SkyBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 461);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label lblMessage;
        private Button btnLogin;
        private Label lblProfile;
    }
}
