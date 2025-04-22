namespace QuanLyKhachSan_WinForm.Views
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            btnLogin = new Button();
            groupBox2 = new GroupBox();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            txtUser = new TextBox();
            pictureBox2 = new PictureBox();
            lbLogin = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lbLogin);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Segoe UI", 11F);
            panel1.Location = new Point(150, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 450);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(393, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(218, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Location = new Point(322, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 59);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(46, 26);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 27);
            txtPassword.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Location = new Point(6, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 32);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(322, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 61);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài khoản:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(46, 28);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(286, 27);
            txtUser.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(6, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 29);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lbLogin
            // 
            lbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Arial", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(432, 51);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(120, 38);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "LOGIN";
            lbLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 444);
            panel2.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 34);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 296);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label lbLogin;
        private Button btnLogin;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Button btnExit;
    }
}