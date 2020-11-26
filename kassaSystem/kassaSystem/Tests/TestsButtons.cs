using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassaSystem
{
    class TestsButtons : TestSetup
    {
        public string prisBulle = "12";
        public string prisKaffe = "5";
        public string prisKorv = "10";
        public string prisLask = "18";

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
        public void TestAddLask()
        {
            // Gets elements from form
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonLask.Click();

            // Checks if text is correct
            Assert.AreEqual(prisLask, textboxSumma.Text);
        }

        [Test]
        public void TestAddTwoLask()
        {
            // Gets elements from form
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            buttonLask.Click();
            buttonLask.Click();

            // Converts string to int and multiplies it by 2
            int prisLaskDoubled = int.Parse(prisLask) * 2;

            // Checks if text is correct
            Assert.AreEqual(prisLaskDoubled.ToString(), textboxSumma.Text);
        }

        [Test]
        public void TestIfNollstallButtonResetsSumma()
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
    }
}

