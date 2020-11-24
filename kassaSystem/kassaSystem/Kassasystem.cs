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

        private void addToCart(string product)
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

        private void button_Click(object sender, EventArgs e)
        {
            addToCart((sender as Button).Text);
        }

        private void buttonNollstall_Click(object sender, EventArgs e)
        {
            textboxSumma.Text = "0";
            listViewProdukter.Clear();
            productDictionary.Clear();
        }

        private void toggleOnSelect()
        {
            // Enables buttons when one item is selected
            if (listViewProdukter.SelectedItems.Count == 1)
            {
                buttonTaBort.Enabled = true;
                buttonTaBort1x.Enabled = true;
            }

            // Disables buttons when more than 1 or no buttons are selected
            else
            {
                buttonTaBort.Enabled = false;
                buttonTaBort1x.Enabled = false;
            }
        }

        private void buttonTaBort1x_Click(object sender, EventArgs e)
        {
            string input = listViewProdukter.SelectedItems[0].Text;
            // Extracts product name from string
            string productName = input.Substring(0, input.LastIndexOf(" "));

            productDictionary[productName] -= 1;

            var currentItem = listViewProdukter.FindItemWithText(productName);
            currentItem.Text = productName + " x" + productDictionary[productName];

            if (productDictionary[productName] == 0)
            {
                productDictionary.Remove(productName);
                listViewProdukter.Items.Remove(listViewProdukter.SelectedItems[0]);
            }

            updateSumma();
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            string input = listViewProdukter.SelectedItems[0].Text;
            // Extracts product name from string
            string productName = input.Substring(0, input.LastIndexOf(" "));

            // Removes the specified key
            productDictionary.Remove(productName);
            listViewProdukter.Items.Remove(listViewProdukter.SelectedItems[0]);

            updateSumma();
            toggleOnSelect();
        }

        // Calls toggleOnSelect when selection state in list changes
        private void listViewProdukter_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            toggleOnSelect();
        }
    }
}