using Homework_24.Models;
using Homework_24.Pages.Homework;
using Homework_24.Tests.Lesson;
using NUnit.Allure.Core;

namespace Homework_24.Tests.Homework
{
    internal class FormPageTest : BaseTest
    {
        [AllureNUnit]
        internal class TextBoxPageTest : BaseTest
        {
            [TestCase("Test_Name", "Surname_Test", "Test@mail.com", "1", "1234567890", "12/12/2000", "Maths", "1", "TestFile24.png", "1234 street")]
            [Description("Fill Student form test")]
            public void EnterData(string firstName, string lastName, string email, int gender, string mobile, string date, string subjects, int hobbies, string upload, string address)
            {
                Student student = new(firstName, lastName, email, gender, mobile, date, subjects, hobbies, upload, address);
                FormPage.FillTheForm(student);

                var result = FormPage.CheckForm(student);
                Assert.That(result, Is.True);
            }
        }
    }
}
