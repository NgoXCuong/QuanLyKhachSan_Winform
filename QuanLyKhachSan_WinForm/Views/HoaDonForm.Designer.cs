namespace QuanLyKhachSan_WinForm.Views
{
    partial class HoaDonForm
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
            dtNgayLap = new DateTimePicker();
            btnTim = new Button();
            btnExcel = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTim = new TextBox();
            txtTongTien = new TextBox();
            txtMaNhanVien = new TextBox();
            txtMaDatPhong = new TextBox();
            txtMaHoaDon = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvListHoaDon = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListHoaDon).BeginInit();
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
            groupBox1.Controls.Add(dtNgayLap);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(txtMaDatPhong);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1102, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtNgayLap
            // 
            dtNgayLap.Location = new Point(80, 240);
            dtNgayLap.Name = "dtNgayLap";
            dtNgayLap.Size = new Size(259, 25);
            dtNgayLap.TabIndex = 16;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 128, 0);
            btnTim.Location = new Point(877, 240);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 15;
            btnTim.Text = "Tim";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.LimeGreen;
            btnExcel.Location = new Point(877, 190);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(80, 30);
            btnExcel.TabIndex = 14;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.OrangeRed;
            btnXoa.Location = new Point(877, 140);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.Location = new Point(877, 90);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSeaGreen;
            btnThem.Location = new Point(877, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            txtTim.BorderStyle = BorderStyle.FixedSingle;
            txtTim.Location = new Point(673, 245);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(162, 25);
            txtTim.TabIndex = 10;
            // 
            // txtTongTien
            // 
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.Location = new Point(484, 163);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(259, 25);
            txtTongTien.TabIndex = 9;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtMaNhanVien.Location = new Point(484, 86);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(259, 25);
            txtMaNhanVien.TabIndex = 8;
            // 
            // txtMaDatPhong
            // 
            txtMaDatPhong.BorderStyle = BorderStyle.FixedSingle;
            txtMaDatPhong.Location = new Point(80, 160);
            txtMaDatPhong.Name = "txtMaDatPhong";
            txtMaDatPhong.Size = new Size(259, 25);
            txtMaDatPhong.TabIndex = 6;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtMaHoaDon.Location = new Point(80, 80);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(259, 25);
            txtMaHoaDon.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 131);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 50);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 3;
            label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 210);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 2;
            label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 130);
            label2.Name = "label2";
            label2.Size = new Size(100, 19);
            label2.TabIndex = 1;
            label2.Text = "Mã đặt phòng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
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
            groupBox2.Controls.Add(dgvListHoaDon);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1100, 245);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgvListHoaDon
            // 
            dgvListHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListHoaDon.Location = new Point(6, 24);
            dgvListHoaDon.Name = "dgvListHoaDon";
            dgvListHoaDon.Size = new Size(1088, 215);
            dgvListHoaDon.TabIndex = 0;
            // 
            // HoaDonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1124, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "HoaDonForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HoaDonForm";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnTim;
        private Button btnExcel;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTim;
        private TextBox txtTongTien;
        private TextBox txtMaNhanVien;
        private TextBox txtMaDatPhong;
        private TextBox txtMaHoaDon;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvListHoaDon;
        private DateTimePicker dtNgayLap;
    }
}