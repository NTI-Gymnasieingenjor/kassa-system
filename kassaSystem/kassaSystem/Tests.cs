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
    class Tests
    {
        // Looks for the tbxSumma element and btnBulle element
        ControlTester tbxSumma = new ControlTester("tbxSumma");
        ButtonTester btnBulle = new ButtonTester("btnBulle");

        [SetUp]
        public void SetUp()
        {
            // Defines Form
            Form1 form = new Form1();

            // Allows the form the be tested
            form.Show();
        }

        [Test]
        public void SummaIsZero()
        {
            // Checks if tbxSumma text is equal to 0
            Assert.AreEqual("0", tbxSumma.Text);
        }



        [Test]
        public void BulleButtonTest()
        {
            // Clicks btnBulle button
            btnBulle.Click();

            // Checks if tbxSumma text is equal to 10 after button click
            Assert.AreEqual("10", tbxSumma.Text);


        }
    }
    class CheckBulleText
    {
        // Looks for the tbxSumma element and btnBulle element
        ControlTester tbxSumma = new ControlTester("tbxSumma");
        ButtonTester btnBulle = new ButtonTester("btnBulle");
        [SetUp]
        public void SetUp()
        {
            // Defines Form
            Form1 form = new Form1();

            // Allows the form the be tested
            form.Show();

        }

        [Test]
        public void CheckBulleTxt()
        {
            // Checks if btnBulle text is Bulle
            Assert.AreEqual("Bulle", btnBulle.Text);
        }
    }
}
