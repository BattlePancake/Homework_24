using Homework_24.Factory;
using Homework_24.WebElements;
using OpenQA.Selenium;

namespace Homework_24.Pages.Lesson
{
    internal class BasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();

        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://www.onliner.by/");
        }

        public static void Refresh() => Driver.GetDriver().Navigate().Refresh();
    }
}
