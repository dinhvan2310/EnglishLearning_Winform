using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Media;

namespace PBL3
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            ((MainForm)Application.OpenForms["MainForm"]).OpenChildForm(FormStack.Pop(), FormStack.FormType.Strong);
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ngày",
                LabelFormatter = value => value.ToString()
            });

            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Từ hoặc Giờ",
                LabelFormatter = value => value.ToString()
            });

            chart.Zoom = ZoomingOptions.X;

            chart.Series.Clear();
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            var v = new List<double> { 1, 2, 3, 4, 5, 8,2,5,21,4,7 };
            var i = new List<int> { 6, 5, 2, 1, 7,8,4,2,1,7,4 };
            series.Add(new LineSeries { Title = "Từ", Values = new ChartValues<double>(v),
                Fill = new LinearGradientBrush(System.Windows.Media.Color.FromArgb(150, 0, 255, 191),
                    System.Windows.Media.Color.FromArgb(50, 0, 255, 191), 90),
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 255, 191)),
            });
            series.Add(new LineSeries { Title = "Giờ", Values = new ChartValues<int>(i),
                Fill = new LinearGradientBrush(System.Windows.Media.Color.FromArgb(150, 255, 191, 0),
                        System.Windows.Media.Color.FromArgb(50, 255, 191, 0), 90),
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 191, 0))
            });

            chart.Series = series;
        }
    }
}
