using Homework_24.Pages.Lesson;

namespace Homework_24.Tests.Lesson
{
    internal class UploadPageTest : BaseTest
    {

        [Test]
        [Description("Upload file test")]
        public void UploadPageTest1()
        {
            UploadPage.UploadFile();
            var result = UploadPage.IsFileUploaded();
            Assert.That(result, Is.True);
        }

        [Test]
        [Description("Download file test")]
        public void UploadPageTest2()
        {
            UploadPage.DeleteFile();

            UploadPage.DownloadFile();
            BasePage.Refresh();

            var result = UploadPage.IsFileDownloaded();
            Assert.That(result, Is.True);
        }
    }
}
