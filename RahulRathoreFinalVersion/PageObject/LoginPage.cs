using OpenQA.Selenium;
using RahulRathoreFinalVersion.BaseClasses;
using SeleniumExtras.PageObjects;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class LoginPage : PageBase
    {

        private IWebDriver _driver;

        public string Title
        {
            get
            {
                return _driver.Title;
            }
        }

        #region WebElement
        [FindsBy(How = How.Id, Using = "Bugzilla_login")]
        private IWebElement LoginTextBox;

        [FindsBy(How = How.Id, Using = "Bugzilla_password")]
        private IWebElement PassTextBox;

        [FindsBy(How = How.Id, Using = "log_in")]

        private IWebElement LoginButton;

        [FindsBy(How = How.LinkText, Using = "Home")]

        private IWebElement HomeLink;


        #endregion

        public LoginPage(IWebDriver driver):base(driver)
        {
            this._driver= driver;
            //PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region Actions

        public EnterBug Login(string usename, string password)
        {
            LoginTextBox.SendKeys(usename);
            PassTextBox.SendKeys(password);
            LoginButton.Click();

            return new EnterBug(_driver);
        }

        #endregion

        #region Navigation

        public void NavigateToHome()
        {
            HomeLink.Click();
        }

        #endregion
    }
}
