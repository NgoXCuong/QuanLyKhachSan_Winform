namespace QuanLyKhachSan_WinForm.Views
{
    partial class NhanVienForm
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
            tabControl1 = new TabControl();
            tabQuanLyNhanVien = new TabPage();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            textBox6 = new TextBox();
            btnTim = new Button();
            btnExcel = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvListNhanVien = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            cbChucVu = new ComboBox();
            label6 = new Label();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            label5 = new Label();
            label1 = new Label();
            dtNgaySinh = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPhanQuyenTaiKhoan = new TabPage();
            panel6 = new Panel();
            groupBox5 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel5 = new Panel();
            groupBox6 = new GroupBox();
            dgvListTaiKhoan = new DataGridView();
            panel4 = new Panel();
            groupBox4 = new GroupBox();
            cbQuyen = new ComboBox();
            txtMaNhanVien = new TextBox();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabQuanLyNhanVien.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListNhanVien).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPhanQuyenTaiKhoan.SuspendLayout();
            panel6.SuspendLayout();
            groupBox5.SuspendLayout();
            panel5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListTaiKhoan).BeginInit();
            panel4.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabQuanLyNhanVien);
            tabControl1.Controls.Add(tabPhanQuyenTaiKhoan);
            tabControl1.Location = new Point(4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1120, 608);
            tabControl1.TabIndex = 3;
            // 
            // tabQuanLyNhanVien
            // 
            tabQuanLyNhanVien.BackColor = Color.FromArgb(192, 255, 192);
            tabQuanLyNhanVien.Controls.Add(panel3);
            tabQuanLyNhanVien.Controls.Add(panel2);
            tabQuanLyNhanVien.Controls.Add(panel1);
            tabQuanLyNhanVien.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabQuanLyNhanVien.Location = new Point(4, 26);
            tabQuanLyNhanVien.Name = "tabQuanLyNhanVien";
            tabQuanLyNhanVien.Padding = new Padding(3);
            tabQuanLyNhanVien.Size = new Size(1112, 578);
            tabQuanLyNhanVien.TabIndex = 0;
            tabQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(groupBox3);
            panel3.Location = new Point(833, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 293);
            panel3.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(btnExcel);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(14, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(245, 270);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 10F);
            textBox6.Location = new Point(19, 227);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 25);
            textBox6.TabIndex = 21;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 128, 0);
            btnTim.Font = new Font("Segoe UI", 10F);
            btnTim.Location = new Point(159, 223);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 20;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.LimeGreen;
            btnExcel.Font = new Font("Segoe UI", 10F);
            btnExcel.Location = new Point(146, 130);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(80, 30);
            btnExcel.TabIndex = 19;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.OrangeRed;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(146, 66);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(31, 130);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSeaGreen;
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(31, 66);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 11F);
            panel2.Location = new Point(3, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 270);
            panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvListNhanVien);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(11, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 241);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvListNhanVien
            // 
            dgvListNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListNhanVien.Location = new Point(17, 26);
            dgvListNhanVien.Name = "dgvListNhanVien";
            dgvListNhanVien.Size = new Size(1061, 211);
            dgvListNhanVien.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 293);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbChucVu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(rbNu);
            groupBox1.Controls.Add(rbNam);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtNgaySinh);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(10, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cbChucVu
            // 
            cbChucVu.Font = new Font("Segoe UI", 11F);
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(447, 59);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(163, 28);
            cbChucVu.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(447, 26);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 20;
            label6.Text = "Chức vụ:";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Font = new Font("Segoe UI", 11F);
            rbNu.Location = new Point(132, 216);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(47, 24);
            rbNu.TabIndex = 19;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Font = new Font("Segoe UI", 11F);
            rbNam.Location = new Point(22, 216);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(59, 24);
            rbNam.TabIndex = 18;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(22, 186);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 17;
            label5.Text = "Giới tính:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(22, 106);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 16;
            label1.Text = "Ngày sinh:";
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Font = new Font("Segoe UI", 11F);
            dtNgaySinh.Location = new Point(22, 136);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(288, 27);
            dtNgaySinh.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(447, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(288, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(447, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(22, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 27);
            textBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(447, 186);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(447, 106);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(22, 26);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên:";
            // 
            // tabPhanQuyenTaiKhoan
            // 
            tabPhanQuyenTaiKhoan.BackColor = Color.FromArgb(192, 255, 192);
            tabPhanQuyenTaiKhoan.Controls.Add(panel6);
            tabPhanQuyenTaiKhoan.Controls.Add(panel5);
            tabPhanQuyenTaiKhoan.Controls.Add(panel4);
            tabPhanQuyenTaiKhoan.Font = new Font("Segoe UI Semibold", 11F);
            tabPhanQuyenTaiKhoan.Location = new Point(4, 24);
            tabPhanQuyenTaiKhoan.Name = "tabPhanQuyenTaiKhoan";
            tabPhanQuyenTaiKhoan.Padding = new Padding(3);
            tabPhanQuyenTaiKhoan.Size = new Size(1112, 580);
            tabPhanQuyenTaiKhoan.TabIndex = 1;
            tabPhanQuyenTaiKhoan.Text = "Phân quyền tài khoản nhân viên";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(groupBox5);
            panel6.Location = new Point(884, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 304);
            panel6.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(btnDelete);
            groupBox5.Controls.Add(btnUpdate);
            groupBox5.Controls.Add(btnAdd);
            groupBox5.Location = new Point(13, 8);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(184, 280);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Location = new Point(57, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.Location = new Point(57, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSeaGreen;
            btnAdd.Location = new Point(57, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(groupBox6);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(3, 318);
            panel5.Name = "panel5";
            panel5.Size = new Size(1106, 259);
            panel5.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvListTaiKhoan);
            groupBox6.Location = new Point(8, 16);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1092, 239);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách tài khoản nhân viên";
            // 
            // dgvListTaiKhoan
            // 
            dgvListTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTaiKhoan.Location = new Point(12, 23);
            dgvListTaiKhoan.Name = "dgvListTaiKhoan";
            dgvListTaiKhoan.Size = new Size(1074, 210);
            dgvListTaiKhoan.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(groupBox4);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(872, 304);
            panel4.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(cbQuyen);
            groupBox4.Controls.Add(txtMaNhanVien);
            groupBox4.Controls.Add(txtMatKhau);
            groupBox4.Controls.Add(txtTaiKhoan);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Font = new Font("Segoe UI Semibold", 11F);
            groupBox4.Location = new Point(11, 8);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(847, 280);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin tài khoản";
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Location = new Point(531, 89);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(200, 28);
            cbQuyen.TabIndex = 7;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtMaNhanVien.Location = new Point(531, 186);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(200, 27);
            txtMaNhanVien.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(144, 186);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(200, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Location = new Point(144, 89);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(200, 27);
            txtTaiKhoan.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(531, 149);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 3;
            label10.Text = "Mã nhân viên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(531, 51);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 2;
            label9.Text = "Quyền:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(141, 149);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 1;
            label8.Text = "Mật khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 51);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 0;
            label7.Text = "Tài khoản:";
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1123, 611);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10F);
            Name = "NhanVienForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NhanVienForm";
            tabControl1.ResumeLayout(false);
            tabQuanLyNhanVien.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListNhanVien).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPhanQuyenTaiKhoan.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListTaiKhoan).EndInit();
            panel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabQuanLyNhanVien;
        private Panel panel3;
        private GroupBox groupBox3;
        private TextBox textBox6;
        private Button btnTim;
        private Button btnExcel;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvListNhanVien;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox cbChucVu;
        private Label label6;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private Label label5;
        private Label label1;
        private DateTimePicker dtNgaySinh;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPhanQuyenTaiKhoan;
        private Panel panel6;
        private GroupBox groupBox5;
        private Panel panel5;
        private Panel panel4;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private DataGridView dgvListTaiKhoan;
        private TextBox txtMaNhanVien;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cbQuyen;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
    }
}