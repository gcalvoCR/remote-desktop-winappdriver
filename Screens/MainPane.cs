using OpenQA.Selenium.Appium.Windows;

namespace RemoteDesktopTesting.Screens
{

    /********************** Actions ***********************/
    public class MainPane
    {
        public readonly MainPaneMap Map;
        public MainPane(WindowsDriver<WindowsElement> session)
        {
            Map = new MainPaneMap(session);
        }

        public void GoToAddPane()
        {
            Map.BtnAdd.Click();
        }

        public void GoToSettingsPane()
        {
            Map.SettingsOption.Click();
        }

        public void CloseApp()
        {
            Map.Close.Click();
        }

    }

    /********************** Elements Map ***********************/
    public class MainPaneMap
    {
        WindowsDriver<WindowsElement> _session;
        public MainPaneMap(WindowsDriver<WindowsElement> session)
        {
            _session = session;
        }

        public WindowsElement TitleBar => _session.FindElementByAccessibilityId("TitleBar");
        public WindowsElement Name => _session.FindElementByName("Connect to apps and desktops");
        public WindowsElement Text => _session.FindElementByName("To get started, add a remote PC you want to connect to using this device. You can also add remote resources to work with apps and desktops someone has set up for you.");
        public WindowsElement BtnAdd => _session.FindElementByName("Add");
        public WindowsElement SettingsOption => _session.FindElementByAccessibilityId("SettingsButton");
        public WindowsElement Close => _session.FindElementByAccessibilityId("Close");

    }
}
