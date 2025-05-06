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
            lbHoaDon = new Label();
            lbInvoiceDate = new Label();
            lbInvoiceDateOp = new Label();
            lbMaHoaDon = new Label();
            gbRoomCharges = new GroupBox();
            dataGridView1 = new DataGridView();
            lbCustumerName = new Label();
            lbCustumerNameOp = new Label();
            lbCCCD = new Label();
            lbCCCDOp = new Label();
            lbStaff = new Label();
            lbStaffOp = new Label();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            lbTotalRoom = new Label();
            lbTotalServicesOp = new Label();
            lbTotalRoomOp = new Label();
            lbTotalServices = new Label();
            lbVAT = new Label();
            lbSum = new Label();
            lbVATOp = new Label();
            lbSumOp = new Label();
            tbMaHoaDon = new TextBox();
            btnCheck = new Button();
            button1 = new Button();
            button2 = new Button();
            gbRoomCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lbHoaDon
            // 
            lbHoaDon.AutoSize = true;
            lbHoaDon.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHoaDon.Location = new Point(122, 26);
            lbHoaDon.Name = "lbHoaDon";
            lbHoaDon.Size = new Size(143, 37);
            lbHoaDon.TabIndex = 0;
            lbHoaDon.Text = "HÓA ĐƠN";
            // 
            // lbInvoiceDate
            // 
            lbInvoiceDate.AutoSize = true;
            lbInvoiceDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInvoiceDate.Location = new Point(692, 36);
            lbInvoiceDate.Name = "lbInvoiceDate";
            lbInvoiceDate.Size = new Size(166, 25);
            lbInvoiceDate.TabIndex = 1;
            lbInvoiceDate.Text = "Ngày lập hóa đơn:";
            // 
            // lbInvoiceDateOp
            // 
            lbInvoiceDateOp.AutoSize = true;
            lbInvoiceDateOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInvoiceDateOp.Location = new Point(916, 38);
            lbInvoiceDateOp.Name = "lbInvoiceDateOp";
            lbInvoiceDateOp.Size = new Size(116, 25);
            lbInvoiceDateOp.TabIndex = 2;
            lbInvoiceDateOp.Text = "mm/dd/yyyy";
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMaHoaDon.Location = new Point(142, 87);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new Size(123, 25);
            lbMaHoaDon.TabIndex = 3;
            lbMaHoaDon.Text = "Mã hóa đơn: ";
            // 
            // gbRoomCharges
            // 
            gbRoomCharges.Controls.Add(dataGridView1);
            gbRoomCharges.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbRoomCharges.Location = new Point(142, 206);
            gbRoomCharges.Name = "gbRoomCharges";
            gbRoomCharges.Size = new Size(571, 210);
            gbRoomCharges.TabIndex = 5;
            gbRoomCharges.TabStop = false;
            gbRoomCharges.Text = "TIỀN PHÒNG";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(556, 166);
            dataGridView1.TabIndex = 0;
            // 
            // lbCustumerName
            // 
            lbCustumerName.AutoSize = true;
            lbCustumerName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustumerName.Location = new Point(142, 128);
            lbCustumerName.Name = "lbCustumerName";
            lbCustumerName.Size = new Size(121, 25);
            lbCustumerName.TabIndex = 6;
            lbCustumerName.Text = "Khách hàng: ";
            // 
            // lbCustumerNameOp
            // 
            lbCustumerNameOp.AutoSize = true;
            lbCustumerNameOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustumerNameOp.Location = new Point(271, 128);
            lbCustumerNameOp.Name = "lbCustumerNameOp";
            lbCustumerNameOp.Size = new Size(53, 25);
            lbCustumerNameOp.TabIndex = 7;
            lbCustumerNameOp.Text = "(Tên)";
            // 
            // lbCCCD
            // 
            lbCCCD.AutoSize = true;
            lbCCCD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCCCD.Location = new Point(142, 167);
            lbCCCD.Name = "lbCCCD";
            lbCCCD.Size = new Size(63, 25);
            lbCCCD.TabIndex = 8;
            lbCCCD.Text = "CCCD:";
            // 
            // lbCCCDOp
            // 
            lbCCCDOp.AutoSize = true;
            lbCCCDOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCCCDOp.Location = new Point(271, 167);
            lbCCCDOp.Name = "lbCCCDOp";
            lbCCCDOp.Size = new Size(97, 25);
            lbCCCDOp.TabIndex = 9;
            lbCCCDOp.Text = "(Số CCCD)";
            // 
            // lbStaff
            // 
            lbStaff.AutoSize = true;
            lbStaff.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStaff.Location = new Point(692, 87);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(102, 25);
            lbStaff.TabIndex = 10;
            lbStaff.Text = "Nhân viên:";
            // 
            // lbStaffOp
            // 
            lbStaffOp.AutoSize = true;
            lbStaffOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStaffOp.Location = new Point(916, 87);
            lbStaffOp.Name = "lbStaffOp";
            lbStaffOp.Size = new Size(141, 25);
            lbStaffOp.TabIndex = 11;
            lbStaffOp.Text = "(Tên nhân viên)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(142, 433);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 210);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "DỊCH VỤ ĐÃ SỬ DỤNG";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 38);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(556, 166);
            dataGridView2.TabIndex = 0;
            // 
            // lbTotalRoom
            // 
            lbTotalRoom.AutoSize = true;
            lbTotalRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalRoom.Location = new Point(756, 291);
            lbTotalRoom.Name = "lbTotalRoom";
            lbTotalRoom.Size = new Size(156, 25);
            lbTotalRoom.TabIndex = 12;
            lbTotalRoom.Text = "Tổng tiền phòng:";
            // 
            // lbTotalServicesOp
            // 
            lbTotalServicesOp.AutoSize = true;
            lbTotalServicesOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalServicesOp.Location = new Point(955, 350);
            lbTotalServicesOp.Name = "lbTotalServicesOp";
            lbTotalServicesOp.Size = new Size(64, 25);
            lbTotalServicesOp.TabIndex = 13;
            lbTotalServicesOp.Text = "(Total)";
            // 
            // lbTotalRoomOp
            // 
            lbTotalRoomOp.AutoSize = true;
            lbTotalRoomOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalRoomOp.Location = new Point(955, 291);
            lbTotalRoomOp.Name = "lbTotalRoomOp";
            lbTotalRoomOp.Size = new Size(64, 25);
            lbTotalRoomOp.TabIndex = 14;
            lbTotalRoomOp.Text = "(Total)";
            // 
            // lbTotalServices
            // 
            lbTotalServices.AutoSize = true;
            lbTotalServices.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalServices.Location = new Point(756, 350);
            lbTotalServices.Name = "lbTotalServices";
            lbTotalServices.Size = new Size(157, 25);
            lbTotalServices.TabIndex = 15;
            lbTotalServices.Text = "Tổng phí dịch vụ:";
            // 
            // lbVAT
            // 
            lbVAT.AutoSize = true;
            lbVAT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVAT.Location = new Point(756, 408);
            lbVAT.Name = "lbVAT";
            lbVAT.Size = new Size(96, 25);
            lbVAT.TabIndex = 16;
            lbVAT.Text = "VAT(10%):";
            // 
            // lbSum
            // 
            lbSum.AutoSize = true;
            lbSum.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSum.Location = new Point(756, 469);
            lbSum.Name = "lbSum";
            lbSum.Size = new Size(122, 30);
            lbSum.TabIndex = 17;
            lbSum.Text = "Tổng cộng:";
            // 
            // lbVATOp
            // 
            lbVATOp.AutoSize = true;
            lbVATOp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVATOp.Location = new Point(955, 408);
            lbVATOp.Name = "lbVATOp";
            lbVATOp.Size = new Size(71, 25);
            lbVATOp.TabIndex = 18;
            lbVATOp.Text = "(Value)";
            // 
            // lbSumOp
            // 
            lbSumOp.AutoSize = true;
            lbSumOp.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSumOp.Location = new Point(955, 474);
            lbSumOp.Name = "lbSumOp";
            lbSumOp.Size = new Size(77, 30);
            lbSumOp.TabIndex = 19;
            lbSumOp.Text = "(Value)";
            // 
            // tbMaHoaDon
            // 
            tbMaHoaDon.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMaHoaDon.Location = new Point(271, 84);
            tbMaHoaDon.Name = "tbMaHoaDon";
            tbMaHoaDon.Size = new Size(189, 33);
            tbMaHoaDon.TabIndex = 20;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Silver;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = SystemColors.ControlText;
            btnCheck.Location = new Point(491, 84);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(128, 35);
            btnCheck.TabIndex = 21;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(756, 564);
            button1.Name = "button1";
            button1.Size = new Size(128, 61);
            button1.TabIndex = 22;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(927, 564);
            button2.Name = "button2";
            button2.Size = new Size(111, 61);
            button2.TabIndex = 23;
            button2.Text = "TT và In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HoaDonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1144, 697);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCheck);
            Controls.Add(tbMaHoaDon);
            Controls.Add(lbSumOp);
            Controls.Add(lbSum);
            Controls.Add(lbVAT);
            Controls.Add(lbVATOp);
            Controls.Add(lbTotalServices);
            Controls.Add(lbTotalRoomOp);
            Controls.Add(lbTotalServicesOp);
            Controls.Add(lbTotalRoom);
            Controls.Add(groupBox1);
            Controls.Add(lbStaffOp);
            Controls.Add(lbStaff);
            Controls.Add(lbCCCDOp);
            Controls.Add(lbCCCD);
            Controls.Add(lbCustumerNameOp);
            Controls.Add(lbCustumerName);
            Controls.Add(gbRoomCharges);
            Controls.Add(lbMaHoaDon);
            Controls.Add(lbInvoiceDateOp);
            Controls.Add(lbInvoiceDate);
            Controls.Add(lbHoaDon);
            Name = "HoaDonForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HoaDonForm";
            gbRoomCharges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHoaDon;
        private Label lbInvoiceDate;
        private Label lbInvoiceDateOp;
        private Label lbMaHoaDon;
        private GroupBox gbRoomCharges;
        private DataGridView dataGridView1;
        private Label lbCustumerName;
        private Label lbCustumerNameOp;
        private Label lbCCCD;
        private Label lbCCCDOp;
        private Label lbStaff;
        private Label lbStaffOp;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private Label lbTotalServices;
        private Label lbVAT;
        private Label lbSum;
        private Label lbVATOp;
        private Label lbTotalRoom;
        private Label lbTotalServicesOp;
        private Label lbTotalRoomOp;
        private Label lbSumOp;
        private TextBox tbMaHoaDon;
        private Button btnCheck;
        private Button button1;
        private Button button2;
    }
}