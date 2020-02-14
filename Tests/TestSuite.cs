
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoteDesktopTesting.Config;
using RemoteDesktopTesting.Screens;
using System.Threading;

namespace RemoteDesktopTesting.Tests
{

    [TestClass]
    public class TestSuite : SessionController
    {

        [TestMethod]
        public void Remote_Desktop_can_be_opened()
        {
            //Expected result
            Assert_application_Is_Displayed();
        }

        [TestMethod]
        public void Desktop_option_can_be_clicked()
        {
            //Expected result
            Assert_application_Is_Displayed();
            //Step
            MainScreen.GoToAddPane();
            //Expected result
            Assert.IsTrue(AddPane.Map.ScrollViewer.Displayed);
            Assert.IsTrue(AddPane.Map.DesktopButton.Displayed);
            Assert.AreEqual("Desktop", AddPane.Map.DesktopOption.Text);
            Assert.AreEqual("Connect to a PC", AddPane.Map.ConnectToAPCText.Text);
            //Step
            AddPane.ClickAddDesktopOption();
            //Expected result
            Assert.IsTrue(AddPane.Map.AddADesktopText.Displayed);
            Assert.IsTrue(AddPane.Map.InputPCName.Displayed);
            Assert.IsTrue(AddPane.Map.UserAccountCombobox.Displayed);
            Assert.IsTrue(AddPane.Map.InputDisplayName.Displayed);
        }

        [TestMethod]
        public void Account_can_be_added_through_the_settings_section()
        {
            //Expected result
            Assert_application_Is_Displayed();
            //Step
            MainScreen.GoToSettingsPane();
            //Expected result
            Assert.IsTrue(SettingsPane.Map.SettingsNavBarTitle.Displayed);
            //Step
            SettingsPane.ClickAddAccount();
            //Expected result
            Assert.IsTrue(SettingsPane.Map.AddAccountTitle.Displayed);
            //Steps
            var account = SettingsPane.FillInformation();
            //Expected results
            Assert.IsNotNull(SettingsPane.Map.UsernameInput.Text);
            Assert.IsNotNull(SettingsPane.Map.PasswordInput.Text);
            Assert.IsNotNull(SettingsPane.Map.DisplayInput.Text);
            //Step
            SettingsPane.ClickSaveAccount();
            //Expected result
            Assert.IsTrue(SettingsPane.Map.TextBlock(account.Display).Displayed);

        }

        [TestInitialize]
        public void TestInitialize()
        {
            //Open up the app
            Setup();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //Close down the app
            TearDown();
        }

        public void Assert_application_Is_Displayed()
        {
            Assert.IsTrue(MainScreen.Map.TitleBar.Displayed);
            Assert.AreEqual("Connect to apps and desktops", MainScreen.Map.Name.Text);
            Assert.AreEqual("To get started, add a remote PC you want to connect to using this device. You can also add remote resources to work with apps and desktops someone has set up for you.", MainScreen.Map.Text.Text);
        }

    }
}
