using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;

namespace SeleniumWebdriver.TestScript.BrowserActions
{

    public class TestBrowserActions : BaseClass
    {
        [Test]
        public void TestActions()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/bdd-with-selenium-webdriver-and-speckflow-using-c/");
            ButtonHelper.ClickButton(By.XPath("//div[@id='related']/descendant::a[position()=1]"));
            BrowserHelper.GoBack();
            BrowserHelper.Forward();
            BrowserHelper.RefreshPage();


        }
    }
}
