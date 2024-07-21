using Homework_24.Constants;
using Homework_24.Pages.Onliner;
using Homework_24.Tests.Lesson;

namespace Homework_24.Tests.Onliner
{
    internal class OnlinerTest : BaseTest
    {
        [Test]
        [Description("Onliner test 1")]
        public void OnlinerTest1()
        {
            OnlinerMainPage.HoverOnElement();
            Thread.Sleep(100);
            OnlinerMainPage.RentTab.OpenCity(City.Minsk);
        }

        [Test]
        [Description("Onliner test 2")]
        public void OnlinerTest2()
        {
            OnlinerMainPage.HoverOnElement();
            Thread.Sleep(100);
            OnlinerMainPage.SaleTab.OpenCity(City.Grodno);
        }
    }
}
