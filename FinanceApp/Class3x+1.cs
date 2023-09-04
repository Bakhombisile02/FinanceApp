using LiveCharts.Defaults;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;

namespace FinanceApp
{
    public partial class Class3x_1 : UserControl
    {
        public Class3x_1BackEnd Back = new Class3x_1BackEnd();
        private int seriesCount = 0;
        public Class3x_1()
        {
            InitializeComponent();
        }

        private void txtOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnSubmitClicked(object sender, EventArgs e)
        {
            string userInput = txtBoxXvalue.Text;

            if (!string.IsNullOrEmpty(userInput))
            {
                if (int.TryParse(userInput, out int X))
                {
                    richTxtBoxIterations.Text = string.Empty;
                    await Task.Run(() =>
                    {
                        Back.CalculateAndStoreCollatzSequence(X);
                    });

                    var newSeries = new LineSeries
                    {
                        Title = "Data Series " + (++seriesCount),
                        Values = new ChartValues<ObservablePoint>(Back.ResultLinkedList
                            .Select((value, index) => new ObservablePoint(index, value)))
                    };

                    BeginInvoke((Action)(() =>
                    {
                        richTxtBoxIterations.Text = Back.Sequence;
                        cartesianChart1.Series.Add(newSeries);
                    }));

                    txtBoxXvalue.Clear();
                    GC.Collect();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a number.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an input.");
            }
           
        }
    }
}
