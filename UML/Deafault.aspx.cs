using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace BitcoinCalculator
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
                WebClient client = new WebClient();
                string json = client.DownloadString(url);
                JObject data = JObject.Parse(json);
                double rate = (double)data["bpi"]["USD"]["rate_float"];
                double bitcoinAmount = double.Parse(textBoxBitcoin.Text);
                double totalPrice = rate * bitcoinAmount;
                labelResult.Text = $"Total: {totalPrice.ToString("C")} USD";
            }
            catch (Exception ex)
            {
                labelResult.Text = "Error: " + ex.Message;
            }
        }
    }
}
