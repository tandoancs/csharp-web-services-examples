using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeConvertWS
{
    public partial class Form1 : Form
    {

        ConvertWS.localhost.ConvertWS ws = new ConvertWS.localhost.ConvertWS();

        public Form1()
        {
            InitializeComponent();

           
        }

        private void btnVND2USD_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.VND2USD(mon);

            txtResult.Text = usd.ToString();
            //format number
            txtResult.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtResult.Text));
        }

        private void btnVND2EUR_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.VND2EUR(mon);

            txtResult.Text = usd.ToString();
            txtResult.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtResult.Text));
        }

        private void btnUSD2VND_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.USD2VND(mon);

            txtResult.Text = usd.ToString();
            txtResult.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtResult.Text));
        }

        private void btnEUR2VND_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.EUR2VND(mon);

            txtResult.Text = usd.ToString();
            txtResult.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(txtResult.Text));

        }
    }
}
