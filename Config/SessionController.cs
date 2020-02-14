using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using RemoteDesktopTesting.Screens;
using System;

namespace RemoteDesktopTesting.Config
{

    [TestClass]
    public class SessionController
    {
        //Harcode values, this should go in a config file.
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string appId = "Microsoft.RemoteDesktop_8wekyb3d8bbwe!App";

        protected MainPane MainScreen;
        protected AddPane AddPane;
        protected SettingsPane SettingsPane;

        protected WindowsDriver<WindowsElement> session;

        public void Setup()
        {
            if (session == null)
            {
                AppiumOptions opt = new AppiumOptions();
                opt.AddAdditionalCapability("app", appId);
                opt.AddAdditionalCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), opt);
                Assert.IsNotNull(session);
                session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2.5);
                InitializePages();
            }
        }

        public void TearDown()
        {
            if (session != null)
            {
                session.Quit();
                session = null;
            }
        }

        public void InitializePages()
        {
            MainScreen = new MainPane(session);
            AddPane = new AddPane(session);
            SettingsPane = new SettingsPane(session);
        }

    }
}
