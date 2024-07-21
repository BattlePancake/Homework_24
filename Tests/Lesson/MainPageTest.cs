using Homework_24.Models;
using Homework_24.Pages.Lesson;

namespace Homework_24.Tests.Lesson
{
    internal class MainPageTest : BaseTest
    {
        [TestCase("standard_user", "secret_sauce", "Products")]

        [TestCase("problem_user", "secret_sauce", "Products")]

        [TestCase("visual_user", "secret_sauce", "Products")]

        public void Login(string name, string password, string titleText)
        {
            User user = new User(name, password);
            LoginPage.Login(user);
            var resultText = LoginPage.GetTitleText();
            Assert.That(resultText, Is.EqualTo(titleText));
        }
    }
}
