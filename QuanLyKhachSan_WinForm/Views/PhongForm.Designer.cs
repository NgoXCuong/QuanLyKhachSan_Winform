namespace QuanLyKhachSan_WinForm.Views
{
    partial class PhongForm
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
            dataGridView1 = new DataGridView();
            gbNhapPhong = new GroupBox();
            txtTim = new TextBox();
            txtTrangThai = new TextBox();
            txtDonGia = new TextBox();
            txtLoaiPhong = new TextBox();
            txtSoPhong = new TextBox();
            txtMaPhong = new TextBox();
            rtbMoTa = new RichTextBox();
            lbMoTa = new Label();
            lbTrangThai = new Label();
            lbDonGia = new Label();
            label3 = new Label();
            btnTim = new Button();
            btnExcel = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lbSoPhong = new Label();
            lbMaPhong = new Label();
            panel2 = new Panel();
            gbListPhong = new GroupBox();
            dgvListPhong = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbNhapPhong.SuspendLayout();
            panel2.SuspendLayout();
            gbListPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListPhong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(gbNhapPhong);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 361);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(118, 406);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(309, 209);
            dataGridView1.TabIndex = 0;
            // 
            // gbNhapPhong
            // 
            gbNhapPhong.BackColor = Color.White;
            gbNhapPhong.Controls.Add(txtTim);
            gbNhapPhong.Controls.Add(txtTrangThai);
            gbNhapPhong.Controls.Add(txtDonGia);
            gbNhapPhong.Controls.Add(txtLoaiPhong);
            gbNhapPhong.Controls.Add(txtSoPhong);
            gbNhapPhong.Controls.Add(txtMaPhong);
            gbNhapPhong.Controls.Add(rtbMoTa);
            gbNhapPhong.Controls.Add(lbMoTa);
            gbNhapPhong.Controls.Add(lbTrangThai);
            gbNhapPhong.Controls.Add(lbDonGia);
            gbNhapPhong.Controls.Add(label3);
            gbNhapPhong.Controls.Add(btnTim);
            gbNhapPhong.Controls.Add(btnExcel);
            gbNhapPhong.Controls.Add(btnXoa);
            gbNhapPhong.Controls.Add(btnSua);
            gbNhapPhong.Controls.Add(btnThem);
            gbNhapPhong.Controls.Add(lbSoPhong);
            gbNhapPhong.Controls.Add(lbMaPhong);
            gbNhapPhong.Location = new Point(12, 3);
            gbNhapPhong.Name = "gbNhapPhong";
            gbNhapPhong.Size = new Size(1100, 303);
            gbNhapPhong.TabIndex = 0;
            gbNhapPhong.TabStop = false;
            gbNhapPhong.Text = "Thông tin phòng";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(764, 247);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(180, 27);
            txtTim.TabIndex = 17;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(417, 138);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(225, 27);
            txtTrangThai.TabIndex = 16;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(417, 67);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(225, 27);
            txtDonGia.TabIndex = 15;
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.Location = new Point(27, 209);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.Size = new Size(225, 27);
            txtLoaiPhong.TabIndex = 14;
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(26, 138);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(225, 27);
            txtSoPhong.TabIndex = 13;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(27, 67);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(225, 27);
            txtMaPhong.TabIndex = 12;
            // 
            // rtbMoTa
            // 
            rtbMoTa.Location = new Point(417, 209);
            rtbMoTa.Name = "rtbMoTa";
            rtbMoTa.Size = new Size(225, 64);
            rtbMoTa.TabIndex = 11;
            rtbMoTa.Text = "";
            // 
            // lbMoTa
            // 
            lbMoTa.AutoSize = true;
            lbMoTa.Location = new Point(417, 187);
            lbMoTa.Name = "lbMoTa";
            lbMoTa.Size = new Size(51, 20);
            lbMoTa.TabIndex = 10;
            lbMoTa.Text = "Mô tả:";
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Location = new Point(417, 116);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(78, 20);
            lbTrangThai.TabIndex = 9;
            lbTrangThai.Text = "Trạng thái:";
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Location = new Point(417, 45);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(65, 20);
            lbDonGia.TabIndex = 8;
            lbDonGia.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 187);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Loại phòng:";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 128, 0);
            btnTim.Location = new Point(960, 243);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 6;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.LimeGreen;
            btnExcel.Location = new Point(960, 193);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(80, 30);
            btnExcel.TabIndex = 5;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.OrangeRed;
            btnXoa.Location = new Point(960, 143);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.Location = new Point(960, 93);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSeaGreen;
            btnThem.Location = new Point(960, 43);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // lbSoPhong
            // 
            lbSoPhong.AutoSize = true;
            lbSoPhong.Location = new Point(27, 116);
            lbSoPhong.Name = "lbSoPhong";
            lbSoPhong.Size = new Size(76, 20);
            lbSoPhong.TabIndex = 1;
            lbSoPhong.Text = "Số phòng:";
            // 
            // lbMaPhong
            // 
            lbMaPhong.AutoSize = true;
            lbMaPhong.Location = new Point(27, 45);
            lbMaPhong.Name = "lbMaPhong";
            lbMaPhong.Size = new Size(80, 20);
            lbMaPhong.TabIndex = 0;
            lbMaPhong.Text = "Mã phòng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(gbListPhong);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 11F);
            panel2.Location = new Point(0, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 299);
            panel2.TabIndex = 1;
            // 
            // gbListPhong
            // 
            gbListPhong.BackColor = Color.White;
            gbListPhong.Controls.Add(dgvListPhong);
            gbListPhong.Location = new Point(12, 3);
            gbListPhong.Name = "gbListPhong";
            gbListPhong.Size = new Size(1100, 284);
            gbListPhong.TabIndex = 0;
            gbListPhong.TabStop = false;
            gbListPhong.Text = "Danh sách phòng";
            // 
            // dgvListPhong
            // 
            dgvListPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListPhong.BackgroundColor = SystemColors.ControlLight;
            dgvListPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPhong.Location = new Point(15, 22);
            dgvListPhong.Name = "dgvListPhong";
            dgvListPhong.Size = new Size(1067, 256);
            dgvListPhong.TabIndex = 0;
            // 
            // PhongForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1124, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "PhongForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PhongForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbNhapPhong.ResumeLayout(false);
            gbNhapPhong.PerformLayout();
            panel2.ResumeLayout(false);
            gbListPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox gbNhapPhong;
        private GroupBox gbListPhong;
        private DataGridView dataGridView1;
        private DataGridView dgvListPhong;
        private Label lbSoPhong;
        private Label lbMaPhong;
        private Label lbTrangThai;
        private Label lbDonGia;
        private Label label3;
        private Button btnTim;
        private Button btnExcel;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lbMoTa;
        private TextBox txtTim;
        private TextBox txtTrangThai;
        private TextBox txtDonGia;
        private TextBox txtLoaiPhong;
        private TextBox txtSoPhong;
        private TextBox txtMaPhong;
        private RichTextBox rtbMoTa;
    }
}