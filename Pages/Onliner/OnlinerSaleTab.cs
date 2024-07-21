namespace Homework_24.Pages.Onliner
{
    internal class OnlinerSaleTab : OnlinerBaseTab
    {
        public OnlinerSaleTab()
        {
            TabLocator = "//*[text()='Продажа']/ancestor::div[contains(@class,'b-main-navigation__dropdown-c')]";
        }


    }
}
