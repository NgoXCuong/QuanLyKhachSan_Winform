﻿namespace QuanLyKhachSan_WinForm.Views
{
    partial class KhachHangForm
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnTim = new Button();
            btnExcel = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTim = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtCCCD = new TextBox();
            txtTenKhachHang = new TextBox();
            txtMaKhachHang = new TextBox();
            lbDiaChi = new Label();
            lbEmail = new Label();
            lbSDT = new Label();
            lbCCCD = new Label();
            lbTenKhachHang = new Label();
            lbMaKhachHang = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvListKhachHang = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 335);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtTenKhachHang);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(lbDiaChi);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbSDT);
            groupBox1.Controls.Add(lbCCCD);
            groupBox1.Controls.Add(lbTenKhachHang);
            groupBox1.Controls.Add(lbMaKhachHang);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 128, 0);
            btnTim.Location = new Point(925, 250);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 17;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.LimeGreen;
            btnExcel.Location = new Point(925, 200);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(80, 30);
            btnExcel.TabIndex = 16;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.OrangeRed;
            btnXoa.Location = new Point(925, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.Location = new Point(925, 100);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSeaGreen;
            btnThem.Location = new Point(925, 50);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            txtTim.BorderStyle = BorderStyle.FixedSingle;
            txtTim.Location = new Point(733, 250);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(170, 25);
            txtTim.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(380, 250);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 25);
            txtDiaChi.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(380, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 25);
            txtEmail.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(380, 70);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 25);
            txtSDT.TabIndex = 9;
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Location = new Point(40, 250);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(200, 25);
            txtCCCD.TabIndex = 8;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhachHang.Location = new Point(40, 160);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(200, 25);
            txtTenKhachHang.TabIndex = 7;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtMaKhachHang.Location = new Point(40, 70);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(200, 25);
            txtMaKhachHang.TabIndex = 6;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(380, 220);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(53, 19);
            lbDiaChi.TabIndex = 5;
            lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(380, 130);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(44, 19);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email:";
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Location = new Point(380, 40);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(92, 19);
            lbSDT.TabIndex = 3;
            lbSDT.Text = "Số điện thoại:";
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Location = new Point(40, 220);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(100, 19);
            lbCCCD.TabIndex = 2;
            lbCCCD.Text = "CCCD/ CMND:";
            // 
            // lbTenKhachHang
            // 
            lbTenKhachHang.AutoSize = true;
            lbTenKhachHang.Location = new Point(40, 130);
            lbTenKhachHang.Name = "lbTenKhachHang";
            lbTenKhachHang.Size = new Size(108, 19);
            lbTenKhachHang.TabIndex = 1;
            lbTenKhachHang.Text = "Tên khách hàng:";
            // 
            // lbMaKhachHang
            // 
            lbMaKhachHang.AutoSize = true;
            lbMaKhachHang.Location = new Point(40, 40);
            lbMaKhachHang.Name = "lbMaKhachHang";
            lbMaKhachHang.Size = new Size(107, 19);
            lbMaKhachHang.TabIndex = 0;
            lbMaKhachHang.Text = "Mã khách hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 341);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 270);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvListKhachHang);
            groupBox2.Location = new Point(12, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1100, 247);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dgvListKhachHang
            // 
            dgvListKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListKhachHang.Location = new Point(17, 24);
            dgvListKhachHang.Name = "dgvListKhachHang";
            dgvListKhachHang.Size = new Size(1066, 217);
            dgvListKhachHang.TabIndex = 0;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1124, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "KhachHangForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "KhachHangForm";
            Load += KhachHangForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button btnTim;
        private Button btnExcel;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTim;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtCCCD;
        private TextBox txtTenKhachHang;
        private TextBox txtMaKhachHang;
        private Label lbDiaChi;
        private Label lbEmail;
        private Label lbSDT;
        private Label lbCCCD;
        private Label lbTenKhachHang;
        private Label lbMaKhachHang;
        private GroupBox groupBox2;
        private DataGridView dgvListKhachHang;
    }
}