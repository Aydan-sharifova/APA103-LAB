namespace Kurs.Models
{
    public class Student : Base
    {
        public int GroupNumber { get; set; }
        public double Score { get; set; }

        public Student(string username, string firstname, string lastname, string email)
        {
            UserName = username;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }
        public Student()
        {
            
        }
        public int GetGroup()
        {
            return GroupNumber;
        }

        public string GetStudent()
        {
            return FirstName + " " + LastName + " - " + Email;
        }
    }
}