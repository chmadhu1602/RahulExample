using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PhantomJS
{

    public class TestPhantomJS
    {
        [Test, Ignore("PhantomJs is not used in latest versions")]
        public void TestPhantomJDriver()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            GenericHelper.TakeScreenShot();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            GenericHelper.TakeScreenShot();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            GenericHelper.TakeScreenShot();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            GenericHelper.TakeScreenShot();
            ButtonHelper.ClickButton(By.Id("log_in"));
            GenericHelper.TakeScreenShot();
            LinkHelper.ClickLink(By.LinkText("Testng"));
            GenericHelper.TakeScreenShot();
        }
    }
}
