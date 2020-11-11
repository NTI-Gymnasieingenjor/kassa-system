using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kassa_system;
using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassaSystem
{
    [TestFixture]
    class Tests
    {
        [SetUp]
        public void SetUp()
        {
            // Defines Form
            Form1 form = new Form1();

            // Allows the form the be tested
            form.Show();
        }



        [Test]
        public void TestBulle() 
        {
            // Looks for the tbxSumma element and btnBulle element
            ControlTester tbxSumma = new ControlTester("tbxSumma");
            ButtonTester btnBulle = new ButtonTester("btnBulle");

            // Checks if tbxSumma text is equal to 0
            Assert.AreEqual("0", tbxSumma.Text);

            // Clicks btnBulle button
            btnBulle.Click();

            Assert.AreEqual("10", tbxSumma.Text);

            Assert.AreEqual("Bulle", btnBulle.Text);
        }
        
    }
}
