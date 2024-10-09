using OpenQA.Selenium;
using RahulRathoreFinalVersion.Configuration;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.Settings;

namespace RahulRathoreFinalVersion
{

    public class UnitTest : BaseClass
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            // ChromeOptions cO = new ChromeOptions();
            //cO.AddArgument()
            driver = ObjectRepository.Driver;
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            // Console.WriteLine(ConfigurationManager.AppSettings.Get("URL"));


        }

        [Test]
        public void JsonTest1()
        {
            IConfig aj = new AppJsonReader();
            driver.Navigate().GoToUrl(aj.GetWebsite());

            //ObjectRepository.Driver.Navigate().GoToUrl(aj.GetUrl());

        }

        [Test]
        public void OpenPageAndClick()
        {

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
        }

        [Test]
        public void TextBoxEnterLogin()
        {

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //  TextBoxHelper.ClearText(By.Id("Bugzilla_password"));
            CheckBoxHelper.CheckedCheckBox(By.Id("Bugzilla_restrictlogin"));
            LinkHelper.ClickLink(By.Name("GoAheadAndLogIn"));
        }

        [Test]
        [Ignore("Config Not working with this .net version")]
        public void ConfigTest1()
        {
            IConfig ac = new AppJsonReader();
            // driver.Navigate().GoToUrl(ac.GetUrl());
            //Screenshot sc = driver.TakeScreenshot();


        }

        [TearDown]
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }

        }

    }
}