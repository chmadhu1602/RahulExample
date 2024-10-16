﻿using OpenQA.Selenium;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.Popups
{

    public class TestPopups : BaseClass
    {
        [Test]
        public void TestAlert()
        {
            NavigationHelper.NavigateToUrl("http://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ClickButton(By.XPath("//div[@id='main']/descendant::a[position()=3]"));
            BrowserHelper.SwitchToWindow(1);
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            // ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            var text = JavaScriptPopHelper.GetPopUpText();
            JavaScriptPopHelper.ClickOkOnPopup();
            //IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            //var text = alert.Text;
            //alert.Accept();
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            TextBoxHelper.ClearTextBox(By.Id("textareaCode"));
            TextBoxHelper.TypeInTextBox(By.Id("textareaCode"), text);

        }


        [Test]
        public void TestConfimPopup()
        {
            NavigationHelper.NavigateToUrl("http://www.w3schools.com/js/tryit.asp?filename=tryjs_confirm");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            var text = JavaScriptPopHelper.GetPopUpText();
            JavaScriptPopHelper.ClickOkOnPopup();
            //IAlert confirm = ObjectRepository.Driver.SwitchTo().Alert();
            //confirm.Accept();
            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            JavaScriptPopHelper.ClickCancelOnPopup();
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            TextBoxHelper.ClearTextBox(By.Id("textareaCode"));
            TextBoxHelper.TypeInTextBox(By.Id("textareaCode"), text);
            //confirm = ObjectRepository.Driver.SwitchTo().Alert();
            //confirm.Dismiss();
        }

        [Test]
        public void TestPrompt()
        {
            NavigationHelper.NavigateToUrl("http://www.w3schools.com/js/tryit.asp?filename=tryjs_prompt");
            BrowserHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            var text = JavaScriptPopHelper.GetPopUpText();
            JavaScriptPopHelper.SendKeys(text);
            JavaScriptPopHelper.ClickOkOnPopup();
            ObjectRepository.Driver.SwitchTo().DefaultContent();
            TextBoxHelper.ClearTextBox(By.Id("textareaCode"));
            TextBoxHelper.TypeInTextBox(By.Id("textareaCode"), text);
            //IAlert prompt = ObjectRepository.Driver.SwitchTo().Alert();
            //prompt.SendKeys("This is automation");
            //prompt.Accept();

            // ButtonHelper.ClickButton(By.XPath("//button[text()='Try it']"));
            //prompt = ObjectRepository.Driver.SwitchTo().Alert();
            //prompt.SendKeys("This is automation");
            //prompt.Dismiss();
        }

    }
}
