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
    class BulleButtonTest
    {
        // Defines Form
        Form1 form = new Form1();

        // Looks for the tbxSumma element and btnBulle element
        TextBoxTester tbxSumma = new TextBoxTester("tbxSumma");
        ButtonTester btnBulle = new ButtonTester("btnBulle");

        // Allows the form the be tested

        [Test]
        public void BulleButtonTst()
        {
            form.Show();

            // Clicks btnBulle button
            btnBulle.Click();

            // Checks if tbxSumma text is equal to 10 after button click
            Assert.AreEqual("10", tbxSumma.Text);
        }
    }
}
