using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoDolarHG
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string url = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=af3d072e";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        lb_Buy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lb_Sell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lb_Var.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);
                    }
                    else
                    {
                        lb_Buy.Text = "-";
                        lb_Sell.Text = "-";
                        lb_Var.Text = "-";
                    }
                }
                catch(Exception ex)
                {
                    lb_Buy.Text = "-";
                    lb_Sell.Text = "-";
                    lb_Var.Text = "-";
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
