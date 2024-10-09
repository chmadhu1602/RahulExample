using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RahulRathoreFinalVersion.TestScript.AutoSuggest
{
    public class TestAutoSuggest : BaseClass
    {
        [Test]
        public void DynamicAutoSgstList()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/autocomplete/index");
            ObjectRepository.Driver.FindElement(By.Id("kd-place-chooser")).SendKeys("m");
            IList<IWebElement> areas= ObjectRepository.Driver.FindElements(By.XPath("//ul[@id ='kd-place-chooser_listbox']/li"));
            foreach(var value in areas)
            {
                Console.WriteLine(value.Text);
                if(value.Text.Contains("Madr"))
                {
                    value.Click();
                    
                }
                
            }
            Thread.Sleep(10000);
        }
    }
}
