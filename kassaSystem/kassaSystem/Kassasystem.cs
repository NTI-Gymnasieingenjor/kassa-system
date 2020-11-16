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

        private void buttonBulle_Click(object sender, EventArgs e)
        {
            var summa = int.Parse(this.textboxSumma.Text);
            summa += int.Parse(prisBulle);
            this.textboxSumma.Text = summa.ToString();
        }

        private void buttonNollstall_Click(object sender, EventArgs e)
        {
            textboxSumma.Text = "0";
        }

        private void buttonKaffe_Click(object sender, EventArgs e)
        {
            var summa = int.Parse(this.textboxSumma.Text);
            summa += int.Parse(prisKaffe);
            this.textboxSumma.Text = summa.ToString();
        }
    }
}
