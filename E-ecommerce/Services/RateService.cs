using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ecommerce.Services
{
   internal class RateService
    {
        private Dictionary<string, int> _userLimits = new Dictionary<string, int>();

        public void AddUser(string username, int limit)
        {
            _userLimits[username] = limit;
            Console.WriteLine($"{username} ucun limit {limit} olaraq teyin edildi.");
        }

        public void SendRequest(string username)
        {
            if (!_userLimits.ContainsKey(username))
            {
                Console.WriteLine($"{username} sistemde yoxdur.");
                return;
            }

            if (_userLimits[username] <= 0)
            {
                Console.WriteLine($"{username} daha artiq sorgu gondere bilmez. Limit bitib.");
                return;
            }

            _userLimits[username]--;
            Console.WriteLine($"{username} request gonderdi. Qalan limit: {_userLimits[username]}");
        }

        public void ShowLimits()
        {
            Console.WriteLine("=== User limitleri ===");
            foreach (var item in _userLimits)
            {
                Console.WriteLine($"Username: {item.Key}, Limit: {item.Value}");
            }
        }
    }
}

