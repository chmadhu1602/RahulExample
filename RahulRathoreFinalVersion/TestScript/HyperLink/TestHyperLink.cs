using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.HyperLink
{
    public class TestHyperLink : BaseClass
    {
        [Test]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element =  ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            //  element.Click();

            //  IWebElement pelement = ObjectRepository.Driver.FindElement(By.PartialLinkText("File"));
            //  pelement.Click();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            BrowserHelper.GoBack();
            LinkHelper.ClickLink(By.PartialLinkText("File"));
        }
    }
}
