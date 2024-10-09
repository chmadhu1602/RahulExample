using OpenQA.Selenium;
using RahulRathoreFinalVersion.BaseClasses;
using SeleniumExtras.PageObjects;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class EnterBug : PageBase
    {
        private IWebDriver _driver;

        public string Title
        {
            get
            {
                return _driver.Title;
            }
        }

        #region WenElement

        [FindsBy(How = How.XPath, Using = "//table[@id ='lang_links_container']/following-sibling::ul/li/descendant::a[text()='New']")]
        private IWebElement New;



        #endregion

        public EnterBug(IWebDriver driver):base(driver)
        {
            this._driver = driver;
            //PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region Navigation

        public BugDetail NavigateToDetail()
        {
            New.Click();
            return new BugDetail(_driver);
        }

        public HomePage LogOut()
        {
            base.LogOut();
            return new HomePage(_driver);
        }


        #endregion
    }
}
