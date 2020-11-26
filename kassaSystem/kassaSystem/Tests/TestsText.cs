using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassaSystem
{
    class TestsText : TestSetup
    {
        [Test]
        public void TestCheckBulleText()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Bulle", buttonBulle.Text);
        }

        [Test]
        public void TestCheckKaffeText()
        {
            // Gets element from form
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Kaffe", buttonKaffe.Text);
        }

        [Test]
        public void TestCheckKorvText()
        {
            // Gets element from form
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Korv", buttonKorv.Text);
        }

        [Test]
        public void TestCheckLaskText()
        {
            // Gets element from form
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Läsk", buttonLask.Text);
        }

        [Test]
        public void TestStartingSummaIsZero()
        {
            // Gets element from form
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("0", textboxSumma.Text);
        }

        [Test]
        public void TestCheckNollstallText()
        {
            // Gets element from form
            ButtonTester buttonNollstall = new ButtonTester("buttonNollstall", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Nollställ", buttonNollstall.Text);
        }
        [Test]
        public void TestCheckBetalaText()
        {
            // Gets element from form
            ButtonTester buttonBetala = new ButtonTester("buttonBetala", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Betala", buttonBetala.Text);
        }
    }
}
