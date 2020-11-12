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
    class SummaIsZero
    {
        // Defines Form
        Form1 form = new Form1();

        // Looks for the tbxSumma element and btnBulle element
        TextBoxTester tbxSumma = new TextBoxTester("tbxSumma");

       // Allows the form the be tested

        [Test]
        public void SummaIsZro()
        {
            form.Show();

            // Checks if tbxSumma text is equal to 0
            Assert.AreEqual("0", tbxSumma.Text);
        }
    }
}
