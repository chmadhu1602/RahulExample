using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageObject
{

    public class TestPageObject : BaseClass
    {
        [Test]
        public void TestPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            EnterBug enterBug = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            BugDetail bugDetail = enterBug.NavigateToDetail();
            bugDetail.SelectFromSeverity("trivial");
            ButtonHelper.ClickButton(By.XPath("//div[@id='header']/ul[1]/li[11]/a"));
        }



    }
}
