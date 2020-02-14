using OpenQA.Selenium.Appium.Windows;
using RemoteDesktopTesting.Faker;
using RemoteDesktopTesting.POJOS;

namespace RemoteDesktopTesting.Screens
{

    /********************** Actions ***********************/
    public class SettingsPane
    {
        public readonly SettingsPaneMap Map;

        public SettingsPane(WindowsDriver<WindowsElement> session)
        {
            Map = new SettingsPaneMap(session);
        }

        private AccountInfo GetAccountInformation()
        {
            return new AccountInfo
            {
                Username = Data.GetRandomData() + "@example.com",
                Password = "test",
                Display = Data.GetRandomData()
            };
        }

        public void ClickAddAccount()
        {
            Map.AddAccount.Click();
        }

        public void ClickSaveAccount()
        {
            Map.SaveButton.Click();
        }

        public void ClickCombobox() 
        {
            Map.AccountsCombobox.Click();
        }
        
        //For this method the best solution is to create fake random data... I implemented the simplest solution I could.
        public AccountInfo FillInformation()
        {
            var info = GetAccountInformation();
            Map.UsernameInput.SendKeys(info.Username);
            Map.PasswordInput.SendKeys(info.Password);
            Map.DisplayInput.SendKeys(info.Display);

            return info;
        }


    }

    /********************** Elements Map ***********************/
    public class SettingsPaneMap
    {
        WindowsDriver<WindowsElement> _session;
        public SettingsPaneMap(WindowsDriver<WindowsElement> session)
        {
            _session = session;
        }

        public WindowsElement SettingsNavBarTitle => _session.FindElementByAccessibilityId("Settings_NavBar_Title");
        public WindowsElement AddAccount => _session.FindElementByAccessibilityId("AddComboboxEntryButton");
        public WindowsElement AddAccountTitle => _session.FindElementByName("Add an account");
        public WindowsElement UsernameInput => _session.FindElementByAccessibilityId("UserNameTextBox");
        public WindowsElement PasswordInput => _session.FindElementByAccessibilityId("PasswordBox");
        public WindowsElement DisplayInput => _session.FindElementByAccessibilityId("txtFriendlyNameEntry");
        public WindowsElement SaveButton => _session.FindElementByAccessibilityId("SaveUserButton");
        public WindowsElement AccountsCombobox => _session.FindElementByAccessibilityId("AddOrEditCombobox");
        public WindowsElement TextBlock(string name) => _session.FindElementByName($"{name}");

    }
}
