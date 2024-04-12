using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetRates_Click(object sender, EventArgs e)
        {
            if (CurrencyCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select a currency.");
                return;
            }

            if (string.IsNullOrEmpty(amountOfCoinBox.Text))
            {
                MessageBox.Show("Please enter a BTC amount.");
                return;
            }

            resultLabel.Visible = true;
            ResultTextBox.Visible = true;
            BitCoinRates bitcoin = GetRates();

            float rate;
            string code;

            if (CurrencyCombo.SelectedItem.ToString() == "EUR")
            {
                rate = bitcoin.bpi.EUR.rate_float;
                code = bitcoin.bpi.EUR.code;
            }
            else if (CurrencyCombo.SelectedItem.ToString() == "USD")
            {
                rate = bitcoin.bpi.USD.rate_float;
                code = bitcoin.bpi.USD.code;
            }
            else
            {
                MessageBox.Show("Unsupported currency.");
                return;
            }

            float result = float.Parse(amountOfCoinBox.Text) * rate;
            ResultTextBox.Text = $"{result.ToString()} {code}";
        }

        public static BitCoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitCoinRates bitcoin;
            using(var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }

            return bitcoin;
        }
    }
}
