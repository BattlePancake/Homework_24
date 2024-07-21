using Homework_24.Factory;
using Homework_24.WebElements;
using OpenQA.Selenium;

namespace Homework_24.Pages.Lesson
{
    internal class FormBasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();

        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
        }

        //protected string? TableLocator { get; init; } // init без static
        //private Element _tableElement(string tableValue) => new(By.XPath($"{TableLocator}//*[text()='{tableValue}']"));
        //public string GetTextFromTable(string tableValue) => _tableElement(tableValue).GetElementText();
        //public FormTab()
        //{
        //    TableLocator = "//*[text()='Аренда']/ancestor::div[contains(@class,'b-main-navigation__dropdown-c')]";
        //}
    }
}
