using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumWebdriver.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RahulRathoreFinalVersion.BaseClasses
{
    public class PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How=How.Id,Using = "//table[@id ='lang_links_container']/following-sibling::ul/li/descendant::a[text()='Home']")]
        private IWebElement Home;

        [FindsBy(How = How.XPath, Using = "((//table[@id ='lang_links_container']/following-sibling::ul/li/descendant::a)[position()=10]")]
        private IWebElement _LogOut;

        public PageBase(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        public void LogOut()
        {
            ButtonHelper.ClickButton(By.XPath("(//table[@id ='lang_links_container']/following-sibling::ul/li/descendant::a)[position()=10]"));
        }
    }
}
