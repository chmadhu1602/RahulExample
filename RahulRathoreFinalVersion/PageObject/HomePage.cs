using OpenQA.Selenium;
using RahulRathoreFinalVersion.BaseClasses;
using SeleniumExtras.PageObjects;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class HomePage : PageBase
    {
        private IWebDriver _driver;

       // private string _title;
        public string Title 
        { get
            {
                return _driver.Title;
            }     
         } 
        

        #region WebElement

        [FindsBy(How = How.Id, Using = "quicksearch_main")]
        private IWebElement QuickSearchTextBox;

        [FindsBy(How = How.Id, Using = "find")]
        private IWebElement QuickSearchBtn;

        [FindsBy(How = How.LinkText, Using = "File a Bug")]
        private IWebElement FileABugLink;


        #endregion

        public HomePage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
            //PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region Actions

        public void QuickSearch(string text)
        {
            QuickSearchTextBox.SendKeys(text);
            QuickSearchBtn.Click();
        }

        #endregion

        #region Navigation

        public LoginPage NavigateToLogin()
        {
            FileABugLink.Click();
            return new LoginPage(_driver);
        }

        #endregion
    }
}
