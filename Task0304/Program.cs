using Task0304.Delegates;

namespace Task0304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();

            
            actions.SayHello();
            actions.SayHappyBirthday("Aydan");
            Console.WriteLine("Maksimal hedd: " + actions.GetMax());
            Console.WriteLine("32 movcuddurmu? " + actions.IsExistInArray(32));
            Console.WriteLine("99 movcuddurmu? " + actions.IsExistInArray(99));


            Console.WriteLine("121 palindrome-dir? " + actions.IsPalindrome(121));
            Console.WriteLine("123 palindrome-dir? " + actions.IsPalindrome(123));

            Console.WriteLine("4-un kubu: " + actions.Cube(4));

            Console.WriteLine("3, 6, 9 ededlerinin ortasi: " + actions.AverageOfThreeNumbers(3, 6, 9));
        }
    }
}
