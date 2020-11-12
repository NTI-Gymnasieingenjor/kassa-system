﻿using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassaSystem
{
    [TestFixture]
    class KassaSystemTests
    {
        KassaSystem form;

        // Runs at the start of every test
        [SetUp]
        public void SetUp()
        {
            // Starts the program
            form = new KassaSystem();

            // Needed for the form the be tested
            form.Show();
        }

        // Runs at the end of every test
        [TearDown]
        public void TearDown()
        {
            // Closes the program
            form.Close();
        }

        [Test]
        public void TestAddBulle()
        {
            // Gets elements from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonBulle.Click();

            // Checks if tbxSumma text is equal to 10 after button click
            Assert.AreEqual("10", textboxSumma.Text);
        }

        [Test]
        public void TestAddTwoBulle()
        {
            // Gets elements from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonBulle.Click();
            buttonBulle.Click();

            // Checks if tbxSumma text is equal to 20 after button click
            Assert.AreEqual("20", textboxSumma.Text);
        }

        [Test]
        public void TestStartingSummaIsZero()
        {
            // Gets element from form
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            // Checks if tbxSumma text is equal to 0
            Assert.AreEqual("0", textboxSumma.Text);
        }

        [Test]
        public void TestCheckBulleText()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");

            // Checks if btnBulle text is Bulle
            Assert.AreEqual("Bulle", buttonBulle.Text);
        }
    }
}
