using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace AlzaStockCheck
{
    public partial class Form1 : Form
    {

        //TODO zprehlednit tenhle spaghetti sracka kod

        public Label InfoLabel { get { return lb_Info; } }

        private StockParser parser;
        private List<Product> products;
        private List<String> manufacturerFilter; //predelat pak, aby vyrobce nebyl string ale object
        public Form1()
        {
            InitializeComponent();
            parser = new StockParser(this);
            products = new List<Product>();
            manufacturerFilter = new List<string>();
            GetProducts();

        }
        private async void GetProducts()
        {
            lb_Info2.Text = "Getting data...";
            List<Product> localProductList = new List<Product>();
            
            foreach (SKUs type in Enum.GetValues(typeof(SKUs)))
            {
                List<Product> singleChipProducts = new List<Product>();
                singleChipProducts = await Task.Run(() => {
                    return parser.GetProducts(type);
                });

                localProductList.AddRange(singleChipProducts);
            }


            products = localProductList;
            productDataGridView.Rows.Clear();
            lb_Info2.Text = "Done!";
            products.ForEach(x => productDataGridView.Rows.Add(x.Name, x.Price, x.Availability));

        }

        private void cb_CardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string card = cb_CardType.GetItemText(cb_CardType.SelectedItem);
            if (card == "Všechny")
            {
                GetProducts();
                return;
            }
            productDataGridView.Rows.Clear();
            products.Where(x => x.Name.Contains(card)).ToList().ForEach(x => productDataGridView.Rows.Add(x.Name, x.Price, x.Availability));
        }



        private void productDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product selectedGpu = products.Find(x => x.Name == productDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Process.Start(String.Format(@"{0}", selectedGpu.Url));
        }

        private void Manufacturer_Checkbox_Checked_Change(object sender, EventArgs e)
        {
            productDataGridView.Rows.Clear();
            CheckBox triggerObject = (CheckBox)sender;

            if (triggerObject.Checked)
                manufacturerFilter.Add(triggerObject.Text);
            else
                manufacturerFilter.Remove(triggerObject.Text);

            if (manufacturerFilter.Count == 0)
            {
                products.ForEach(x => productDataGridView.Rows.Add(x.Name, x.Price, x.Availability));
            }

            

            Product[] localProducts =  new Product[products.Count];
            products.CopyTo(localProducts);

            List<Product> filteredResults = new List<Product>();

            foreach (String manufacturer in manufacturerFilter)
            {
                foreach (Product product in localProducts)
                {
                    if (product.Manufacturer == manufacturer)
                        filteredResults.Add(product);
                }
            }

            filteredResults.ForEach(x => productDataGridView.Rows.Add(x.Name, x.Price, x.Availability));
                

        }

        private void refreshClockTimer_Tick(object sender, EventArgs e)
        {
            GetProducts();
        }
    }
}
