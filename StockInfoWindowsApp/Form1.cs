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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

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
            if (String.IsNullOrEmpty(textStock1.Text))
                return;
            string C = textStock1.Text.ToUpper();
            Cursor oldCursor = Cursor;
            Cursor = Cursors.WaitCursor;
            try
            {
                if(tabStocks.TabPages.ContainsKey("tab" + C) == true)
                    return;
                var client = new RestClient("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + C + "&apikey=5KN8H2V0G4OQPZV4");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                string stockInfo = response.Content.Replace("\"", string.Empty).Replace("}", string.Empty);
                if (stockInfo.Contains("price") == false)
                    throw new DataException("Request for " + C + " failed");
                string[] data = stockInfo.Split(',');

                int i = -1;
                TabPage Company = new TabPage("tab" + C);
                Company.Name = "tab" + C;
                Company.Text = C;
                ListBox listBox1 = new ListBox();
                listBox1.Name = "list" + C;
                listBox1.Dock = DockStyle.Fill;
                tabStocks.TabPages.Add(Company);
                Company.Controls.Add(listBox1);
                tabStocks.SelectedTab = Company;

                foreach (var property in data)
                {
                    i++;
                    if (i == 0) continue;
                    listBox1.Items.Add(property.Trim().Remove(0, 3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textStock1.Clear();
                Cursor = oldCursor;
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tabStocks.SelectedTab.Dispose();
        }
    }
}
