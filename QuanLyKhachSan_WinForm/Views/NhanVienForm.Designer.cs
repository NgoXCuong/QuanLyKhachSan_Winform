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
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnExcel = new Button();
            btnTim = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dgvListNhanVien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 402);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 11F);
            panel2.Location = new Point(0, 409);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 283);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvListNhanVien);
            groupBox2.Location = new Point(11, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 264);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 132);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 225);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 38);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 132);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(910, 60);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(910, 119);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(910, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(910, 238);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(80, 30);
            btnExcel.TabIndex = 8;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(910, 299);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 9;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(454, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(288, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(454, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(288, 27);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(679, 299);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 27);
            textBox6.TabIndex = 15;
            // 
            // dgvListNhanVien
            // 
            dgvListNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListNhanVien.Location = new Point(12, 26);
            dgvListNhanVien.Name = "dgvListNhanVien";
            dgvListNhanVien.Size = new Size(1083, 232);
            dgvListNhanVien.TabIndex = 0;
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1124, 692);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "NhanVienForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NhanVienForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnTim;
        private Button btnExcel;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private DataGridView dgvListNhanVien;
    }
}