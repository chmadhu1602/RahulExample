using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System.Collections.ObjectModel;

namespace SeleniumWebdriver.TestScript.FindElements
{

    public class HandleElements : BaseClass
    {
        [Test]
        public void GetAllElements()
        {

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.XPath("//input"));
            ReadOnlyCollection<IWebElement> elements2 = ObjectRepository.Driver.FindElements(By.Id("123"));
            foreach (var ele in elements)
            {
                Console.WriteLine("ID : {0}", ele.GetAttribute("id"));
            }
        }
    }
}
