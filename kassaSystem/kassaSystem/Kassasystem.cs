using System;
using System.Windows.Forms;

namespace kassaSystem
{
    public partial class KassaSystem : Form
    {
        public KassaSystem()
        {
            InitializeComponent();
        }

        public string prisBulle = "12";
        public string prisKaffe = "5";
        public string prisKorv = "10";
        public string prisLask = "18";

        public int indexBulle;
        public int indexKaffe;
        public int indexKorv;
        public int indexLask;
        private void buttonBulle_Click(object sender, EventArgs e)
        {
            var summa = int.Parse(this.textboxSumma.Text);
            summa += int.Parse(prisBulle);
            this.textboxSumma.Text = summa.ToString();

            string productType = "Bulle";

            // If list item doesn't exist, create list item
            if (listViewProdukter.FindItemWithText(productType) == null)
            {
                indexBulle = 1;
                listViewProdukter.Items.Add(productType + " x" + indexBulle);
            }
            // Find list item and increase its value by 1
            else
            {
                indexBulle += 1;
                var currentItem = listViewProdukter.FindItemWithText(productType);
                currentItem.Text = productType + " x" + indexBulle;
            }   
        }

        private void buttonNollstall_Click(object sender, EventArgs e)
        {
            textboxSumma.Text = "0";
            listViewProdukter.Clear();
        }

        private void buttonKaffe_Click(object sender, EventArgs e)
        {
            var summa = int.Parse(this.textboxSumma.Text);
            summa += int.Parse(prisKaffe);
            this.textboxSumma.Text = summa.ToString();

            string productType = "Kaffe";

            // If list item doesn't exist, create list item
            if (listViewProdukter.FindItemWithText(productType) == null)
            {
                indexKaffe = 1;
                listViewProdukter.Items.Add(productType + " x" + indexKaffe);
            }
            // Find list item and increase its value by 1
            else
            {
                indexKaffe += 1;
                var currentItem = listViewProdukter.FindItemWithText(productType);
                currentItem.Text = productType + " x" + indexKaffe;
            }
        }

        private void buttonKorv_Click(object sender, EventArgs e)
        {
            var summa = int.Parse(this.textboxSumma.Text);
            summa += int.Parse(prisKorv);
            this.textboxSumma.Text = summa.ToString();

            string productType = "Korv";

            // If list item doesn't exist, create list item
            if (listViewProdukter.FindItemWithText(productType) == null)
            {
                indexKorv = 1;
                listViewProdukter.Items.Add(productType + " x" + indexKorv);
            }
            // Find list item and increase its value by 1
            else
            {
                indexKorv += 1;
                var currentItem = listViewProdukter.FindItemWithText(productType);
                currentItem.Text = productType + " x" + indexKorv;
            }
        }

        private void buttonLask_Click(object sender, EventArgs e)
        {
            var summa = int.Parse(this.textboxSumma.Text);
            summa += int.Parse(prisLask);
            this.textboxSumma.Text = summa.ToString();

            string productType = "Läsk";

            // If list item doesn't exist, create list item
            if (listViewProdukter.FindItemWithText(productType) == null)
            {
                indexLask = 1;
                listViewProdukter.Items.Add(productType + " x" + indexLask);
            }
            // Find list item and increase its value by 1
            else
            {
                indexLask += 1;
                var currentItem = listViewProdukter.FindItemWithText(productType);
                currentItem.Text = productType + " x" + indexLask;
            }
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            try
            { 
                listViewProdukter.Items.Remove(listViewProdukter.SelectedItems[0]);
            }
            catch { }
        }
    }
}
