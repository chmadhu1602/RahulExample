using OpenQA.Selenium;
using RahulRathoreFinalVersion.BaseClasses;
using SeleniumExtras.PageObjects;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class BugDetail : PageBase
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
        [FindsBy(How = How.Id, Using = "bug_severity")]
        private IWebElement SeverityDropDown;

        [FindsBy(How = How.Id, Using = "rep_platform")]
        private IWebElement HardwareDDown;

        [FindsBy(How = How.Id, Using = "op_sys")]
        private IWebElement OsDDown;

        [FindsBy(How = How.Id, Using = "short_desc")]
        private IWebElement ShortDesc;

        [FindsBy(How = How.Id, Using = "comment")]
        private IWebElement Description;

        [FindsBy(How = How.Id, Using = "commit")]
        private IWebElement Submit;

        #endregion

        public BugDetail(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
            //PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region Action

        public void SelectFromSeverity(string value)
        {
            ComboBoxHelper.SelectElement(SeverityDropDown, value);
        }

        public void SelectFromCombo(string severity= null,string hardware = null, string os = null)
        {
            if(!(severity == null))
            {
                ComboBoxHelper.SelectElement(SeverityDropDown, severity);
            }

            if (!(hardware == null))
            {
                ComboBoxHelper.SelectElement(HardwareDDown, hardware);
            }

            if (!(os == null))
            {
                ComboBoxHelper.SelectElement(OsDDown, os);
            }

        }

        public void TypeIn(string shortText = null, string LongDesc = null)
        {
            if (!(shortText == null))
            {
                TextBoxHelper.ClearTextBox(ShortDesc);
                TextBoxHelper.TypeInTextBox(ShortDesc, shortText);
            }

            if (!(LongDesc == null))
            {
                TextBoxHelper.TypeInTextBox(Description, LongDesc);
            }

        }

        public void ClickSubmit()
        {
            Submit.Click();
        }

        public HomePage LogOut()
        {
            base.LogOut();
            return new HomePage(_driver);
        }

        #endregion
    }
}
