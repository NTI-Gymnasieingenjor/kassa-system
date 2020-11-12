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

        private void btnBulle_Click(object sender, EventArgs e)
        {
            var summa = int.Parse(this.tbxSumma.Text);
            summa += 10;
            this.tbxSumma.Text = summa.ToString();
        }
    }
}
