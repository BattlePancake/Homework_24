using Homework_24.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Homework_24.WebElements
{
    internal class Element
    {
        private readonly By? _locator;
        private Actions actions = new Actions(Driver.GetDriver());

        public Element(By locator) => _locator = locator;

        public IWebElement FindWebElement
        {
            get
            {
                WaitWebElementPresent();
                return Driver.GetDriver().FindElement(_locator);
            }
        }

        public void WaitWebElementPresent() => Driver.GetWait(Driver.GetDriver()).Until(drv => drv.FindElements(_locator).Count() > 0);

        public void SendValue(string value)
        {
            ScrollToElement();
            FindWebElement.SendKeys(value);
        }

        public void ClearField1()
        {
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.Backspace);
            FindWebElement.SendKeys(Keys.ArrowLeft);
        }
        public void ClearField2()
        {
            FindWebElement.SendKeys(Keys.Delete);
            FindWebElement.SendKeys(Keys.Enter);
        }

        public void ClickElement()
        {
            ScrollToElement();
            FindWebElement.Click();
        }

        public string GetElementAttribute(string atr) => FindWebElement.GetAttribute(atr);

        //public void ScrollToElement() => actions.MoveToElement(FindWebElement);
        public void ScrollToElement() => ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("arguments[0].scrollIntoView(true)", FindWebElement);

        public string GetElementText() => FindWebElement.Text;

        public void HoverOn() => actions.MoveToElement(FindWebElement).Build().Perform(); // метод с занятия
    }
}