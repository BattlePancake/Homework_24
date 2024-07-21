using Homework_24.Factory;
using Homework_24.Pages.Lesson;
using Homework_24.WebElements;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Homework_24.Pages.Onliner
{
    internal class OnlinerBaseTab : BasePage
    {
        protected string? TabLocator { get; init; } // init без static

        private Element _cityButton(string cityName) => new(By.XPath($"{TabLocator}//*[text()='{cityName}']"));

        public void OpenCity(string cityName) => _cityButton(cityName).ClickElement();

    }
}
