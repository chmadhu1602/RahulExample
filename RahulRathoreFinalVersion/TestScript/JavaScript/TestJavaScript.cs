using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace RahulRathoreFinalVersion.TestScript.JavaScript
{
    public class TestJavaScript : BaseClass
    {
        [Test]
        public void TestJavaScriptMethod()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));

            IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
            executor.ExecuteScript("document.getElementById('Bugzilla_login').value='chmadhu1602@bugzilla.com')");
            executor.ExecuteScript("document.getElementById('Bugzilla_password').value='PASSWORD'");
            executor.ExecuteScript("document.getElementById('log_in').click()");
        }
    }
}
