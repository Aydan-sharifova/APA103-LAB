using E_ecommerce.Services;

namespace E_ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            OrderService orderService = new OrderService();
            AuthService authService = new AuthService();
            RateService rateLimitService = new RateService();

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Aktiv userleri goster");
                Console.WriteLine("2. Duplicate emailleri goster");
                Console.WriteLine("3. Butun sifarislerin umumi meblegini goster");
                Console.WriteLine("4. User-in umumi sifaris meblegini goster");
                Console.WriteLine("5. En cox sifaris verilen producti tap");
                Console.WriteLine("6. Son 3 gunde verilen sifarisleri goster");
                Console.WriteLine("7. Shipped sifarisleri goster");
                Console.WriteLine("8. Login et");
                Console.WriteLine("9. Logout et");
                Console.WriteLine("10. Login olan userleri goster");
                Console.WriteLine("11. Rate limit user elave et");
                Console.WriteLine("12. Request gonder");
                Console.WriteLine("13. Limitleri goster");
                Console.WriteLine("0. Exit");

                Console.Write("Secim edin: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        userService.ShowActiveUsers();
                        break;

                    case "2":
                        userService.ShowDuplicateEmails();
                        break;

                    case "3":
                        orderService.ShowTotalAmount();
                        break;

                    case "4":
                        Console.Write("User Id daxil et: ");
                        int userId = int.Parse(Console.ReadLine());
                        orderService.ShowUserTotalAmount(userId);
                        break;

                    case "5":
                        orderService.ShowMostOrderedProduct();
                        break;

                    case "6":
                        orderService.ShowOrdersLast3Days();
                        break;

                    case "7":
                        orderService.ShowShippedOrders();
                        break;

                    case "8":
                        Console.Write("Username daxil et: ");
                        string username = Console.ReadLine();
                        authService.Login(username);
                        break;

                    case "9":
                        Console.Write("Token daxil et: ");
                        string token = Console.ReadLine();
                        authService.Logout(token);
                        break;

                    case "10":
                        authService.ShowLoggedUsers();
                        break;

                    case "11":
                        Console.Write("Username daxil et: ");
                        string rateUser = Console.ReadLine();
                        Console.Write("Limit daxil et: ");
                        int limit = int.Parse(Console.ReadLine());
                        rateLimitService.AddUser(rateUser, limit);
                        break;

                    case "12":
                        Console.Write("Username daxil et: ");
                        string requestUser = Console.ReadLine();
                        rateLimitService.SendRequest(requestUser);
                        break;

                    case "13":
                        rateLimitService.ShowLimits();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Yanlis secim.");
                        break;
                }
            }
        }
    }
}
