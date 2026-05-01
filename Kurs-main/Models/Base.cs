namespace Kurs.Models
{
    public class Base
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string GetName()
        {
            return UserName + " " + FirstName + " " + LastName;
        }

        public string GetEmail()
        {
            return Email;
        }
        public Base()
        {
            
        }
        public DateOnly GetBirthDate()
        {
            return BirthDate;
        }

        public string GetContact()
        {
            return PhoneNumber + " - " + Email;
        }
    }
}