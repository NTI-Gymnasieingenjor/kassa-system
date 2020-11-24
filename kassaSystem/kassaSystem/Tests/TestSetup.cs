using NUnit.Framework;

namespace kassaSystem
{
    [TestFixture]
    public class TestSetup
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
    }
}
