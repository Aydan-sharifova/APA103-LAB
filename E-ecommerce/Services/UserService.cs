using E_ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ecommerce.Services
{
    internal class UserService
    {
        private List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User(1, "Aysel", "aysel@gmail.com", "12345", true),
                new User(2, "Murad", "murad@gmail.com", "12345", false),
                new User(3, "Lale", "lale@gmail.com", "12345", true),
                new User(4, "Samir", "samir@gmail.com", "12345", true),
                new User(5, "Nigar", "aysel@gmail.com", "12345", false), 
                new User(6, "Elvin", "elvin@gmail.com", "12345", true)
            };
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public void ShowActiveUsers()
        {
            var activeUsers = _users.Where(u => u.IsActive);

            Console.WriteLine("Active users");
            foreach (var user in activeUsers)
            {
                Console.WriteLine(user);
            }
        }

        public void ShowDuplicateEmails()
        {
            var duplicateEmails = _users
                .GroupBy(u => u.Email)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            Console.WriteLine("Duplicate emails");

            if (!duplicateEmails.Any())
            {
                Console.WriteLine("Duplicate email doesn't found.");
                return;
            }

            foreach (var email in duplicateEmails)
            {
                Console.WriteLine(email);
            }
        }

        public User Login(string usernameOrEmail, string password)
        {
            return _users.FirstOrDefault(u =>
                (u.Name.Equals(usernameOrEmail, StringComparison.OrdinalIgnoreCase) ||
                 u.Email.Equals(usernameOrEmail, StringComparison.OrdinalIgnoreCase)) &&
                 u.Password == password &&
                 u.IsActive);
        }
    }
}
