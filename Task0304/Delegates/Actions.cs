using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0304.Delegates
{
    internal class Actions
    {
        private int[] numbers = { 2, 3, 10, 14, 32, 14, 45, 32, 45, 67, 88, 12, 10 };

       
        public Action SayHello => () =>
        {
            Console.WriteLine("Salam, APA103!");
        };

        public Action<string> SayHappyBirthday => (name) =>
        {
            Console.WriteLine($"Happy Birthday, {name}");
        };

        
        public Func<int> GetMax => () =>
        {
            return numbers.Max();
        };

       
        public Predicate<int> IsExistInArray => (value) =>
        {
            return numbers.Contains(value);
        };

        
        public Predicate<int> IsPalindrome => (number) =>
        {
            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            return original == reversed;
        };

       
        public Func<int, int> Cube => (number) =>
        {
            return number * number * number;
        };

      
        public Func<int, int, int, double> AverageOfThreeNumbers => (a, b, c) =>
        {
            return (a + b + c) / 3.0;
        };
    }
}
