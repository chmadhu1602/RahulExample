using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.TextBox
{

    public class TestTextBox : BaseClass
    {
        [Test]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.SendKeys(ObjectRepository.Config.GetUsername());
            //ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_password"));
            //ele.SendKeys(ObjectRepository.Config.GetPassword());
            //ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.Clear();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
        }
    }
}
