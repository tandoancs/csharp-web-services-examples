using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MyClientApp
{
    public partial class Form1 : Form
    {
        localhost.WebService1 ws = new localhost.WebService1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string countriesJson = ws.Countries();
            DataTable dtCountries = JsonConvert.DeserializeObject<DataTable>(countriesJson);
            dgvCountries.DataSource = dtCountries;
        }
    }
}
