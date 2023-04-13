using BLL.TransferObjects;
using BLL.Workflows;
using LiveCharts;
using LiveCharts.Wpf;
using PBL3.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

            SetupUI();
        }


        #region HELPER FUNCTIONS
        private void SetupUI()
        {
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ngày",
                LabelFormatter = value => (value + 1).ToString("00"),
                MinValue = 0
            });

            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Từ hoặc Giờ",
                LabelFormatter = value => value.ToString(),
                MinValue = 0
            });

            chart.Zoom = ZoomingOptions.X;

            chart.Series.Clear();
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            DataManager dm = new DataManager();
            LearningStats stats = dm.AccountManager.GetLearningStats_ByUID(LoginWorkflow.Instance.GetAccount().AccountID);


            series.Add(new LineSeries
            {
                Title = "Từ",
                Values = new ChartValues<int>(stats.WordStats),
                Fill = new LinearGradientBrush(System.Windows.Media.Color.FromArgb(150, 0, 255, 191),
                    System.Windows.Media.Color.FromArgb(50, 0, 255, 191), 90),
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 255, 191)),
            });


            series.Add(new LineSeries
            {
                Title = "Giờ",
                Values = new ChartValues<int>(stats.TimeStats),
                Fill = new LinearGradientBrush(System.Windows.Media.Color.FromArgb(150, 255, 191, 0),
                        System.Windows.Media.Color.FromArgb(50, 255, 191, 0), 90),
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 191, 0))
            });

            chart.Series = series;
        }
        #endregion

        #region EVENTS
        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.GoBack();
        }

 
        #endregion
    }
}
