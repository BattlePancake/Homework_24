using Homework_24.WebElements;
using OpenQA.Selenium;

namespace Homework_24.Pages.Lesson
{
    internal class UploadPage : BasePage
    {
        private static Element _uploadButton = new Element(By.XPath("//*[@id='uploadFile']"));
        private static Element _downloadButton = new Element(By.XPath("//*[@id='downloadButton']"));

        public static void UploadFile() => _uploadButton.SendValue(Directory.GetCurrentDirectory() + "/TestFile22.png");

        public static bool IsFileUploaded() => new Element(By.XPath("//*[@id='uploadedFilePath']")).GetElementText().Contains("TestFile22");

        public static void DownloadFile() => _downloadButton.ClickElement();

        public static bool IsFileDownloaded() => File.Exists("C:\\Users\\Uladzislau\\Downloads\\sampleFile.jpeg");

        public static void DeleteFile() => File.Delete("C:\\Users\\Uladzislau\\Downloads\\sampleFile.jpeg");
    }
}
