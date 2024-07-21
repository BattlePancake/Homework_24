using Homework_24.WebElements;
using OpenQA.Selenium;

namespace Homework_24.Pages.Onliner
{
    internal class OnlinerMainPage
    {
        public static OnlinerRentTab RentTab = new OnlinerRentTab();
        public static OnlinerSaleTab SaleTab = new OnlinerSaleTab();


        private static Element _propertyTab => new(By.XPath("//*[@class='b-main-navigation__text' and text()='Дома и квартиры']"));

        public static void HoverOnElement() => _propertyTab.HoverOn();
    }
}
