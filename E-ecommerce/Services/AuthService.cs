using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ecommerce.Services
{
    internal class AuthService
    {
        private Dictionary<string, string> _loggedUsers = new Dictionary<string, string>();

        public string Login(string username)
        {
            string token = Guid.NewGuid().ToString();
            _loggedUsers[token] = username;

            Console.WriteLine($"{username} ugurla login oldu.");
            Console.WriteLine($"Token: {token}");

            return token;
        }

        public void Logout(string token)
        {
            if (_loggedUsers.ContainsKey(token))
            {
                string username = _loggedUsers[token];
                _loggedUsers.Remove(token);
                Console.WriteLine($"{username} logout oldu ve dictionary-den silindi.");
            }
            else
            {
                Console.WriteLine("Token tapilmadi.");
            }
        }

        public void ShowLoggedUsers()
        {
            Console.WriteLine("=== Login olan userler ===");

            if (_loggedUsers.Count == 0)
            {
                Console.WriteLine("Hech kim login olmayib.");
                return;
            }

            foreach (var item in _loggedUsers)
            {
                Console.WriteLine($"Token: {item.Key} - Username: {item.Value}");
            }
        }
    }
}
