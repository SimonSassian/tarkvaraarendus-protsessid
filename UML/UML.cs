using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace BitcoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
