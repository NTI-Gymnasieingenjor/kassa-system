# Documentation

## Tests
### Prerequisites
**In Visual Studio 2019**
1. On the right handside rightclick on **kassaSystem** and go into **Manage NuGet Packages...**
2. Select **Browse** tab and search for **NUnit** and download it.
3. In the Menu bar select **Extensions** tab and go into **Manage Extensions**.
4. In the left handside panel go into **Online**, search for **NUnit 3 Test Adapter** and download.
5. Restart Visual Studio to install the extension.

You also need to add refrences to your project <br>
**In Visual Studio 2019**
1. On the right handside under **kassaSystem** rightclick on **Refrences** and **Add Refrences...**
2. In the left handside panel go into **Assemblies** and search for **NUnit**
3. In the list select **nunit.framework** and **NUnitForms**
4. Click **OK**


### Create A New Test File
To make a new test file:

On the right handside, rightclick on **kassaSystem**, hover over **Add** and at the bottom of the list click on **Class...**

At the top of your new file you will need to add these two lines:
```
using NUnit.Extensions.Forms;
using NUnit.Framework;
```
Test Template
  
```
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
        public void Test1() 
        {
          //Your Code Here
        }
    }
}
```

### Running A Test
To run your tests move over to the menu bar and click on **Test** tab <br>
Then click on **Run All Tests**
