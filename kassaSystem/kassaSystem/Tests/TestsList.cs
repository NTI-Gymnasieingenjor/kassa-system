using NUnit.Extensions.Forms;
using NUnit.Framework;

namespace kassaSystem
{
    [TestFixture]
    class TestsList : KassaSystem
    {
        KassaSystem form;

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
        public void TestAddBulleToList()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");

            buttonBulle.Click();

            // Checks if text is correct
            Assert.AreEqual("Bulle", dataGridView1.Rows[0].Cells[0].Value);
            //Assert.AreEqual("x1", dataGridView1.Rows[0].Cells[2].Value);
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

        [Test]
        public void TestIfIndexRestartsFromOne()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            ButtonTester buttonTaBort = new ButtonTester("buttonTaBort", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonKaffe.Click();
            buttonBulle.Click();
            // Focuses on first item in list
            listViewProdukter.Items[0].Selected = true;
            buttonTaBort.Click();
            buttonBulle.Click();

            // Checks if second item in list is correct
            Assert.AreEqual("Bulle x1", listViewProdukter.Items[1].Text);
        }

        [Test]
        public void TestIfNollstallButtonResetsList()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");
            ButtonTester buttonNollstall = new ButtonTester("buttonNollstall", "KassaSystem");

            buttonBulle.Click();
            buttonKorv.Click();
            buttonNollstall.Click();

            // Checks if list is empty
            Assert.AreEqual(0, dataGridView1.Rows.Count);
        }

        [Test]
        public void TestIfNollstallResetsIndexes()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            ButtonTester buttonNollstall = new ButtonTester("buttonNollstall", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonKaffe.Click();
            buttonBulle.Click();
            buttonNollstall.Click();
            buttonKaffe.Click();
            buttonBulle.Click();

            // Checks if first item in list is correct
            Assert.AreEqual("Kaffe x1", listViewProdukter.Items[0].Text);
            // Checks if second item in list is correct
            Assert.AreEqual("Bulle x1", listViewProdukter.Items[1].Text);
        }

        [Test]
        public void TestIfOtherItemsThanFirstCanBeDeleted()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            ButtonTester buttonTaBort = new ButtonTester("buttonTaBort", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonKaffe.Click();
            // Focuses on second item in list
            listViewProdukter.Items[1].Selected = true;
            buttonTaBort.Click();

            // Checks if first item in list is correct
            Assert.AreEqual("Bulle x1", listViewProdukter.Items[0].Text);
        }

        [Test]
        public void TestIfOtherItemsThanFirstAndLastCanBeDeleted()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonKaffe = new ButtonTester("buttonKaffe", "KassaSystem");
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");
            ButtonTester buttonTaBort = new ButtonTester("buttonTaBort", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonKaffe.Click();
            buttonLask.Click();
            listViewProdukter.Items[1].Selected = true;
            buttonTaBort.Click();

            // Checks if first item in list is correct
            Assert.AreEqual("Bulle x1", listViewProdukter.Items[0].Text);
            // Checks if second item in list is correct
            Assert.AreEqual("Läsk x1", listViewProdukter.Items[1].Text);
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

        [Test]
        public void TestIfTaBort1xButtonRemovesMarkedProduct()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonLask = new ButtonTester("buttonLask", "KassaSystem");
            ButtonTester buttonKorv = new ButtonTester("buttonKorv", "KassaSystem");
            ButtonTester buttonTaBort1x = new ButtonTester("buttonTaBort1x", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonLask.Click();
            buttonKorv.Click();
            // Focuses on first item in list
            listViewProdukter.Items[0].Selected = true;
            buttonTaBort1x.Click();

            // Checks if the right item is removed from the list
            Assert.AreNotEqual("Bulle x1", listViewProdukter.Items[0].Text);
        }
        [Test]
        public void TestIfTaBort1xButtonRemovesOneProduct()
        {
            // Gets element from form
            ButtonTester buttonBulle = new ButtonTester("buttonBulle", "KassaSystem");
            ButtonTester buttonTaBort1x = new ButtonTester("buttonTaBort1x", "KassaSystem");
            ListViewTester listViewProdukter = new ListViewTester("listViewProdukter", "KassaSystem");

            buttonBulle.Click();
            buttonBulle.Click();
            buttonBulle.Click();
            // Focuses on first item in list
            listViewProdukter.Items[0].Selected = true;
            buttonTaBort1x.Click();

            // Checks if the right item is removed from the list
            Assert.AreEqual("Bulle x2", listViewProdukter.Items[0].Text);
        }
    }
}
