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
            tabControl1 = new TabControl();
            tabQuanLyPhong = new TabPage();
            tabLoaiPhong = new TabPage();
            panel2 = new Panel();
            gbListPhong = new GroupBox();
            dgvListPhong = new DataGridView();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            gbNhapPhong = new GroupBox();
            txtTrangThai = new TextBox();
            txtSoPhong = new TextBox();
            lbTrangThai = new Label();
            label3 = new Label();
            lbSoPhong = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            txtTim = new TextBox();
            btnTim = new Button();
            btnExcel = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cbLoaiPhong = new ComboBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dgvListLoaiPhong = new DataGridView();
            tabControl1.SuspendLayout();
            tabQuanLyPhong.SuspendLayout();
            tabLoaiPhong.SuspendLayout();
            panel2.SuspendLayout();
            gbListPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListPhong).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbNhapPhong.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabQuanLyPhong);
            tabControl1.Controls.Add(tabLoaiPhong);
            tabControl1.Location = new Point(4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1118, 604);
            tabControl1.TabIndex = 0;
            // 
            // tabQuanLyPhong
            // 
            tabQuanLyPhong.Controls.Add(panel3);
            tabQuanLyPhong.Controls.Add(panel2);
            tabQuanLyPhong.Controls.Add(panel1);
            tabQuanLyPhong.Location = new Point(4, 26);
            tabQuanLyPhong.Name = "tabQuanLyPhong";
            tabQuanLyPhong.Padding = new Padding(3);
            tabQuanLyPhong.Size = new Size(1110, 574);
            tabQuanLyPhong.TabIndex = 0;
            tabQuanLyPhong.Text = "Quản lý phòng";
            tabQuanLyPhong.UseVisualStyleBackColor = true;
            // 
            // tabLoaiPhong
            // 
            tabLoaiPhong.BackColor = Color.FromArgb(192, 255, 192);
            tabLoaiPhong.Controls.Add(panel6);
            tabLoaiPhong.Controls.Add(panel5);
            tabLoaiPhong.Controls.Add(panel4);
            tabLoaiPhong.Location = new Point(4, 26);
            tabLoaiPhong.Name = "tabLoaiPhong";
            tabLoaiPhong.Padding = new Padding(3);
            tabLoaiPhong.Size = new Size(1110, 574);
            tabLoaiPhong.TabIndex = 1;
            tabLoaiPhong.Text = "Quản lý loại phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(gbListPhong);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 11F);
            panel2.Location = new Point(3, 301);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 270);
            panel2.TabIndex = 3;
            // 
            // gbListPhong
            // 
            gbListPhong.BackColor = Color.White;
            gbListPhong.Controls.Add(dgvListPhong);
            gbListPhong.Location = new Point(12, 16);
            gbListPhong.Name = "gbListPhong";
            gbListPhong.Size = new Size(1100, 251);
            gbListPhong.TabIndex = 0;
            gbListPhong.TabStop = false;
            gbListPhong.Text = "Danh sách phòng";
            // 
            // dgvListPhong
            // 
            dgvListPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListPhong.BackgroundColor = SystemColors.ControlLight;
            dgvListPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPhong.Location = new Point(17, 22);
            dgvListPhong.Name = "dgvListPhong";
            dgvListPhong.Size = new Size(1056, 223);
            dgvListPhong.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(gbNhapPhong);
            panel1.Font = new Font("Segoe UI", 11F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 292);
            panel1.TabIndex = 2;
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
            gbNhapPhong.Controls.Add(cbLoaiPhong);
            gbNhapPhong.Controls.Add(txtTrangThai);
            gbNhapPhong.Controls.Add(txtSoPhong);
            gbNhapPhong.Controls.Add(lbTrangThai);
            gbNhapPhong.Controls.Add(label3);
            gbNhapPhong.Controls.Add(lbSoPhong);
            gbNhapPhong.Location = new Point(12, 3);
            gbNhapPhong.Name = "gbNhapPhong";
            gbNhapPhong.Size = new Size(750, 277);
            gbNhapPhong.TabIndex = 0;
            gbNhapPhong.TabStop = false;
            gbNhapPhong.Text = "Thông tin phòng";
            // 
            // txtTrangThai
            // 
            txtTrangThai.BorderStyle = BorderStyle.FixedSingle;
            txtTrangThai.Location = new Point(252, 210);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(225, 27);
            txtTrangThai.TabIndex = 16;
            // 
            // txtSoPhong
            // 
            txtSoPhong.BorderStyle = BorderStyle.FixedSingle;
            txtSoPhong.Location = new Point(251, 66);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(225, 27);
            txtSoPhong.TabIndex = 13;
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Location = new Point(252, 188);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(78, 20);
            lbTrangThai.TabIndex = 9;
            lbTrangThai.Text = "Trạng thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 115);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Loại phòng:";
            // 
            // lbSoPhong
            // 
            lbSoPhong.AutoSize = true;
            lbSoPhong.Location = new Point(252, 44);
            lbSoPhong.Name = "lbSoPhong";
            lbSoPhong.Size = new Size(76, 20);
            lbSoPhong.TabIndex = 1;
            lbSoPhong.Text = "Số phòng:";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(781, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 286);
            panel3.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTim);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(8, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // txtTim
            // 
            txtTim.BorderStyle = BorderStyle.FixedSingle;
            txtTim.Location = new Point(18, 200);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(158, 25);
            txtTim.TabIndex = 23;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(255, 128, 0);
            btnTim.Location = new Point(200, 195);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(80, 30);
            btnTim.TabIndex = 22;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.LimeGreen;
            btnExcel.Location = new Point(200, 115);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(80, 30);
            btnExcel.TabIndex = 21;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.OrangeRed;
            btnXoa.Location = new Point(200, 65);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 30);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.Location = new Point(50, 115);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 30);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSeaGreen;
            btnThem.Location = new Point(50, 65);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 30);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(253, 142);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(224, 28);
            cbLoaiPhong.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(groupBox2);
            panel4.Location = new Point(4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(805, 266);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(groupBox3);
            panel5.Location = new Point(815, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 265);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(groupBox4);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 280);
            panel6.Name = "panel6";
            panel6.Size = new Size(1104, 291);
            panel6.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(10, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 247);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin loại phòng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Font = new Font("Segoe UI", 11F);
            groupBox3.Location = new Point(8, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(269, 242);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvListLoaiPhong);
            groupBox4.Font = new Font("Segoe UI", 11F);
            groupBox4.Location = new Point(16, 7);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1073, 281);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách loại phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(96, 40);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên loại phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(96, 129);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô tả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(467, 40);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 2;
            label4.Text = "Giá phòng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(467, 129);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 3;
            label5.Text = "Số người tối đa:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(96, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(96, 152);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(200, 60);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(469, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(467, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(15, 179);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 27);
            textBox5.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(183, 174);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 28;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Location = new Point(174, 97);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 27;
            button2.Text = "Xuất Excel";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Location = new Point(174, 47);
            button3.Name = "button3";
            button3.Size = new Size(80, 30);
            button3.TabIndex = 26;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.Location = new Point(24, 97);
            button4.Name = "button4";
            button4.Size = new Size(80, 30);
            button4.TabIndex = 25;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSeaGreen;
            button5.Location = new Point(24, 47);
            button5.Name = "button5";
            button5.Size = new Size(80, 30);
            button5.TabIndex = 24;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = false;
            // 
            // dgvListLoaiPhong
            // 
            dgvListLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListLoaiPhong.Location = new Point(13, 24);
            dgvListLoaiPhong.Name = "dgvListLoaiPhong";
            dgvListLoaiPhong.Size = new Size(1045, 251);
            dgvListLoaiPhong.TabIndex = 0;
            // 
            // PhongForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1124, 611);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10F);
            Name = "PhongForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PhongForm";
            tabControl1.ResumeLayout(false);
            tabQuanLyPhong.ResumeLayout(false);
            tabLoaiPhong.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gbListPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListPhong).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbNhapPhong.ResumeLayout(false);
            gbNhapPhong.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListLoaiPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabQuanLyPhong;
        private Panel panel2;
        private GroupBox gbListPhong;
        private DataGridView dgvListPhong;
        private Panel panel1;
        private DataGridView dataGridView1;
        private GroupBox gbNhapPhong;
        private TextBox txtTrangThai;
        private TextBox txtSoPhong;
        private Label lbTrangThai;
        private Label label3;
        private Label lbSoPhong;
        private TabPage tabLoaiPhong;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtTim;
        private Button btnTim;
        private Button btnExcel;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cbLoaiPhong;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel6;
        private GroupBox groupBox4;
        private Panel panel5;
        private GroupBox groupBox3;
        private Panel panel4;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvListLoaiPhong;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}