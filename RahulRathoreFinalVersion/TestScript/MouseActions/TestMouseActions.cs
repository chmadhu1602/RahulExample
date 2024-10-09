using OpenQA.Selenium;
using RahulRathoreFinalVersion.ComponentHelper;
using SeleniumWebdriver.BaseClasses;
using SeleniumWebdriver.ComponentHelper;

namespace RahulRathoreFinalVersion.TestScript.MouseActions
{
    public class TestMouseActions : BaseClass
    {
        [Test]
        public void TestContextClick()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");
            MouseActionsHelper.ContextRightClick(By.Id("draggable"));
        }

        [Test]
        public void TestDragNDrop()
        {

            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");

            MouseActionsHelper.DragandDrop(By.Id("draggable"),By.Id("droptarget"));
            Thread.Sleep(5000);
        }

        [Test]
        public void TestClickNHold()
        {

            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/sortable/handlers");
            MouseActionsHelper.ClickandHoldandRelease(By.XPath("(//div[@id='sortable-handlers']/descendant::span[@class='handler'])[1]"), By.XPath("(//div[@id='sortable-handlers']/descendant::span[@class='handler'])[3]"));
            Thread.Sleep(5000);
        }
    }
}
