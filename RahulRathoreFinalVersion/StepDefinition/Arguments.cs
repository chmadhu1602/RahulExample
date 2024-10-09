﻿using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using TechTalk.SpecFlow;

namespace SeleniumWebdriver.StepDefinition
{
    [Binding]
    public sealed class Arguments : BaseClass
    {
        private HomePage hPage;
        private LoginPage lPage;
        private EnterBug ePage;
        private BugDetail bPage;

        #region Given

        [Given(@"User is at Home Page with url in the browser ""(.*)""")]
        [Given(@"User is at Home Page with url ""(.*)""")]
        public void GivenUserIsAtHomePageWithUrl(string url)
        {
            InitWebdriver();
            NavigationHelper.NavigateToUrl(url);
        }
        #endregion

        #region When
        [When(@"I click on ""(.*)"" Link")]
        public void WhenIClickOnLink(string linkText)
        {
            hPage = new HomePage(ObjectRepository.Driver);
            lPage = hPage.NavigateToLogin();
        }

        [When(@"I provide the ""(.*)"", ""(.*)"" and click on Login button")]
        public void WhenIProvideTheAndClickOnLoginButton(string user, string pass)
        {
            ObjectRepository.ePage = ObjectRepository.lPage.Login(user, pass);
        }


        [When(@"I click on Logout button at bug detail page")]
        [When(@"I click on Logout button at enter bug page")]
        public void WhenIClickOnLogoutButtonAtEnterBugPage()
        {
            ePage.LogOut();
        }
        [When(@"I click on Testng link in the page")]
        public void WhenIClickOnTestngLinkInThePage()
        {
            bPage = ePage.NavigateToDetail();
        }

        [When(@"I provide the severity , harware , platform , summary and desc")]
        public void WhenIProvideTheSeverityHarwarePlatformSummaryAndDesc(Table table)
        {
            foreach (var row in table.Rows)
            {
                bPage.SelectFromCombo(row["Severity"], row["Harware"], row["Platform"]);
                bPage.TypeIn(row["Summary"], row["Desc"]);
            }


        }

        [When(@"I provide the ""(.*)"" , ""(.*)"" , ""(.*)"" , ""(.*)"" and ""(.*)""")]
        public void WhenIProvideTheAnd(string severity, string harware, string platform, string summary, string desc)
        {
            bPage.SelectFromCombo(severity, harware, platform);
            bPage.TypeIn(summary, desc);
        }



        #endregion

        #region Then

        [Then(@"User should be at Login Page with title ""(.*)""")]
        public void ThenUserShouldBeAtLoginPageWithTitle(string title)
        {
            Assert.AreEqual(title, lPage.Title);
        }

        [Then(@"User Should be at Enter Bug page with title ""(.*)""")]
        public void ThenUserShouldBeAtEnterBugPageWithTitle(string title)
        {
            Assert.AreEqual(title, ePage.Title);
        }

        [Then(@"User Should be at Bug Detail page with title ""(.*)""")]
        public void ThenUserShouldBeAtBugDetailPageWithTitle(string title)
        {
            Assert.AreEqual(title, bPage.Title);
        }


        #endregion

        #region And

        [When(@"click on Submit button in page")]
        public void WhenClickOnSubmitButtonInPage()
        {
            bPage.ClickSubmit();
        }


        #endregion

    }
}
