using OpenQA.Selenium.Appium.Windows;

namespace RemoteDesktopTesting.Screens
{

    /********************** Actions ***********************/
    public class AddPane
    {
        public readonly AddPaneMap Map;
        public AddPane(WindowsDriver<WindowsElement> session)
        {
            Map = new AddPaneMap(session);
        }


        public void ClickAddDesktopOption()
        {
            Map.DesktopOption.Click();
        }
    }

    /********************** Elements Map ***********************/
    public class AddPaneMap
    {
        WindowsDriver<WindowsElement> _session;
        public AddPaneMap(WindowsDriver<WindowsElement> session)
        {
            _session = session;
        }

        public WindowsElement DesktopButton => _session.FindElementByAccessibilityId("AddDesktopButton");
        public WindowsElement DesktopOption => _session.FindElementByName("Desktop");
        public WindowsElement ConnectToAPCText => _session.FindElementByName("Connect to a PC");
        public WindowsElement AddADesktopText => _session.FindElementByName("Add a desktop");
        public WindowsElement InputPCName => _session.FindElementByAccessibilityId("HostNameTextBox");
        public WindowsElement UserAccountCombobox => _session.FindElementByAccessibilityId("AddOrEditCombobox");
        public WindowsElement InputDisplayName => _session.FindElementByAccessibilityId("friendlyNameEntry");
        public WindowsElement ScrollViewer => _session.FindElementByClassName("ScrollViewer");

    }
}
