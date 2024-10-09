using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RahulRathoreFinalVersion.DataDriven.Script
{
    public class TestCreateBug : BaseClass
    {
        [Test]
        public void CreateBug0()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            EnterBug enterBug = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            BugDetail bugDetail = enterBug.NavigateToDetail();
            bugDetail.SelectFromCombo("critical", "Macintosh", "Mac OS");
            bugDetail.TypeIn("Short Text", "Long Text");
            bugDetail.ClickSubmit();
            bugDetail.LogOut();
            Thread.Sleep(10000);


        }

        [Test]
        [TestCase("critical", "Macintosh", "Mac OS")]
        public void CreateBug1(string severity, string hardware, string os)
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            EnterBug enterBug = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            BugDetail bugDetail = enterBug.NavigateToDetail();
            bugDetail.SelectFromCombo(severity, hardware, os);
            bugDetail.TypeIn("Short Text", "Long Text");
            bugDetail.ClickSubmit();
            bugDetail.LogOut();
            Thread.Sleep(10000);


        }

        [Test]
        [TestCaseSource(nameof(TestCaseConfig))]
        public void CreateBug2(string severity, string hardware, string os)
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            EnterBug enterBug = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            BugDetail bugDetail = enterBug.NavigateToDetail();
            bugDetail.SelectFromCombo(severity, hardware, os);
            bugDetail.TypeIn("Short Text", "Long Text");
            bugDetail.ClickSubmit();
            bugDetail.LogOut();
            Thread.Sleep(10000);

           
        }

        [Test]
        [TestCaseSource(nameof(TestCaseConfigJson))]
        public void CreateBug3(string severity, string hardware, string os, string SD, string Desc)
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            EnterBug enterBug = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            BugDetail bugDetail = enterBug.NavigateToDetail();
            bugDetail.SelectFromCombo(severity, hardware, os);
            bugDetail.TypeIn(SD, Desc);
            bugDetail.ClickSubmit();
            bugDetail.LogOut();
            Thread.Sleep(10000);


        }

        public static IEnumerable<TestCaseData> TestCaseConfig()
        {
          yield return new TestCaseData("trivial", "Macintosh", "Mac OS");
          yield return  new TestCaseData("trivial", "Macintosh", "Mac OS");
        }

        public static IEnumerable<TestCaseData> TestCaseConfigJson()
        {
            yield return new TestCaseData(JsonExtract().GetSeverity("Severity"),
                JsonExtract().GetHardware("Hardware"),JsonExtract().GetOS("OS"),
                JsonExtract().GetShortDesc("ShortDesc"),JsonExtract().GetDesc("Description"));
            yield return new TestCaseData(JsonExtract().GetSeverity("Severity"),
                JsonExtract().GetHardware("Hardware"), JsonExtract().GetOS("OS"),
                JsonExtract().GetShortDesc("ShortDesc"), JsonExtract().GetDesc("Description"));
        }
    }
}
