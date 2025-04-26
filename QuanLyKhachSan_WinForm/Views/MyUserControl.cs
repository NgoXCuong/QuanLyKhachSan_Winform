using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan_WinForm.Views
{
    public partial class MyUserControl : UserControl
    {
        private Chart chart;

        public MyUserControl()
        {
            chart = new Chart();
            chart.Dock = DockStyle.Fill;

            var area = new ChartArea("MainArea");
            chart.ChartAreas.Add(area);

            var series = new Series("Series1")
            {
                ChartType = SeriesChartType.Column
            };
            series.Points.AddXY("A", 10);
            series.Points.AddXY("B", 20);
            chart.Series.Add(series);

            chart.Titles.Add(new Title("Biểu đồ mẫu"));
            chart.Legends.Add(new Legend("Legend1"));

            this.Controls.Add(chart);
        }

        // ========== PUBLIC PROPERTIES ==========

        [Category("Chart")]
        [Description("Tiêu đề của biểu đồ")]
        public string ChartTitle
        {
            get => chart.Titles.Count > 0 ? chart.Titles[0].Text : "";
            set
            {
                if (chart.Titles.Count == 0)
                    chart.Titles.Add(new Title(value));
                else
                    chart.Titles[0].Text = value;
            }
        }

        [Category("Chart")]
        [Description("Kiểu biểu đồ")]
        public SeriesChartType ChartType
        {
            get => chart.Series[0].ChartType;
            set => chart.Series[0].ChartType = value;
        }

        [Category("Chart")]
        [Description("Tên của Series")]
        public string SeriesName
        {
            get => chart.Series[0].Name;
            set => chart.Series[0].Name = value;
        }

        [Category("Chart")]
        [Description("Màu của Series")]
        public Color SeriesColor
        {
            get => chart.Series[0].Color;
            set => chart.Series[0].Color = value;
        }

        [Category("Chart")]
        [Description("Hiển thị chú thích")]
        public bool ShowLegend
        {
            get => chart.Legends[0].Enabled;
            set => chart.Legends[0].Enabled = value;
        }

        [Category("Chart")]
        [Description("Màu nền biểu đồ")]
        public Color ChartBackColor
        {
            get => chart.BackColor;
            set => chart.BackColor = value;
        }

        [Category("Chart")]
        [Description("Màu nền khu vực vẽ")]
        public Color ChartAreaBackColor
        {
            get => chart.ChartAreas[0].BackColor;
            set => chart.ChartAreas[0].BackColor = value;
        }
    }
}
