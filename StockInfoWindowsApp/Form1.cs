using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace StockInfoW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetStock1_Click(object sender, EventArgs e)
        {
            TabPage Company = new TabPage();
            Company.Name = "tab" + textStock1.Text;
            Company.Text = textStock1.Text;
            ListBox listBox1 = new ListBox();
            listBox1.Name = "list" + textStock1.Text;
            listBox1.Dock = DockStyle.Fill;
            tabStocks.TabPages.Add(Company);
            Company.Controls.Add(listBox1);

            var client = new RestClient("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + textStock1.Text + "&apikey=5KN8H2V0G4OQPZV4");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string stockInfo = response.Content.Replace("\"", string.Empty).Replace("}", string.Empty);
            string[] data = stockInfo.Split(',');
            bool found = false;
            int i = -1;
            foreach (var property in data)
            {
                i++;
                if (i == 0) continue;
                listBox1.Items.Add(property.Trim().Remove(0, 3));
                found = true;
            }
            if (found == false)
            {
                listBox1.Items.Add("INVALID COMPANY CODE");
            }


        }
    }
}
