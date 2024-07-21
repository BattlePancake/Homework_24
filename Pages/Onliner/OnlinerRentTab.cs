namespace Homework_24.Pages.Onliner
{
    internal class OnlinerRentTab : OnlinerBaseTab
    {
        public OnlinerRentTab()
        {
            TabLocator = "//*[text()='Аренда']/ancestor::div[contains(@class,'b-main-navigation__dropdown-c')]";
        }


    }
}
