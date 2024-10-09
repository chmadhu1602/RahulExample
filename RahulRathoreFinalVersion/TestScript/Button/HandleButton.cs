using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.Button
{
    public class HandleButton : BaseClass
    {
        [Test]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //IWebElement element =  ObjectRepository.Driver.FindElement(By.Id("log_in"));
            // element.Click();
            Console.WriteLine("Enabled : {0}", ButtonHelper.IsButtonEnabled(By.Id("log_in")));
            Console.WriteLine("Button Text : {0}", ButtonHelper.GetButtonText(By.Id("log_in")));
            ButtonHelper.ClickButton(By.Id("log_in"));

        }
    }
}
