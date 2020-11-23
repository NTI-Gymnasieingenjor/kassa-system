using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace kassaSystem
{
    public partial class KassaSystem : Form
    {
        public KassaSystem()
        {
            InitializeComponent();
        }

        Dictionary<string, int> productDictionary = new Dictionary<string, int>();
        Dictionary<string, int> priceDictionary = new Dictionary<string, int>();

        private void KassaSystem_Load(object sender, EventArgs e)
        {
            priceDictionary.Add("Bulle", 12);
            priceDictionary.Add("Kaffe", 5);
            priceDictionary.Add("Korv", 10);
            priceDictionary.Add("Läsk", 18);
        }

        private void addToCart(string product, int price)
        {
            if (productDictionary.ContainsKey(product))
            {
                int tidigareAntal = productDictionary[product];
                productDictionary[product] = tidigareAntal + 1;
                // Gets the item with the specified text
                var currentItem = listViewProdukter.FindItemWithText(product);
                // productDictionary[product] gets the value from the product key
                currentItem.Text = product + " x" + productDictionary[product];
            }
            else
            {
                // Adds item to dictionary with the key "product" and the value "1"
                productDictionary.Add(product, 1);
                listViewProdukter.Items.Add(product + " x" + productDictionary[product]);
            }

            updateSumma();
        }

        private void updateSumma()
        {
            textboxSumma.Text = "0";
            foreach (ListViewItem item in listViewProdukter.Items)
            {
                string productName = item.Text.Substring(0, item.Text.LastIndexOf(" "));
                var summa = int.Parse(textboxSumma.Text);
                summa += productDictionary[productName] * priceDictionary[productName];
                textboxSumma.Text = summa.ToString();
            }
        }

        private void buttonBulle_Click(object sender, EventArgs e)
        {
            addToCart("Bulle", priceDictionary["Bulle"]);
        }

        private void buttonNollstall_Click(object sender, EventArgs e)
        {
            textboxSumma.Text = "0";
            listViewProdukter.Clear();
            productDictionary.Clear();
        }

        private void buttonKaffe_Click(object sender, EventArgs e)
        {
            addToCart("Kaffe", priceDictionary["Kaffe"]);
        }

        private void buttonKorv_Click(object sender, EventArgs e)
        {
            addToCart("Korv", priceDictionary["Korv"]);
        }

        private void buttonLask_Click(object sender, EventArgs e)
        {
            addToCart("Läsk", priceDictionary["Läsk"]);
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            try
            {
                string input = listViewProdukter.SelectedItems[0].Text;
                // Extracts product name from string
                string productName = input.Substring(0, input.LastIndexOf(" "));
                // Removes the specified key
                productDictionary.Remove(productName);
                listViewProdukter.Items.Remove(listViewProdukter.SelectedItems[0]);

                // Extracts number of products specified after the x
                // +1 is to skip the x
                string productAmount = input.Substring(input.LastIndexOf("x") + 1);

                // Gets the price by multiplying the product amount with its price
                int price = priceDictionary[productName] * int.Parse(productAmount);

                updateSumma();
            }
            catch { }
        }
    }
}
