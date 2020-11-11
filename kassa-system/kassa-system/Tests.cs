using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassa_system
{
    [TestFixture]
    class Tests
    {
        Form1 form = new Form1();

        [Test]
        public void TestBulle() 
        {
            form.Show();
            ControlTester tbxSumma = new ControlTester("tbxSumma");
            ButtonTester btnBulle = new ButtonTester("btnBulle");

            Assert.AreEqual("0", tbxSumma.Text);

            btnBulle.Click();

            Assert.AreEqual("10", tbxSumma.Text);

            Assert.AreEqual("Bulle", btnBulle.Text);
        }
        
    }
}
