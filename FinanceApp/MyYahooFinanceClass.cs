using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YahooFinance;
using YahooFinance.NET;

namespace FinanceApp
{
    public class MyYahooFinanceClass
    {
        private static string cookie = "";
        private static string crumb = "";

        private YahooFinance.NET.YahooFinanceClient MyYahooData = new YahooFinance.NET.YahooFinanceClient(cookie,crumb);

        // Declare a linked list property to store the price history data
        public LinkedList<YahooHistoricalPriceData> PriceHistoryLinkedList { get; set; }
        public LinkedList<double> MovingAverages { get; set; }
        public string txtData = "";
        //---------------------------------------
        //constructor

        public MyYahooFinanceClass()
        { 
        }
        
        //----------------------------------------
        

        // Method to retrieve the price history data and store it in the linked list property
        public void GetDailyPriceHistoryLinkedList(string stockIn, string exchangeIn, DateTime dateFrom, DateTime dateTill)
        {
            // Set the exchange and symbol based on the method parameters
            string exchange = exchangeIn;
            string symbol = stockIn;
            
            // Get the Yahoo stock code for the given exchange and symbol
            var yahooStockCode = this.MyYahooData.GetYahooStockCode(exchange, symbol);
            // Get the price history data for the given stock code and date range
            var priceHistory = this.MyYahooData.GetDailyHistoricalPriceData(yahooStockCode, dateFrom, dateTill);

            // Store the price history data in the linked list property
            this.PriceHistoryLinkedList = new LinkedList<YahooHistoricalPriceData>(priceHistory);

            // Initialize a StringBuilder to construct the text data
            var sb = new StringBuilder();

            foreach (var item in PriceHistoryLinkedList)
            {
                // Access the properties of each YahooHistoricalPriceData item and append them to the StringBuilder
                sb.AppendLine($"Date: {item.Date}, Open: {item.Open}, High: {item.High}, Low: {item.Low}, Close: {item.Close}, Volume: {item.Volume}");
            }

            // Store the combined text data in the txtData string
            txtData = sb.ToString();
        }

        // Method to calculate and set the Moving Average values
        public void CalculateAndSetMovingAverages(int days)
        {
            if (PriceHistoryLinkedList == null || PriceHistoryLinkedList.Count == 0)
            {
                MovingAverages = new LinkedList<double>(); // Set an empty list if no data is available
                return;
            }

            var maValues = new LinkedList<double>();
            var closePrices = PriceHistoryLinkedList.Select(item => item.Close).ToList();

            for (int i = 0; i < closePrices.Count; i++)
            {
                if (i < days - 1)
                {
                    maValues.AddLast(double.NaN); // Not enough data for MA calculation
                }
                else
                {
                    // Calculate the average of the previous 'days' Close prices
                    var sum = 0.0;
                    for (int j = i - days + 1; j <= i; j++)
                    {
                        sum += (double)closePrices[j];
                    }
                    maValues.AddLast(sum / days);
                }
            }

            MovingAverages = maValues;
        }


    }
}
//------------------------------------...ooo000 End of File 000ooo...--------------------------------------//
