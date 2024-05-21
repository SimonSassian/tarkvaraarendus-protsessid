using Newtonsoft.Json;
using System;
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

        public static BitCoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitCoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }
            return bitcoin;
        }

        private void btnGetRates_Click(object sender, EventArgs e)
        {
            {
                int a;
                if (CurrencyCombo.SelectedItem == null) { return; }
                if (bitcoinTextBox.Text == "") { return; }
                if (Int32.TryParse(bitcoinTextBox.Text, out a))
                {
                    if (CurrencyCombo.SelectedItem.ToString() == "EUR")
                    {
                        resultLabel.Visible = true;
                        resultTextBox.Visible = true;
                        BitCoinRates bitcoin = GetRates();
                        float result = Int32.Parse(bitcoinTextBox.Text) * bitcoin.bpi.EUR.rate_float;
                        resultTextBox.Text = $"{result.ToString()} {bitcoin.bpi.EUR.code}";
                    }
                    else if (CurrencyCombo.SelectedItem.ToString() == "USD")
                    {
                        resultLabel.Visible = true;
                        resultTextBox.Visible = true;
                        BitCoinRates bitcoin = GetRates();
                        float result = Int32.Parse(bitcoinTextBox.Text) * bitcoin.bpi.USD.rate_float;
                        resultTextBox.Text = $"{result.ToString()} {bitcoin.bpi.USD.code}";
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
