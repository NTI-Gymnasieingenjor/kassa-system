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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string productName = row.Cells[0].Value.ToString();
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
                
                int rowIndex = -1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(product))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                // Creates variable from specified row
                DataGridViewRow currentRow = dataGridView1.Rows[rowIndex];
                currentRow.Cells[1].Value = "x" + productDictionary[product];
                currentRow.Cells[2].Value = priceDictionary[product] * productDictionary[product];
            }
            else
            {
                // Adds item to dictionary with the key "product" and the value "1"
                productDictionary.Add(product, 1);

                // Creates row with info
                dataGridView1.Rows.Add(product,"x" + productDictionary[product], priceDictionary[product]);
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
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh(); // testa att ta bort
            productDictionary.Clear();
        }

        private void toggleOnSelect()
        {
            // Enables buttons when one row is selected
            if (dataGridView1.SelectedRows.Count == 1)
            {
                buttonTaBort.Enabled = true;
                buttonTaBort1x.Enabled = true;
            }

            // Disables buttons when more than 1 or no rows are selected
            else
            {
                buttonTaBort.Enabled = false;
                buttonTaBort1x.Enabled = false;
            }
        }

        private void buttonTaBort1x_Click(object sender, EventArgs e)
        {
            DataGridViewRow input = dataGridView1.SelectedRows[0];
            // Extracts product name from row
            string productName = input.Cells[0].Value.ToString();

            productDictionary[productName] -= 1;

            input.Cells[1].Value = "x" + productDictionary[productName];
            input.Cells[2].Value = priceDictionary[productName] * productDictionary[productName];

            if (productDictionary[productName] == 0)
            {
                productDictionary.Remove(productName);
                dataGridView1.Rows.RemoveAt(input.Index);
            }

            updateSumma();
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            DataGridViewRow input = dataGridView1.SelectedRows[0];
            // Extracts product name from row
            string productName = input.Cells[0].Value.ToString();
            
            // Removes the specified key
            productDictionary.Remove(productName);
            dataGridView1.Rows.RemoveAt(input.Index);

            updateSumma();
        }

        // Calls toggleOnSelect when selection state in dataGridView changes
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            toggleOnSelect();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
        }
    }
}