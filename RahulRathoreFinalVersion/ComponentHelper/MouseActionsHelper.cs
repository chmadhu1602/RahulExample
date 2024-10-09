using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RahulRathoreFinalVersion.ComponentHelper
{
    public class MouseActionsHelper
    {

        private static IWebElement element1;
        private static IWebElement element2;

        public static void ContextRightClick(By locator)
        {
            element1 = GenericHelper.GetElement(locator);
            Actions a = new Actions(ObjectRepository.Driver);
            a.ContextClick(element1).Build().Perform();
        }

        public static void DragandDrop(By locator1, By locator2)
        {
            element1 = GenericHelper.GetElement(locator1);
            element2 = GenericHelper.GetElement(locator2);
            Actions a = new Actions(ObjectRepository.Driver);
           // IJavaScriptExecutor js = (IJavaScriptExecutor)ObjectRepository.Driver;
           // js.ExecuteScript("window.scrollTo(0,element1.Location.Y)");
            MovetoSpcificElement(locator1);
            
            a.DragAndDrop(element1,element2).Build().Perform();
        }

        public static void MovetoSpcificElement(By locator)
        {
            element1 = GenericHelper.GetElement(locator);
            
            Actions a = new Actions(ObjectRepository.Driver);
            a.MoveToElement(element1).Build().Perform();
        }

        public static void ScrolltoSpcificElement(By locator)
        {
            element1 = GenericHelper.GetElement(locator);

            Actions a = new Actions(ObjectRepository.Driver);
            a.ScrollToElement(element1).Build().Perform();
        }

        public static void ClickandHoldandRelease(By locator1, By locator2)
        {
            element1 = GenericHelper.GetElement(locator1);

            Actions a = new Actions(ObjectRepository.Driver);
            a.ClickAndHold(element1).Build().Perform();
            ReleaseRightButton(locator2);
        }

        public static void ReleaseRightButton(By locator)
        {
            element1 = GenericHelper.GetElement(locator);

            Actions a = new Actions(ObjectRepository.Driver);
            a.Release(element1).Build().Perform();
        }
    }
}
