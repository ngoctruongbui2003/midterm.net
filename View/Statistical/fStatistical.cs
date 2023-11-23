using LiveCharts;
using LiveCharts.Wpf;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Midterm_CarRental.View.Statistical
{
    public partial class fStatistical : Form
    {
        private readonly IRentRepository _rentRepository;
        private long totalRevenue = 0;

        public fStatistical(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            totalRevenue = 0;
            dgvReport.Rows.Clear();

            DateTime dateStart = Convert.ToDateTime(dtpStart.Value.Date);
            DateTime dateEnd = Convert.ToDateTime(dtpEnd.Value.Date);

            List<StatisticalClass> list = _rentRepository.GetStatisticalToDate(dateStart, dateEnd);

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection();

            var randomColors = GenerateRandomColors(list.Count());

            int i = 0;
            foreach (var item in list)
            {
                i++;

                dgvReport.Rows.Add(new object[]
                {
                    i,
                    item.BrandCar,
                    item.Quantity,
                    item.Revenue.ToString("N0")
                });

                piechartData.Add(
                new PieSeries
                {
                    Title = item.BrandCar,
                    Values = new ChartValues<double> { item.Quantity },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new SolidColorBrush(randomColors[i - 1])
                }
            );

                totalRevenue += item.Revenue;
            }


            pieChart.Series = piechartData;
            pieChart.LegendLocation = LegendLocation.Right;

            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            lbSumRevenue.Text = totalRevenue.ToString("N0");
        }

        static System.Windows.Media.Color GenerateRandomColor()
        {
            Random random = new Random();
            byte red = (byte)random.Next(256);
            byte green = (byte)random.Next(256);
            byte blue = (byte)random.Next(256);
            return System.Windows.Media.Color.FromRgb(red, green, blue);
        }

        static List<System.Windows.Media.Color> GenerateRandomColors(int count)
        {
            var colors = new List<System.Windows.Media.Color>();
            for (int i = 0; i < count; i++)
            {
                colors.Add(GenerateRandomColor());
            }
            return colors;
        }
    }
}
