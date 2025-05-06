namespace QuanLyKhachSan_WinForm.Views
{
    partial class DichVuForm
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
            txtGiaDichVu = new TextBox();
            txtTenDichVu = new TextBox();
            txtMaDichVu = new TextBox();
            lbGiaDichVu = new Label();
            lbTenDichVu = new Label();
            lbMaDichVu = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox1.Controls.Add(txtGiaDichVu);
            groupBox1.Controls.Add(txtTenDichVu);
            groupBox1.Controls.Add(txtMaDichVu);
            groupBox1.Controls.Add(lbGiaDichVu);
            groupBox1.Controls.Add(lbTenDichVu);
            groupBox1.Controls.Add(lbMaDichVu);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1100, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 128, 0);
            btnTim.Location = new Point(835, 235);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 11;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.LimeGreen;
            btnExcel.Location = new Point(835, 189);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(80, 30);
            btnExcel.TabIndex = 10;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.OrangeRed;
            btnXoa.Location = new Point(835, 140);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.Location = new Point(835, 94);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSeaGreen;
            btnThem.Location = new Point(835, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            txtTim.BorderStyle = BorderStyle.FixedSingle;
            txtTim.Location = new Point(648, 239);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(181, 25);
            txtTim.TabIndex = 6;
            // 
            // txtGiaDichVu
            // 
            txtGiaDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtGiaDichVu.Location = new Point(160, 240);
            txtGiaDichVu.Name = "txtGiaDichVu";
            txtGiaDichVu.Size = new Size(352, 25);
            txtGiaDichVu.TabIndex = 5;
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtTenDichVu.Location = new Point(160, 160);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(352, 25);
            txtTenDichVu.TabIndex = 4;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtMaDichVu.Location = new Point(160, 80);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(352, 25);
            txtMaDichVu.TabIndex = 3;
            // 
            // lbGiaDichVu
            // 
            lbGiaDichVu.AutoSize = true;
            lbGiaDichVu.Location = new Point(160, 210);
            lbGiaDichVu.Name = "lbGiaDichVu";
            lbGiaDichVu.Size = new Size(80, 19);
            lbGiaDichVu.TabIndex = 2;
            lbGiaDichVu.Text = "Giá dịch vụ:";
            // 
            // lbTenDichVu
            // 
            lbTenDichVu.AutoSize = true;
            lbTenDichVu.Location = new Point(160, 130);
            lbTenDichVu.Name = "lbTenDichVu";
            lbTenDichVu.Size = new Size(81, 19);
            lbTenDichVu.TabIndex = 1;
            lbTenDichVu.Text = "Tên dịch vụ:";
            // 
            // lbMaDichVu
            // 
            lbMaDichVu.AutoSize = true;
            lbMaDichVu.Location = new Point(160, 50);
            lbMaDichVu.Name = "lbMaDichVu";
            lbMaDichVu.Size = new Size(80, 19);
            lbMaDichVu.TabIndex = 0;
            lbMaDichVu.Text = "Mã dịch vụ:";
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
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1100, 255);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách dịch vụ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1083, 225);
            dataGridView1.TabIndex = 0;
            // 
            // DichVuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1124, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "DichVuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DichVuForm";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label lbGiaDichVu;
        private Label lbTenDichVu;
        private Label lbMaDichVu;
        private Button btnTim;
        private Button btnExcel;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTim;
        private TextBox txtGiaDichVu;
        private TextBox txtTenDichVu;
        private TextBox txtMaDichVu;
    }
}