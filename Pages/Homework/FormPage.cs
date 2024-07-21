using System;
using Homework_24.Models;
using Homework_24.Pages.Lesson;
using Homework_24.WebElements;
using OpenQA.Selenium;

namespace Homework_24.Pages.Homework
{
    internal class FormPage : FormBasePage
    {
        private static Element _firstNameField => new(By.XPath("//*[@id='firstName']"));
        private static Element _lastNameField => new(By.XPath("//*[@id='lastName']"));
        private static Element _emailField => new(By.XPath("//*[@id='userEmail']"));
        private static Element _maleRadioButton => new(By.XPath("//*[@class='custom-control custom-radio custom-control-inline'][1]"));
        private static Element _femaleRadioButton => new(By.XPath("//*[@class='custom-control custom-radio custom-control-inline'][2]"));
        private static Element _otherButton => new(By.XPath("//*[@class='custom-control custom-radio custom-control-inline'][3]"));
        private static Element _mobileNumberField => new(By.XPath("//*[@id='userNumber']"));
        private static Element _dateField => new(By.XPath("//*[@id='dateOfBirthInput']"));
        //private static Element _subjectsField => new(By.XPath("//*[@id='subjectsContainer']"));
        private static Element _sportsHobbiesCheckbox => new(By.XPath("//*[@class='custom-control custom-checkbox custom-control-inline'][1]"));
        private static Element _readingHobbiesCheckbox => new(By.XPath("//*[@class='custom-control custom-checkbox custom-control-inline'][2]"));
        private static Element _musicHobbiesCheckbox => new(By.XPath("//*[@class='custom-control custom-checkbox custom-control-inline'][3]"));
        private static Element _uploadPicture => new(By.XPath("//*[@id='uploadPicture']"));
        private static Element _currentAddress => new(By.XPath("//*[@id='currentAddress']"));
        //private static Element _stateDropdown => new(By.XPath("//*[@id='state']"));
        //private static Element _cityDropdown => new(By.XPath("//*[@id='city']"));
        //private static Element _stateValueOne => new(By.XPath("//*[text()='NCR']"));
        //private static Element _cityValueOne => new(By.XPath("//*[text()='Delhi']"));
        private static Element _submitButton => new(By.XPath("//*[@id='submit']"));

        //
        private static Element _nameCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[1]/td[2]"));
        private static Element _emailCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[2]/td[2]"));
        private static Element _genderCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[3]/td[2]"));
        private static Element _mobileNumberCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[4]/td[2]"));
        private static Element _dateCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[5]/td[2]"));
        //private static Element _subjectsField => new(By.XPath("//*[@id='subjectsContainer']"));
        private static Element _hobbiesCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[7]/td[2]"));
        private static Element _uploadCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[8]/td[2]"));
        private static Element _addressCheck => new(By.XPath("//*[@class='table table-dark table-striped table-bordered table-hover']/tbody/tr[9]/td[2]"));
        //private static Element _stateAndCityCheck => new(By.XPath("//*[@id='state']"));


        public static void FillTheForm(Student student)
        {
            _firstNameField.SendValue(student.FirstName);
            _lastNameField.SendValue(student.LastName);
            _emailField.SendValue(student.Email);
            if(student.Gender == 1)
            {
                _maleRadioButton.ClickElement();
            }
            else if(student.Gender == 2)
            {
                _femaleRadioButton.ClickElement();
            }
            else
            {
                _otherButton.ClickElement();
            }
            _mobileNumberField.SendValue(student.Mobile);
            _dateField.ClearField1();
            _dateField.SendValue(student.Date);
            _dateField.ClearField2();
            //_subjectsField.SendValue(student.Subjects);
            if (student.Hobbies == 1)
            {
                _sportsHobbiesCheckbox.ClickElement();
            }
            else if (student.Hobbies == 2)
            {
                _readingHobbiesCheckbox.ClickElement();
            }
            else
            {
                _musicHobbiesCheckbox.ClickElement();
            }
            if (student.Upload == "TestFile24.png")
            {
                _uploadPicture.SendValue(Directory.GetCurrentDirectory() + "/TestFile24.png");
            }
            _currentAddress.SendValue(student.Address);
            _submitButton.ClickElement();
        }

        public static bool CheckForm(Student student)
        {
            if (_nameCheck.GetElementText().Contains(student.FirstName) 
                && _nameCheck.GetElementText().Contains(student.LastName)
                && _emailCheck.GetElementText().Contains(student.Email) 
                && _genderCheck.GetElementText().Contains("Male") 
                && _mobileNumberCheck.GetElementText().Contains(student.Mobile)
                && _dateCheck.GetElementText().Contains("12 December,2000")
                && _hobbiesCheck.GetElementText().Contains("Sports")
                && _uploadCheck.GetElementText().Contains(student.Upload)
                && _addressCheck.GetElementText().Contains(student.Address))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
