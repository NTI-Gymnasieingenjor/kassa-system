using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassaSystem
{
    [TestFixture]
    class KassaSystemTests : KassaSystem
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

        // Bulle Tests
        [Test]
        public void TestAddBulle()
        {
            // Gets elements from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonBulle.Click();

            // Checks if text is correct
            Assert.AreEqual(prisBulle, textboxSumma.Text);
        }

        [Test]
        public void TestAddTwoBulle()
        {
            // Gets elements from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonBulle.Click();
            buttonBulle.Click();

            // Converts string to int and multiplies it by 2
            int prisBulleDoubled = int.Parse(prisBulle) * 2;

            // Checks if text is correct
            Assert.AreEqual(prisBulleDoubled.ToString(), textboxSumma.Text);
        }

        [Test]
        public void TestCheckBulleText()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Bulle", buttonBulle.Text);
        }

        // Kaffe Tests
        [Test]
        public void TestAddKaffe()
        {
            // Gets elements from form
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonKaffe.Click();

            // Checks if text is correct
            Assert.AreEqual(prisKaffe, textboxSumma.Text);
        }

        [Test]
        public void TestAddTwoKaffe()
        {
            // Gets elements from form
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonKaffe.Click();
            buttonKaffe.Click();

            // Converts string to int and multiplies it by 2
            int prisKaffeDoubled = int.Parse(prisKaffe) * 2;

            // Checks if text is correct
            Assert.AreEqual(prisKaffeDoubled.ToString(), textboxSumma.Text);
        }

        [Test]
        public void TestCheckKaffeText()
        {
            // Gets element from form
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Kaffe", buttonKaffe.Text);
        }

        // Korv Tests
        [Test]
        public void TestAddKorv()
        {
            // Gets elements from form
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonKorv.Click();

            // Checks if text is correct
            Assert.AreEqual(prisKorv, textboxSumma.Text);
        }

        [Test]
        public void TestAddTwoKorv()
        {
            // Gets elements from form
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonKorv.Click();
            buttonKorv.Click();

            // Converts string to int and multiplies it by 2
            int prisKorvDoubled = int.Parse(prisKorv) * 2;

            // Checks if text is correct
            Assert.AreEqual(prisKorvDoubled.ToString(), textboxSumma.Text);
        }

        [Test]
        public void TestCheckKorvText()
        {
            // Gets element from form
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Korv", buttonKorv.Text);
        }


        // Summa Tests
        [Test]
        public void TestIfResetButtonResetsSumma()
        {
            // Gets elements from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonNollstall = new ButtonTester("buttonNollstall", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonBulle.Click();

            buttonNollstall.Click();

            // Checks if text is correct
            Assert.AreEqual("0", textboxSumma.Text);
        }

        [Test]
        public void TestStartingSummaIsZero()
        {
            // Gets element from form
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("0", textboxSumma.Text);
        }

        // Nollstall Tests
        [Test]
        public void TestCheckNollstallText()
        {
            // Gets element from form
            ButtonTester buttonNollstall = new ButtonTester("buttonNollstall", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Nollställ", buttonNollstall.Text);
        }
    }
}
