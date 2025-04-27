namespace QuanLyKhachSan_WinForm.Views
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            pTitle = new Panel();
            btnUserProfile = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pExit = new Panel();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            pMenu = new Panel();
            btnDichVu = new Button();
            btnKhachHang = new Button();
            btnHoaDon = new Button();
            btnNhanVien = new Button();
            picDichVu = new PictureBox();
            picKhachHang = new PictureBox();
            btnPhong = new Button();
            picHoaDon = new PictureBox();
            picNhanVien = new PictureBox();
            picPhong = new PictureBox();
            picHome = new PictureBox();
            btnHome = new Button();
            lbAdmin = new Label();
            lbDateTime = new Label();
            pnPage = new Panel();
            pTitle.SuspendLayout();
            panel2.SuspendLayout();
            pExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            SuspendLayout();
            // 
            // pTitle
            // 
            pTitle.BackColor = Color.MediumSeaGreen;
            pTitle.Controls.Add(lbDateTime);
            pTitle.Controls.Add(lbAdmin);
            pTitle.Controls.Add(btnUserProfile);
            pTitle.Controls.Add(label1);
            pTitle.Dock = DockStyle.Top;
            pTitle.Location = new Point(0, 0);
            pTitle.Name = "pTitle";
            pTitle.Size = new Size(1284, 55);
            pTitle.TabIndex = 0;
            // 
            // btnUserProfile
            // 
            btnUserProfile.BackgroundImage = (Image)resources.GetObject("btnUserProfile.BackgroundImage");
            btnUserProfile.BackgroundImageLayout = ImageLayout.Center;
            btnUserProfile.ForeColor = Color.MediumSeaGreen;
            btnUserProfile.Location = new Point(178, 11);
            btnUserProfile.Name = "btnUserProfile";
            btnUserProfile.Size = new Size(40, 36);
            btnUserProfile.TabIndex = 2;
            btnUserProfile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 1;
            label1.Text = "Xin chào!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(pExit);
            panel2.Controls.Add(pMenu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 656);
            panel2.TabIndex = 1;
            // 
            // pExit
            // 
            pExit.Controls.Add(pictureBox2);
            pExit.Controls.Add(btnExit);
            pExit.Dock = DockStyle.Bottom;
            pExit.Location = new Point(0, 616);
            pExit.Name = "pExit";
            pExit.Size = new Size(140, 40);
            pExit.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(3, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Location = new Point(34, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 30);
            btnExit.TabIndex = 0;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pMenu
            // 
            pMenu.BackColor = Color.MediumSeaGreen;
            pMenu.Controls.Add(btnDichVu);
            pMenu.Controls.Add(btnKhachHang);
            pMenu.Controls.Add(btnHoaDon);
            pMenu.Controls.Add(btnNhanVien);
            pMenu.Controls.Add(picDichVu);
            pMenu.Controls.Add(picKhachHang);
            pMenu.Controls.Add(btnPhong);
            pMenu.Controls.Add(picHoaDon);
            pMenu.Controls.Add(picNhanVien);
            pMenu.Controls.Add(picPhong);
            pMenu.Controls.Add(picHome);
            pMenu.Controls.Add(btnHome);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(140, 581);
            pMenu.TabIndex = 2;
            // 
            // btnDichVu
            // 
            btnDichVu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDichVu.Location = new Point(34, 235);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(100, 30);
            btnDichVu.TabIndex = 11;
            btnDichVu.Text = "Dịch vụ";
            btnDichVu.TextAlign = ContentAlignment.MiddleLeft;
            btnDichVu.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKhachHang.Location = new Point(34, 195);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(100, 30);
            btnKhachHang.TabIndex = 10;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHoaDon.Location = new Point(34, 155);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(100, 30);
            btnHoaDon.TabIndex = 9;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhanVien.Location = new Point(34, 115);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(100, 30);
            btnNhanVien.TabIndex = 8;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // picDichVu
            // 
            picDichVu.BackgroundImage = (Image)resources.GetObject("picDichVu.BackgroundImage");
            picDichVu.BackgroundImageLayout = ImageLayout.Center;
            picDichVu.Location = new Point(3, 235);
            picDichVu.Name = "picDichVu";
            picDichVu.Size = new Size(30, 30);
            picDichVu.TabIndex = 7;
            picDichVu.TabStop = false;
            // 
            // picKhachHang
            // 
            picKhachHang.BackgroundImage = (Image)resources.GetObject("picKhachHang.BackgroundImage");
            picKhachHang.BackgroundImageLayout = ImageLayout.Center;
            picKhachHang.Location = new Point(3, 195);
            picKhachHang.Name = "picKhachHang";
            picKhachHang.Size = new Size(30, 30);
            picKhachHang.TabIndex = 6;
            picKhachHang.TabStop = false;
            // 
            // btnPhong
            // 
            btnPhong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPhong.Location = new Point(34, 75);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(100, 30);
            btnPhong.TabIndex = 5;
            btnPhong.Text = "Phòng";
            btnPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnPhong.UseVisualStyleBackColor = true;
            // 
            // picHoaDon
            // 
            picHoaDon.BackgroundImage = (Image)resources.GetObject("picHoaDon.BackgroundImage");
            picHoaDon.BackgroundImageLayout = ImageLayout.Center;
            picHoaDon.Location = new Point(3, 155);
            picHoaDon.Name = "picHoaDon";
            picHoaDon.Size = new Size(30, 30);
            picHoaDon.TabIndex = 4;
            picHoaDon.TabStop = false;
            // 
            // picNhanVien
            // 
            picNhanVien.BackgroundImage = (Image)resources.GetObject("picNhanVien.BackgroundImage");
            picNhanVien.BackgroundImageLayout = ImageLayout.Center;
            picNhanVien.Location = new Point(3, 115);
            picNhanVien.Name = "picNhanVien";
            picNhanVien.Size = new Size(30, 30);
            picNhanVien.TabIndex = 3;
            picNhanVien.TabStop = false;
            // 
            // picPhong
            // 
            picPhong.BackColor = Color.Transparent;
            picPhong.BackgroundImage = (Image)resources.GetObject("picPhong.BackgroundImage");
            picPhong.BackgroundImageLayout = ImageLayout.Center;
            picPhong.Location = new Point(3, 75);
            picPhong.Name = "picPhong";
            picPhong.Size = new Size(30, 30);
            picPhong.TabIndex = 2;
            picPhong.TabStop = false;
            // 
            // picHome
            // 
            picHome.BackColor = Color.Transparent;
            picHome.BackgroundImage = (Image)resources.GetObject("picHome.BackgroundImage");
            picHome.BackgroundImageLayout = ImageLayout.Center;
            picHome.Location = new Point(3, 35);
            picHome.Name = "picHome";
            picHome.Size = new Size(30, 30);
            picHome.TabIndex = 1;
            picHome.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHome.Location = new Point(34, 34);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(100, 30);
            btnHome.TabIndex = 0;
            btnHome.Text = "Trang chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold);
            lbAdmin.Location = new Point(224, 19);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(64, 23);
            lbAdmin.TabIndex = 3;
            lbAdmin.Text = "Admin";
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.Font = new Font("Segoe UI", 11F);
            lbDateTime.ForeColor = SystemColors.ButtonHighlight;
            lbDateTime.Location = new Point(1135, 20);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(44, 20);
            lbDateTime.TabIndex = 4;
            lbDateTime.Text = "Ngày";
            // 
            // pnPage
            // 
            pnPage.Font = new Font("Segoe UI", 10F);
            pnPage.Location = new Point(142, 57);
            pnPage.Name = "pnPage";
            pnPage.Size = new Size(1140, 650);
            pnPage.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 711);
            Controls.Add(pnPage);
            Controls.Add(panel2);
            Controls.Add(pTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý khách sạn";
            pTitle.ResumeLayout(false);
            pTitle.PerformLayout();
            panel2.ResumeLayout(false);
            pExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pTitle;
        private Label label1;
        private Panel panel2;
        private Button btnUserProfile;
        private Panel pExit;
        private Panel pMenu;
        private PictureBox pictureBox2;
        private Button btnExit;
        private PictureBox picHome;
        private Button btnHome;
        private PictureBox picPhong;
        private PictureBox picHoaDon;
        private PictureBox picNhanVien;
        private Button btnPhong;
        private Button btnDichVu;
        private Button btnKhachHang;
        private Button btnHoaDon;
        private Button btnNhanVien;
        private PictureBox picDichVu;
        private PictureBox picKhachHang;
        private Label lbAdmin;
        private Label lbDateTime;
        private Panel pnPage;
    }
}