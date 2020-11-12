using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassaSystem
{
    [TestFixture]
    class CheckBulleText
    {
        // Defines Form
        Form1 form = new Form1();

        // Looks for the tbxSumma element and btnBulle element
        ButtonTester btnBulle = new ButtonTester("btnBulle");

        // Allows the form the be tested

        [Test]
        public void CheckBulleTxt()
        {
            form.Show();

            // Checks if btnBulle text is Bulle
            Assert.AreEqual("Bulle", btnBulle.Text);
        }
    }
}
