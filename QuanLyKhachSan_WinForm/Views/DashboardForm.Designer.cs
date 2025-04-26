namespace QuanLyKhachSan_WinForm.Views
{
    partial class DashBoardForm
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
            myUserControl1 = new MyUserControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(myUserControl1);
            panel1.Location = new Point(3, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 195);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 236);
            panel2.TabIndex = 1;
            // 
            // myUserControl1
            // 
            myUserControl1.ChartTitle = "";
            myUserControl1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            myUserControl1.Location = new Point(9, 40);
            myUserControl1.Name = "myUserControl1";
            myUserControl1.SeriesName = "DefaultSeries";
            myUserControl1.Size = new Size(753, 150);
            myUserControl1.TabIndex = 0;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashBoardForm";
            Text = "DashBoardForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MyUserControl myUserControl1;
        private Panel panel2;
    }
}