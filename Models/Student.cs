namespace Homework_24.Models
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public string Mobile { get; set; }
        public string Date { get; set; }
        public string Subjects { get; set; }
        public int Hobbies { get; set; }
        public string Upload { get; set; }
        public string Address { get; set; }

        public Student(string firstName, string lastName, string email, int gender, string mobile, string date, string subjects, int hobbies, string upload, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            Mobile = mobile;
            Date = date;
            Subjects = subjects;
            Hobbies = hobbies;
            Upload = upload;
            Address = address;
        }
    }
}
