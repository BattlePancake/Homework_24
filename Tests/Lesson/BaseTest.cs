using Homework_24.Factory;
using Homework_24.Pages.Lesson;

namespace Homework_24.Tests.Lesson
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            BasePage.OpenPage();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
