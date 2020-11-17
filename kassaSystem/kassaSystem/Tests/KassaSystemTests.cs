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

        // Läsk Tests
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
        public void TestCheckLaskText()
        {
            // Gets element from form
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Läsk", buttonLask.Text);
        }

        // Products list Tests
        [Test]
        public void TestAddBulleToList()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();

            // Checks if text is correct
            Assert.AreEqual("Bulle x1", listViewProdukter.Items[0].Text);
        }

        [Test]
        public void TestAddTwoBulleToList()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonBulle.Click();

            // Checks if text is correct
            Assert.AreEqual("Bulle x2", listViewProdukter.Items[0].Text);
        }

        [Test]
        public void TestAddKaffeToList()
        {
            // Gets element from form
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonKaffe.Click();

            // Checks if text is correct
            Assert.AreEqual("Kaffe x1", listViewProdukter.Items[0].Text);
        }

        [Test]
        public void TestAddKorvToList()
        {
            // Gets element from form
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonKorv.Click();

            // Checks if text is correct
            Assert.AreEqual("Korv x1", listViewProdukter.Items[0].Text);
        }

        [Test]
        public void TestAddLaskToList()
        {
            // Gets element from form
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonLask.Click();

            // Checks if text is correct
            Assert.AreEqual("Läsk x1", listViewProdukter.Items[0].Text);
        }

        // Multiple products Tests
        [Test]
        public void TestAddOneBulleThenOneKaffeAndOneBulleAgainToList()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonKaffe.Click();
            buttonBulle.Click();

            // Checks if list count is 2
            Assert.AreEqual(2, listViewProdukter.Items.Count);
            // Checks if first item in list is correct
            Assert.AreEqual("Bulle x2", listViewProdukter.Items[0].Text);
        }

        // Summa Tests
        [Test]
        public void TestStartingSummaIsZero()
        {
            // Gets element from form
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("0", textboxSumma.Text);
        }

        [Test]
        public void TestIfSummaMatchesProductList()
        {
            // Gets element from form
            TextBoxTester textboxSumma = new TextBoxTester("textboxSumma", "KassaSystem");
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");
            ButtonTester buttonTaBort = new ButtonTester("buttonTaBort", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonLask.Click();
            buttonBulle.Click();
            buttonBulle.Click();
            buttonKaffe.Click();
            buttonKaffe.Click();
            listViewProdukter.Items[1].Selected = true;
            buttonTaBort.Click();

            // Checks if price is correct
            Assert.AreEqual("28", textboxSumma.Text);
        }

        // Nollstall Tests
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

        [Test]
        public void TestIfNollstallButtonResetsList()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");
            ButtonTester buttonNollstall = new ButtonTester("buttonNollstall", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonKorv.Click();
            buttonNollstall.Click();

            // Checks if list is empty
            Assert.AreEqual(0, listViewProdukter.Items.Count);
        }

        [Test]
        public void TestCheckNollstallText()
        {
            // Gets element from form
            ButtonTester buttonNollstall = new ButtonTester("buttonNollstall", "KassaSystem");

            // Checks if text is correct
            Assert.AreEqual("Nollställ", buttonNollstall.Text);
        }

        // Ta Bort Markerad Produkt Tests
        [Test]
        public void TestIfTaBortButtonRemovesMarkedProduct()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");
            ButtonTester buttonTaBort = new ButtonTester("buttonTaBort", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonLask.Click();
            buttonKorv.Click();
            // Focuses on first item in list
            listViewProdukter.Items[0].Selected = true;
            buttonTaBort.Click();

            // Checks if the right item is removed from the list
            Assert.AreNotEqual("Bulle x1", listViewProdukter.Items[0].Text);
        }
    }
}
