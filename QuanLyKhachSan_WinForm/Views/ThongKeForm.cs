using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan_WinForm.Views
{
    public partial class ThongKeForm : Form
    {
        private Panel panelTop, panelBottom;
        private Chart chartDoanhThu, chartLoaiPhong;
        private Color primaryColor = Color.FromArgb(0, 123, 255);
        private Color secondaryColor = Color.FromArgb(248, 249, 250);
        private Color accentColor1 = Color.FromArgb(40, 167, 69);
        private Color accentColor2 = Color.FromArgb(255, 193, 7);
        private Color accentColor3 = Color.FromArgb(220, 53, 69);
        private Color textColor = Color.FromArgb(52, 58, 64);

        public ThongKeForm()
        {
            InitializeComponent();

            this.Text = "Thống Kê Khách Sạn";
            this.Size = new Size(1139, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = secondaryColor;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.Padding = new Padding(5);

            CreateHeader();
            CreateDashboardCards();
            CreateCharts();
        }

        private void CreateHeader()
        {
            Panel panelHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.White,
                //Padding = new Padding(20, 10, 20, 10)
                Padding = new Padding(5, 5, 5, 5)
            };

            Label lblTitle = new Label
            {
                Text = "THỐNG KÊ TỔNG QUAN",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = primaryColor,
                Dock = DockStyle.Left,
                AutoSize = true
            };

            ComboBox cmbTimeRange = new ComboBox
            {
                Width = 200,
                Height = 30,
                Dock = DockStyle.Right,
                Font = new Font("Segoe UI", 11F),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbTimeRange.Items.AddRange(new object[] { "7 ngày qua", "30 ngày qua", "Quý này", "Năm nay" });
            cmbTimeRange.SelectedIndex = 1;

            Label lblTimeRange = new Label
            {
                Text = "Thời gian:",
                Font = new Font("Segoe UI", 11F),
                ForeColor = textColor,
                Dock = DockStyle.Right,
                AutoSize = true,
                Padding = new Padding(0, 5, 10, 0)
            };

            panelHeader.Controls.Add(cmbTimeRange);
            panelHeader.Controls.Add(lblTimeRange);
            panelHeader.Controls.Add(lblTitle);
            this.Controls.Add(panelHeader);
        }

        private void CreateDashboardCards()
        {
            // PANEL CARDS: chứa các thẻ thông tin
            panelTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 125,
                Padding = new Padding(5),
                BackColor = secondaryColor,
                Margin = new Padding(0, 0, 0, 10)
            };

            // TableLayoutPanel chia 4 cột đều nhau
            TableLayoutPanel tableTop = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                BackColor = Color.Transparent
            };
            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            // Tạo các card với biểu tượng và dữ liệu
            tableTop.Controls.Add(CreateModernCard("Lượt khách", "1,250", "+5.2%", "👥", accentColor1), 0, 0);
            tableTop.Controls.Add(CreateModernCard("Doanh thu", "560,850,000đ", "+10.8%", "💰", primaryColor), 1, 0);
            tableTop.Controls.Add(CreateModernCard("Công suất phòng", "78%", "+2.4%", "🏨", accentColor2), 2, 0);
            tableTop.Controls.Add(CreateModernCard("Đánh giá", "4.8/5", "+0.2", "⭐", accentColor3), 3, 0);

            panelTop.Controls.Add(tableTop);
            this.Controls.Add(panelTop);
        }

        private void CreateCharts()
        { 
            // PANEL BOTTOM: chứa biểu đồ
            panelBottom = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10, 170, 10, 10), // Tăng padding cho khoảng cách quanh biểu đồ
                BackColor = secondaryColor
            };

            // TableLayoutPanel với 2 dòng
            TableLayoutPanel tableCharts = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                BackColor = Color.Transparent,
                Margin = new Padding(0)
            };

            // Thiết lập style cho các cột và hàng
            tableCharts.ColumnStyles.Clear();
            tableCharts.RowStyles.Clear();

            // Giảm kích thước từng hàng và cột, tạo khoảng trống
            tableCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            tableCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            // Có thể thêm các khoảng trống giữa các ô bằng cách chèn thêm Panel rỗng nếu cần

            panelBottom.Controls.Add(tableCharts);



            // Chart 1 - Đường và cột kết hợp
            Panel panelChart1 = CreateChartPanel("Doanh thu theo tháng");
            chartDoanhThu = new Chart { Dock = DockStyle.Fill };
            panelChart1.Size = new Size(600, 250);
            chartDoanhThu.ChartAreas.Add(new ChartArea("DoanhThuArea"));
            chartDoanhThu.ChartAreas[0].BackColor = Color.White;
            chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartDoanhThu.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartDoanhThu.ChartAreas[0].AxisX.LineColor = Color.FromArgb(220, 220, 220);
            chartDoanhThu.ChartAreas[0].AxisY.LineColor = Color.FromArgb(220, 220, 220);

            // Thêm dữ liệu doanh thu theo cột
            Series seriesColumns = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(120, primaryColor),
                BorderColor = primaryColor,
                BorderWidth = 1
            };
            seriesColumns.Points.AddXY("T1", 420);
            seriesColumns.Points.AddXY("T2", 380);
            seriesColumns.Points.AddXY("T3", 460);
            seriesColumns.Points.AddXY("T4", 520);
            seriesColumns.Points.AddXY("T5", 480);
            seriesColumns.Points.AddXY("T6", 560);
            chartDoanhThu.Series.Add(seriesColumns);

            // Thêm dữ liệu số lượng khách
            Series seriesLine = new Series("Lượt khách")
            {
                ChartType = SeriesChartType.Line,
                Color = accentColor1,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                MarkerColor = Color.White,
                MarkerBorderColor = accentColor1,
                MarkerBorderWidth = 2,
                YAxisType = AxisType.Secondary
            };
            seriesLine.Points.AddXY("T1", 820);
            seriesLine.Points.AddXY("T2", 950);
            seriesLine.Points.AddXY("T3", 880);
            seriesLine.Points.AddXY("T4", 1050);
            seriesLine.Points.AddXY("T5", 1150);
            seriesLine.Points.AddXY("T6", 1250);
            chartDoanhThu.Series.Add(seriesLine);

            // Thêm trục Y thứ hai
            chartDoanhThu.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            chartDoanhThu.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartDoanhThu.ChartAreas[0].AxisY2.LineColor = Color.FromArgb(220, 220, 220);

            // Legend
            chartDoanhThu.Legends.Add(new Legend("Legend")
            {
                Docking = Docking.Top,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                BorderColor = Color.FromArgb(220, 220, 220)
            });

            panelChart1.Controls.Add(chartDoanhThu);

            // Chart 2 - Doughnut
            Panel panelChart2 = CreateChartPanel("Tỷ lệ loại phòng");

            chartLoaiPhong = new Chart { Dock = DockStyle.Fill };
            panelChart2.Size = new Size(200, 150);

            chartLoaiPhong.ChartAreas.Add(new ChartArea("LoaiPhongArea")
            {
                BackColor = Color.White
            });

            Series seriesPie = new Series("Loại phòng")
            {
                ChartType = SeriesChartType.Doughnut,
                BorderWidth = 1,
                BorderColor = Color.White
            };
            seriesPie.Points.AddXY("Phòng Standard", 45);
            seriesPie.Points.AddXY("Phòng Deluxe", 30);
            seriesPie.Points.AddXY("Phòng Suite", 15);
            seriesPie.Points.AddXY("Phòng Family", 10);

            // Set custom colors
            seriesPie.Points[0].Color = primaryColor;
            seriesPie.Points[1].Color = accentColor1;
            seriesPie.Points[2].Color = accentColor2;
            seriesPie.Points[3].Color = accentColor3;

            // Show percentage
            seriesPie.Label = "#PERCENT{P0}";
            seriesPie.LabelForeColor = Color.White;
            seriesPie.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            chartLoaiPhong.Series.Add(seriesPie);
            chartLoaiPhong.Legends.Add(new Legend("Legend")
            {
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                BorderColor = Color.FromArgb(220, 220, 220)
            });

            panelChart2.Controls.Add(chartLoaiPhong);





            // Chart 3 - Line chart for occupancy rate
            Panel panelChart3 = CreateChartPanel("Tỷ lệ lấp đầy theo ngày");
            
            ///////////////////////////
            panelChart3.Size = new Size(400, 250); // Giảm kích thước Panel
            Chart chartOccupancy = new Chart { Dock = DockStyle.Fill };

            chartOccupancy.ChartAreas.Add(new ChartArea("OccupancyArea"));
            chartOccupancy.ChartAreas[0].BackColor = Color.White;
            chartOccupancy.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartOccupancy.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartOccupancy.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartOccupancy.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartOccupancy.ChartAreas[0].AxisX.LineColor = Color.FromArgb(220, 220, 220);
            chartOccupancy.ChartAreas[0].AxisY.LineColor = Color.FromArgb(220, 220, 220);
            chartOccupancy.ChartAreas[0].AxisY.Maximum = 100;
            chartOccupancy.ChartAreas[0].AxisX.Title = "Phần trăm(%)";
            chartOccupancy.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10F);

            Series seriesArea = new Series("Tỷ lệ lấp đầy")
            {
                ChartType = SeriesChartType.SplineArea,
                Color = Color.FromArgb(80, accentColor2),
                BorderColor = accentColor2,
                BorderWidth = 3
            };

            // Add sample data for days of the week
            seriesArea.Points.AddXY("Thứ 2", 65);
            seriesArea.Points.AddXY("Thứ 3", 60);
            seriesArea.Points.AddXY("Thứ 4", 70);
            seriesArea.Points.AddXY("Thứ 5", 75);
            seriesArea.Points.AddXY("Thứ 6", 85);
            seriesArea.Points.AddXY("Thứ 7", 95);
            seriesArea.Points.AddXY("CN", 90);

            chartOccupancy.Series.Add(seriesArea);
            chartOccupancy.Legends.Add(new Legend("Legend")
            {
                Docking = Docking.Top,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                BorderColor = Color.FromArgb(220, 220, 220)
            });

            panelChart3.Controls.Add(chartOccupancy);

            // Chart 4 - Top room bookings (horizontal bar chart)
            Panel panelChart4 = CreateChartPanel("Top phòng được đặt nhiều nhất");
            Chart chartTopRooms = new Chart { Dock = DockStyle.Fill };
            chartTopRooms.ChartAreas.Add(new ChartArea("TopRoomsArea"));
            chartTopRooms.ChartAreas[0].BackColor = Color.White;
            chartTopRooms.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartTopRooms.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartTopRooms.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartTopRooms.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartTopRooms.ChartAreas[0].AxisX.LineColor = Color.FromArgb(220, 220, 220);
            chartTopRooms.ChartAreas[0].AxisY.LineColor = Color.FromArgb(220, 220, 220);

            Series seriesBar = new Series("Lượt đặt")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true,
                LabelFormat = "{0} lượt",
                Font = new Font("Segoe UI", 9F)
            };

            // Add top rooms data
            DataPoint p1 = new DataPoint(0, 42);
            p1.AxisLabel = "Phòng 301 (Suite)";
            p1.Color = primaryColor;
            seriesBar.Points.Add(p1);

            DataPoint p2 = new DataPoint(0, 38);
            p2.AxisLabel = "Phòng 205 (Deluxe)";
            p2.Color = accentColor1;
            seriesBar.Points.Add(p2);

            DataPoint p3 = new DataPoint(0, 35);
            p3.AxisLabel = "Phòng 101 (Standard)";
            p3.Color = accentColor2;
            seriesBar.Points.Add(p3);

            DataPoint p4 = new DataPoint(0, 27);
            p4.AxisLabel = "Phòng 401 (Family)";
            p4.Color = accentColor3;
            seriesBar.Points.Add(p4);

            chartTopRooms.Series.Add(seriesBar);

            panelChart4.Controls.Add(chartTopRooms);

            // Thêm các Panel vào TableLayoutPanel sau khi Form đã được hiển thị
            this.Shown += (sender, e) =>
            {
                tableCharts.Controls.Add(panelChart1, 0, 0);
                tableCharts.Controls.Add(panelChart2, 1, 0);
                tableCharts.Controls.Add(panelChart3, 0, 1);
                tableCharts.Controls.Add(panelChart4, 1, 1);

                // Cập nhật lại kích thước cho các panel
                panelChart1.Size = new Size(tableCharts.GetColumnWidths()[0] - 16, tableCharts.GetRowHeights()[0] - 16);
                panelChart2.Size = new Size(tableCharts.GetColumnWidths()[1] - 16, tableCharts.GetRowHeights()[0] - 16);
                panelChart3.Size = new Size(tableCharts.GetColumnWidths()[0] - 16, tableCharts.GetRowHeights()[1] - 16);
                panelChart4.Size = new Size(tableCharts.GetColumnWidths()[1] - 16, tableCharts.GetRowHeights()[1] - 16);
            };

            panelBottom.Controls.Add(tableCharts);
            this.Controls.Add(panelBottom);
        }

        private Panel CreateModernCard(string title, string value, string growth, string icon, Color accentColor)
        {
            Panel panel = new Panel
            {
                Height = 40,
                Margin = new Padding(2),
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };

            // Shadow effect with rounded corners
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw rounded rectangle
                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                using (GraphicsPath path = RoundedRect(rect, 10))
                {
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        g.FillPath(brush, path);
                    }
                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    {
                        g.DrawPath(pen, path);
                    }
                }

                // Draw accent line at top
                using (Pen accentPen = new Pen(accentColor, 4))
                {
                    g.DrawLine(accentPen, 0, 0, panel.Width, 0);
                }
            };

            // Icon
            Label lblIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 20, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(15, 15)
            };

            // Title
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(120, 120, 120),
                AutoSize = true,
                Location = new Point(15, 55)
            };

            // Value
            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = textColor,
                AutoSize = true,
                Location = new Point(15, 75)
            };

            // Growth indicator
            Label lblGrowth = new Label
            {
                Text = growth,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = growth.StartsWith("+") ? accentColor1 : accentColor3,
                AutoSize = true,
                Location = new Point(panel.Width - 60, 80)
            };

            panel.Controls.Add(lblIcon);
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblValue);
            panel.Controls.Add(lblGrowth);
            return panel;
        }

        private Panel CreateChartPanel(string title)
        {
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(2),
                BackColor = Color.White,
                Padding = new Padding(15, 40, 15, 15),
                MinimumSize = new Size(100, 100) // Đảm bảo panel luôn có kích thước tối thiểu
            };

            // Shadow effect with rounded corners
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw rounded rectangle
                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                using (GraphicsPath path = RoundedRect(rect, 10))
                {
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        g.FillPath(brush, path);
                    }
                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            };

            // Title label
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = textColor,
                AutoSize = true,
                Location = new Point(15, 15)
            };

            panel.Controls.Add(lblTitle);
            return panel;
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Top left arc
            path.AddArc(arc, 180, 90);

            // Top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace QuanLyKhachSan_WinForm.Views
//{
//    public partial class ThongKeForm : Form
//    {
//        private Panel panelTop, panelBottom;
//        private Chart chartDoanhThu, chartLoaiPhong;
//        private Color primaryColor = Color.FromArgb(0, 123, 255);
//        private Color secondaryColor = Color.FromArgb(248, 249, 250);
//        private Color accentColor1 = Color.FromArgb(40, 167, 69);
//        private Color accentColor2 = Color.FromArgb(255, 193, 7);
//        private Color accentColor3 = Color.FromArgb(220, 53, 69);
//        private Color textColor = Color.FromArgb(52, 58, 64);

//        public ThongKeForm()
//        {
//            InitializeComponent();

//            this.Text = "Thống Kê Khách Sạn";
//            this.Size = new Size(1139, 650);
//            this.StartPosition = FormStartPosition.CenterScreen;
//            this.BackColor = secondaryColor;
//            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
//            this.Padding = new Padding(10);

//            CreateHeader();
//            CreateDashboardCards();
//            CreateCharts();
//        }

//        private void CreateHeader()
//        {
//            Panel panelHeader = new Panel
//            {
//                Dock = DockStyle.Top,
//                Height = 50,
//                BackColor = Color.White,
//                Padding = new Padding(5)
//            };

//            Label lblTitle = new Label
//            {
//                Text = "THỐNG KÊ TỔNG QUAN",
//                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
//                ForeColor = primaryColor,
//                Dock = DockStyle.Left,
//                AutoSize = true,
//                TextAlign = ContentAlignment.MiddleLeft
//            };

//            ComboBox cmbTimeRange = new ComboBox
//            {
//                Width = 180,
//                Height = 30,
//                Dock = DockStyle.Right,
//                Font = new Font("Segoe UI", 10F),
//                DropDownStyle = ComboBoxStyle.DropDownList,
//                FlatStyle = FlatStyle.Flat
//            };
//            cmbTimeRange.Items.AddRange(new object[] { "7 ngày qua", "30 ngày qua", "Quý này", "Năm nay" });
//            cmbTimeRange.SelectedIndex = 1;

//            Label lblTimeRange = new Label
//            {
//                Text = "Thời gian:",
//                Font = new Font("Segoe UI", 10F),
//                ForeColor = textColor,
//                Dock = DockStyle.Right,
//                AutoSize = true,
//                Padding = new Padding(0, 5, 10, 0),
//                TextAlign = ContentAlignment.MiddleRight
//            };

//            panelHeader.Controls.Add(cmbTimeRange);
//            panelHeader.Controls.Add(lblTimeRange);
//            panelHeader.Controls.Add(lblTitle);
//            this.Controls.Add(panelHeader);
//        }

//        private void CreateDashboardCards()
//        {
//            panelTop = new Panel
//            {
//                Dock = DockStyle.Top,
//                Height = 120,
//                Padding = new Padding(5, 10, 5, 5),
//                BackColor = secondaryColor
//            };

//            TableLayoutPanel tableTop = new TableLayoutPanel
//            {
//                Dock = DockStyle.Fill,
//                ColumnCount = 4,
//                RowCount = 1,
//                BackColor = Color.Transparent,
//                Margin = new Padding(0)
//            };
//            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
//            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
//            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
//            tableTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

//            tableTop.Controls.Add(CreateModernCard("Lượt khách", "1,250", "+5.2%", "👥", accentColor1), 0, 0);
//            tableTop.Controls.Add(CreateModernCard("Doanh thu", "560,850,000đ", "+10.8%", "💰", primaryColor), 1, 0);
//            tableTop.Controls.Add(CreateModernCard("Công suất phòng", "78%", "+2.4%", "🏨", accentColor2), 2, 0);
//            tableTop.Controls.Add(CreateModernCard("Đánh giá", "4.8/5", "+0.2", "⭐", accentColor3), 3, 0);

//            panelTop.Controls.Add(tableTop);
//            this.Controls.Add(panelTop);
//        }

//        private void CreateCharts()
//        {
//            panelBottom = new Panel
//            {
//                Dock = DockStyle.Fill,
//                Padding = new Padding(5, 0, 5, 5),
//                BackColor = secondaryColor
//            };

//            TableLayoutPanel tableCharts = new TableLayoutPanel
//            {
//                Dock = DockStyle.Fill,
//                ColumnCount = 2,
//                RowCount = 2,
//                BackColor = Color.Transparent,
//                Margin = new Padding(0)
//            };

//            tableCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
//            tableCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
//            tableCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
//            tableCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

//            // Chart 1 - Combined column and line chart
//            Panel panelChart1 = CreateChartPanel("Doanh thu theo tháng");
//            chartDoanhThu = new Chart { Dock = DockStyle.Fill };
//            chartDoanhThu.ChartAreas.Add(new ChartArea("DoanhThuArea"));
//            chartDoanhThu.ChartAreas[0].BackColor = Color.White;
//            chartDoanhThu.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
//            chartDoanhThu.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
//            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
//            chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
//            chartDoanhThu.ChartAreas[0].AxisX.LineColor = Color.FromArgb(220, 220, 220);
//            chartDoanhThu.ChartAreas[0].AxisY.LineColor = Color.FromArgb(220, 220, 220);

//            Series seriesColumns = new Series("Doanh thu (triệu đồng)")
//            {
//                ChartType = SeriesChartType.Column,
//                Color = Color.FromArgb(120, primaryColor),
//                BorderColor = primaryColor,
//                BorderWidth = 1
//            };
//            seriesColumns.Points.AddXY("T1", 420);
//            seriesColumns.Points.AddXY("T2", 380);
//            seriesColumns.Points.AddXY("T3", 460);
//            seriesColumns.Points.AddXY("T4", 520);
//            seriesColumns.Points.AddXY("T5", 480);
//            seriesColumns.Points.AddXY("T6", 560);
//            chartDoanhThu.Series.Add(seriesColumns);

//            Series seriesLine = new Series("Lượt khách")
//            {
//                ChartType = SeriesChartType.Line,
//                Color = accentColor1,
//                BorderWidth = 2,
//                MarkerStyle = MarkerStyle.Circle,
//                MarkerSize = 6,
//                MarkerColor = Color.White,
//                MarkerBorderColor = accentColor1,
//                YAxisType = AxisType.Secondary
//            };
//            seriesLine.Points.AddXY("T1", 820);
//            seriesLine.Points.AddXY("T2", 950);
//            seriesLine.Points.AddXY("T3", 880);
//            seriesLine.Points.AddXY("T4", 1050);
//            seriesLine.Points.AddXY("T5", 1150);
//            seriesLine.Points.AddXY("T6", 1250);
//            chartDoanhThu.Series.Add(seriesLine);

//            chartDoanhThu.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
//            chartDoanhThu.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
//            chartDoanhThu.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("Segoe UI", 8F);

//            chartDoanhThu.Legends.Add(new Legend("Legend")
//            {
//                Docking = Docking.Top,
//                Alignment = StringAlignment.Center,
//                Font = new Font("Segoe UI", 8F),
//                BackColor = Color.White
//            });

//            panelChart1.Controls.Add(chartDoanhThu);

//            // Chart 2 - Doughnut chart
//            Panel panelChart2 = CreateChartPanel("Tỷ lệ loại phòng");
//            chartLoaiPhong = new Chart { Dock = DockStyle.Fill };
//            chartLoaiPhong.ChartAreas.Add(new ChartArea("LoaiPhongArea")
//            {
//                BackColor = Color.White
//            });

//            Series seriesPie = new Series("Loại phòng")
//            {
//                ChartType = SeriesChartType.Doughnut,
//                BorderWidth = 1,
//                BorderColor = Color.White,
//                Label = "#PERCENT{P0}",
//                LabelForeColor = Color.White,
//                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
//            };
//            seriesPie.Points.AddXY("Standard", 45);
//            seriesPie.Points.AddXY("Deluxe", 30);
//            seriesPie.Points.AddXY("Suite", 15);
//            seriesPie.Points.AddXY("Family", 10);

//            seriesPie.Points[0].Color = primaryColor;
//            seriesPie.Points[1].Color = accentColor1;
//            seriesPie.Points[2].Color = accentColor2;
//            seriesPie.Points[3].Color = accentColor3;

//            chartLoaiPhong.Series.Add(seriesPie);
//            chartLoaiPhong.Legends.Add(new Legend("Legend")
//            {
//                Docking = Docking.Bottom,
//                Alignment = StringAlignment.Center,
//                Font = new Font("Segoe UI", 8F),
//                BackColor = Color.White
//            });

//            panelChart2.Controls.Add(chartLoaiPhong);

//            // Chart 3 - Occupancy rate
//            Panel panelChart3 = CreateChartPanel("Tỷ lệ lấp đầy theo ngày");
//            Chart chartOccupancy = new Chart { Dock = DockStyle.Fill };
//            chartOccupancy.ChartAreas.Add(new ChartArea("OccupancyArea"));
//            chartOccupancy.ChartAreas[0].BackColor = Color.White;
//            chartOccupancy.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
//            chartOccupancy.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
//            chartOccupancy.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
//            chartOccupancy.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
//            chartOccupancy.ChartAreas[0].AxisY.Maximum = 100;
//            chartOccupancy.ChartAreas[0].AxisY.Title = "Tỷ lệ %";
//            chartOccupancy.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 8F);

//            Series seriesArea = new Series("Tỷ lệ lấp đầy")
//            {
//                ChartType = SeriesChartType.SplineArea,
//                Color = Color.FromArgb(80, accentColor2),
//                BorderColor = accentColor2,
//                BorderWidth = 2
//            };
//            seriesArea.Points.AddXY("Thứ 2", 65);
//            seriesArea.Points.AddXY("Thứ 3", 60);
//            seriesArea.Points.AddXY("Thứ 4", 70);
//            seriesArea.Points.AddXY("Thứ 5", 75);
//            seriesArea.Points.AddXY("Thứ 6", 85);
//            seriesArea.Points.AddXY("Thứ 7", 95);
//            seriesArea.Points.AddXY("CN", 90);
//            chartOccupancy.Series.Add(seriesArea);

//            chartOccupancy.Legends.Add(new Legend("Legend")
//            {
//                Docking = Docking.Top,
//                Alignment = StringAlignment.Center,
//                Font = new Font("Segoe UI", 8F),
//                BackColor = Color.White
//            });

//            panelChart3.Controls.Add(chartOccupancy);

//            // Chart 4 - Top rooms
//            Panel panelChart4 = CreateChartPanel("Top phòng được đặt nhiều nhất");
//            Chart chartTopRooms = new Chart { Dock = DockStyle.Fill };
//            chartTopRooms.ChartAreas.Add(new ChartArea("TopRoomsArea"));
//            chartTopRooms.ChartAreas[0].BackColor = Color.White;
//            chartTopRooms.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
//            chartTopRooms.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
//            chartTopRooms.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
//            chartTopRooms.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);

//            Series seriesBar = new Series("Lượt đặt")
//            {
//                ChartType = SeriesChartType.Bar,
//                IsValueShownAsLabel = true,
//                LabelFormat = "{0}",
//                Font = new Font("Segoe UI", 8F)
//            };

//            DataPoint p1 = new DataPoint(0, 42);
//            p1.AxisLabel = "301 (Suite)";
//            p1.Color = primaryColor;
//            seriesBar.Points.Add(p1);

//            DataPoint p2 = new DataPoint(0, 38);
//            p2.AxisLabel = "205 (Deluxe)";
//            p2.Color = accentColor1;
//            seriesBar.Points.Add(p2);

//            DataPoint p3 = new DataPoint(0, 35);
//            p3.AxisLabel = "101 (Standard)";
//            p3.Color = accentColor2;
//            seriesBar.Points.Add(p3);

//            DataPoint p4 = new DataPoint(0, 27);
//            p4.AxisLabel = "401 (Family)";
//            p4.Color = accentColor3;
//            seriesBar.Points.Add(p4);

//            chartTopRooms.Series.Add(seriesBar);
//            panelChart4.Controls.Add(chartTopRooms);

//            // Add charts to table layout
//            tableCharts.Controls.Add(panelChart1, 0, 0);
//            tableCharts.Controls.Add(panelChart2, 1, 0);
//            tableCharts.Controls.Add(panelChart3, 0, 1);
//            tableCharts.Controls.Add(panelChart4, 1, 1);

//            panelBottom.Controls.Add(tableCharts);
//            this.Controls.Add(panelBottom);
//        }

//        private Panel CreateModernCard(string title, string value, string growth, string icon, Color accentColor)
//        {
//            Panel panel = new Panel
//            {
//                Height = 100,
//                Margin = new Padding(5),
//                BackColor = Color.White,
//                Dock = DockStyle.Fill,
//                Padding = new Padding(10)
//            };

//            panel.Paint += (sender, e) =>
//            {
//                Graphics g = e.Graphics;
//                g.SmoothingMode = SmoothingMode.AntiAlias;

//                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
//                using (GraphicsPath path = RoundedRect(rect, 8))
//                {
//                    using (SolidBrush brush = new SolidBrush(Color.White))
//                    {
//                        g.FillPath(brush, path);
//                    }
//                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
//                    {
//                        g.DrawPath(pen, path);
//                    }
//                }

//                using (Pen accentPen = new Pen(accentColor, 3))
//                {
//                    g.DrawLine(accentPen, 0, 0, panel.Width, 0);
//                }
//            };

//            Label lblIcon = new Label
//            {
//                Text = icon,
//                Font = new Font("Segoe UI", 16, FontStyle.Regular),
//                AutoSize = true,
//                Location = new Point(10, 10)
//            };

//            Label lblTitle = new Label
//            {
//                Text = title,
//                Font = new Font("Segoe UI", 9, FontStyle.Regular),
//                ForeColor = Color.FromArgb(120, 120, 120),
//                AutoSize = true,
//                Location = new Point(10, 40)
//            };

//            Label lblValue = new Label
//            {
//                Text = value,
//                Font = new Font("Segoe UI", 14, FontStyle.Bold),
//                ForeColor = textColor,
//                AutoSize = true,
//                Location = new Point(10, 60)
//            };

//            Label lblGrowth = new Label
//            {
//                Text = growth,
//                Font = new Font("Segoe UI", 8, FontStyle.Bold),
//                ForeColor = growth.StartsWith("+") ? accentColor1 : accentColor3,
//                AutoSize = true,
//                Location = new Point(panel.Width - 50, 65)
//            };

//            panel.Controls.Add(lblIcon);
//            panel.Controls.Add(lblTitle);
//            panel.Controls.Add(lblValue);
//            panel.Controls.Add(lblGrowth);
//            return panel;
//        }

//        private Panel CreateChartPanel(string title)
//        {
//            Panel panel = new Panel
//            {
//                Dock = DockStyle.Fill,
//                Margin = new Padding(5),
//                BackColor = Color.White,
//                Padding = new Padding(10, 30, 10, 10)
//            };

//            panel.Paint += (sender, e) =>
//            {
//                Graphics g = e.Graphics;
//                g.SmoothingMode = SmoothingMode.AntiAlias;

//                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
//                using (GraphicsPath path = RoundedRect(rect, 8))
//                {
//                    using (SolidBrush brush = new SolidBrush(Color.White))
//                    {
//                        g.FillPath(brush, path);
//                    }
//                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
//                    {
//                        g.DrawPath(pen, path);
//                    }
//                }
//            };

//            Label lblTitle = new Label
//            {
//                Text = title,
//                Font = new Font("Segoe UI", 10, FontStyle.Bold),
//                ForeColor = textColor,
//                AutoSize = true,
//                Location = new Point(10, 10)
//            };

//            panel.Controls.Add(lblTitle);
//            return panel;
//        }

//        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
//        {
//            int diameter = radius * 2;
//            Size size = new Size(diameter, diameter);
//            Rectangle arc = new Rectangle(bounds.Location, size);
//            GraphicsPath path = new GraphicsPath();

//            if (radius == 0)
//            {
//                path.AddRectangle(bounds);
//                return path;
//            }

//            path.AddArc(arc, 180, 90);
//            arc.X = bounds.Right - diameter;
//            path.AddArc(arc, 270, 90);
//            arc.Y = bounds.Bottom - diameter;
//            path.AddArc(arc, 0, 90);
//            arc.X = bounds.Left;
//            path.AddArc(arc, 90, 90);

//            path.CloseFigure();
//            return path;
//        }
//    }
//}