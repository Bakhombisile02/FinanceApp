using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FinanceApp
{
    public partial class FinanceUI : UserControl
    {
        public MyYahooFinanceClass YF = new MyYahooFinanceClass();
        

        public FinanceUI()
        {
            InitializeComponent();
        }

        private async void btnYahoo_Click(object sender, EventArgs e)
        {
            // Clear existing series and axes
            ClearChart();

            // Start a new thread to retrieve daily price history
            await Task.Run(() =>
            {
                // Retrieve daily price history
                YF.GetDailyPriceHistoryLinkedList(txtSymbol.Text, txtExchage.Text, startPicker.Value, EndPicker.Value);

                // Display moving averages if the checkbox is checked
                if (checkBoxMovingAverage.Checked)
                {
                    // Calculate and set moving averages
                    YF.CalculateAndSetMovingAverages((int)numericMA.Value);
                }

                // Display values if the checkbox is checked
                if (checkBoxValues.Checked)
                {
                    // Update the UI from the UI thread
                    this.Invoke((Action)DisplayPriceHistory);
                }

                // Create candlestick data and add it to the chart
                CreateCandlestickSeries();

                // Configure axes
                ConfigureAxes();
            });

            // Display moving averages after the retrieval has completed
            if (checkBoxMovingAverage.Checked)
            {
                DisplayMovingAverages();
            }
        }

        private void DisplayPriceHistory()
        {
            richTextBox1.Text = YF.txtData;
        }

        private void ClearChart()
        {
            cartesianChartStock.Series.Clear();
            cartesianChartStock.AxisX.Clear();
            cartesianChartStock.AxisY.Clear();
        }

        private void CreateCandlestickSeries()
        {
            var candlestickData = YF.PriceHistoryLinkedList.Select(value => new OhlcPoint
            {
                Open = (double)value.Open,
                High = (double)value.High,
                Low = (double)value.Low,
                Close = (double)value.Close
            }).ToList();

            // Update the UI on the UI thread
            this.Invoke((Action)(() =>
            {
                var candlestickSeries = new CandleSeries
                {
                    Title = "Australian Foundation Investment Co Ltd",
                    Values = new ChartValues<OhlcPoint>(candlestickData)
                };

                cartesianChartStock.Series.Add(candlestickSeries);
            }));
        }

        private void ConfigureAxes()
        {
            // Update the UI on the UI thread
            this.Invoke((Action)(() =>
            {
                // Configure X-axis to display dates
                cartesianChartStock.AxisX.Add(new Axis
                {
                    Title = "Date",
                    Labels = YF.PriceHistoryLinkedList.Select(value => value.Date.ToString("yyyy-MM-dd")).ToList(),
                });

                // Configure primary Y-axis
                cartesianChartStock.AxisY.Add(new Axis
                {
                    Title = "Price",
                });
            }));
        }

        private void DisplayMovingAverages()
        {
            YF.CalculateAndSetMovingAverages((int)numericMA.Value);

            var ma50Data = YF.MovingAverages;
            var ma50Series = new LineSeries
            {
                Title = "MA50",
                Values = new ChartValues<double>(ma50Data),
                ScalesYAt = 1,
                StrokeThickness = 2,
                PointGeometry = null,
                Fill = null
            };

            cartesianChartStock.Series.Add(ma50Series);

            // Configure the secondary Y-axis for MA50 data
            cartesianChartStock.AxisY.Add(new Axis
            {
                Title = "MA50",
                Position = AxisPosition.RightTop,
                LabelFormatter = value => value.ToString("N2")
            });
        }
    }
}
