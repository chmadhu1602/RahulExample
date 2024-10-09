﻿using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.RadioButton
{

    public class HandleRadioButton : BaseClass
    {
        [Test]
        public void TestRadio()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IWebElement webelemt = ObjectRepository.Driver.FindElement(By.XPath("//a[@id='enter_bug']/span"));
            Console.WriteLine("Text : {0}", webelemt.Text);

            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            LinkHelper.ClickLink(By.XPath("//div[@id='header']/ul[1]/li[9]/a"));
            LinkHelper.ClickLink(By.XPath("//dt[@id='parameters']/a"));
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("ssl_redirect-on"));
            //element.Click();
            Console.WriteLine("Selected : {0}", RadioButtonHelper.IsRadioButtonSelected(By.Id("ssl_redirect-off")));
            RadioButtonHelper.ClickRadioButton(By.Id("ssl_redirect-on"));
        }
    }
}
