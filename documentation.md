# Documentation

## Putting out a new release

### Creating the .EXE file
**In Visual Studio 2019**
1. On the right hand side inside the solution explorer, in solution tab for **kassaSystem**, right-click on the **kassaSystem** project and click **Build**.
2. If the build succeeded the created exe file should now be located within the **kassaSystem\kassaSystem\bin\Debug** directory.

### Creating the installer
You will need to install [Inno Setup Compiler](https://jrsoftware.org/isinfo.php) to make an installer and run the scripts.

#### Creating a new installer script
**In Inno Setup Compiler**
1. Under **New File** select **Create a new script file using the Script Wizard** and then click **OK.**
2. You will be prompted a Setup Wizard hit **Next** to proceed.
3. Here you will be able to enter general information about the application. <br>
**Application Name**: Kassasystem <br>
**Application Version**: The current version of the application <br>
**Application Publisher**: Your company name (e.g poG & Company) <br>
**Application Website**: The website for the application (You can leave this empty)
<br> Click **Next** when you are done.
4. In the next prompt you can change the default install destination. You can leave this on default settings. <br> Click **Next** when you are done.
5. Next you will need to browse for the application executable (Kassasystem.exe). You can find the executable in the **kassaSystem\kassaSystem\bin\Debug** directory. <br> If needed, you can add additional files and folders in the box below. <br> Click **Next** when you are done.
6. In the next prompt you can choose a file extension type for the application. Turn this option off by default. <br> Click **Next** when you are done.
7. Next prompt is about shortcuts for the installed application. Leave this as it is by default. <br> Click **Next** when you are done.
8. In the next prompt you can browse for a License and information txt files. <br> You can leave everything empty if you don't have any. <br> Click **Next** when you are done.
9. Afterwards you can choose if it will be an Administrative installation or not. Leave this as it is by default. <br> Click **Next** when you are done.
10. In the next prompt you can choose which languages will be included in the installation file. English is chosen by default. <br> Click **Next** when you are done.
11. Next choose where you wish to save the compiler file. Name it **"kassasystemsetup"** and select the default Kassasystem icon, which can be found in **kassaSystem\assets**. Leave password empty. <br> Click **Next** when you are done.
12. Next you can choose whether you wish to have *Inno Setup Compilers* #define directives. This is good for the future when you wish to edit the script so leaving it on is recommended. <br> Click **Next** when you are done.
13. Finally you are at the last step! <br> Click **Finish**.

#### Using an existing installer script
**In Inno Setup Compiler**
1. In the top left, click on the **File** tab and then click on **Open**.
2. Browse for the script file and open.

#### Running the Compiler
To run the compiler open up your script file in **Inno Setup Compiler** <br> press **CTRL + F9** to start compiling <br> then press **F9** to run your new installation file.

## Tests
### Prerequisites
**In Visual Studio 2019**
1. On the right hand side right-click on **kassaSystem** and go into **Manage NuGet Packages...**.
2. Select **Browse** tab and search for **NUnit** and download it.
3. In the Menu bar select **Extensions** tab and go into **Manage Extensions**.
4. In the left hand side panel go into **Online**, search for **NUnit 3 Test Adapter** and download.
5. Restart Visual Studio to install the extension.

You also need to add refrences to your project <br>
**In Visual Studio 2019**
1. On the right hand side under **kassaSystem** right-click on **Refrences** and **Add Refrences...**.
2. In the left hand side panel go into **Assemblies** and search for **NUnit**.
3. In the list select **nunit.framework** and **NUnitForms**.
4. Click **OK**.


### Create A New Test File
To make a new test file:

On the right hand side, right-click on **kassaSystem**, hover over **Add** and at the bottom of the list click on **Class...**

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
