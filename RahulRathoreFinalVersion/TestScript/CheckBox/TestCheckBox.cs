using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.CheckBox
{
    public class TestCheckBox : BaseClass
    {
        [Test]
        public void TestBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            // TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
            IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            Console.WriteLine(ele.Text);
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));
            CheckBoxHelper.CheckedCheckBox(By.Id("Bugzilla_restrictlogin"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin")));
        }
    }
}
