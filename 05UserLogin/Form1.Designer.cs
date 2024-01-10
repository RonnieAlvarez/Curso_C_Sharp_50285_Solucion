namespace _05UserLogin
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
            Button btnLogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            lblAdult = new Label();
            lblEmailProvider = new Label();
            lblFullName = new Label();
            label3 = new Label();
            btnClose = new Button();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtDNI = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            lblAge = new Label();
            lblAddress = new Label();
            lblDNI = new Label();
            lblEmail = new Label();
            lblLastName = new Label();
            lblName = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.CausesValidation = false;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(19, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(209, 35);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += OnMouseEnterButton1;
            btnLogin.Leave += OnMouseLeaveButton1;
            btnLogin.MouseEnter += OnMouseEnterButton1;
            btnLogin.MouseLeave += OnMouseLeaveButton1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblDNI);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(294, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 350);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.FromArgb(41, 128, 185);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(41, 128, 185);
            linkLabel1.Location = new Point(19, 322);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(115, 17);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "506rac.gmail.com";
            linkLabel1.VisitedLinkColor = Color.FromArgb(41, 128, 185);
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblAdult);
            panel3.Controls.Add(lblEmailProvider);
            panel3.Controls.Add(lblFullName);
            panel3.Location = new Point(256, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 236);
            panel3.TabIndex = 10;
            panel3.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // lblAdult
            // 
            lblAdult.Location = new Point(14, 147);
            lblAdult.Name = "lblAdult";
            lblAdult.Size = new Size(209, 16);
            lblAdult.TabIndex = 4;
            // 
            // lblEmailProvider
            // 
            lblEmailProvider.Location = new Point(14, 207);
            lblEmailProvider.Name = "lblEmailProvider";
            lblEmailProvider.Size = new Size(209, 16);
            lblEmailProvider.TabIndex = 4;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(14, 177);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(209, 16);
            lblFullName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(19, 307);
            label3.Name = "label3";
            label3.Size = new Size(57, 16);
            label3.TabIndex = 1;
            label3.Text = "Support: ";
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(41, 128, 185);
            btnClose.Location = new Point(465, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 36);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.LightGray;
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Location = new Point(94, 209);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(58, 16);
            txtAge.TabIndex = 6;
            txtAge.Enter += textBox1_Enter;
            txtAge.KeyDown += TextBox_KeyDown;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.LightGray;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(94, 182);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(134, 16);
            txtAddress.TabIndex = 5;
            txtAddress.Enter += textBox1_Enter;
            txtAddress.KeyDown += TextBox_KeyDown;
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.LightGray;
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Location = new Point(94, 155);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 16);
            txtDNI.TabIndex = 4;
            txtDNI.Enter += textBox1_Enter;
            txtDNI.KeyDown += TextBox_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightGray;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(94, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 16);
            txtEmail.TabIndex = 3;
            txtEmail.Enter += textBox1_Enter;
            txtEmail.KeyDown += TextBox_KeyDown;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.LightGray;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Location = new Point(94, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(134, 16);
            txtLastName.TabIndex = 2;
            txtLastName.Enter += textBox1_Enter;
            txtLastName.KeyDown += TextBox_KeyDown;
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightGray;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(94, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(134, 16);
            txtName.TabIndex = 1;
            txtName.Enter += textBox1_Enter;
            txtName.KeyDown += TextBox_KeyDown;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(19, 209);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 15);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age: ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(19, 182);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address: ";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(19, 155);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(33, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 127);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "eMail: ";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(19, 99);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "LastName: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitulo.Location = new Point(68, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(109, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "User Login";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblWelcome);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 350);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(145, 325);
            label2.Name = "label2";
            label2.Size = new Size(95, 16);
            label2.TabIndex = 1;
            label2.Text = "Ronnie Alvarez";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(159, 309);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 1;
            label1.Text = "Develop by: ";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(103, 170);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(137, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Label lblEmail;
        private Label lblLastName;
        private Label lblName;
        private Label lblAddress;
        private Label lblDNI;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtDNI;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label lblAge;
        private Button btnLogin;
        private Label lblAdult;
        private Label lblEmailProvider;
        private Label lblFullName;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
