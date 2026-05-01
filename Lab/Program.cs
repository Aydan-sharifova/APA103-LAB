using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Number1:");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //string[] students = CreateStudents();
            //ShowStudents(students);
            //Console.WriteLine("Enter Number2:");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int[] nums = [20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30];
            //GetBiggest(number1, number2);
            //DivededByTwo(number1);
            //CompareWithHunderd(number1);
            //UserAge(number1);
            //Console.WriteLine(CheckNumber(number1));
            //Console.WriteLine(GetWeekDay(number1)); 
            //Console.WriteLine(GetNumberCube(number1));
            //CheckMonth(number1);
            //ShowDivisibleByThree(nums);
            // EnterAndShowCountries();
            //ShowMaxMinAvarage(nums);
            //Console.WriteLine(IsPrime(number1));

            //Console.WriteLine("Enter first number:");
            //double num1 = Convert.ToDouble(Console.ReadLine());


            //Console.WriteLine("Enter operator:");
            //string act = Console.ReadLine();

            //Console.WriteLine("Enter second number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Calculator(num1, num2, act);
            //ApplyDiscount(100.0, 1300.50, 259.99, 430.30, 160.99, 320.0);
            //int[] ages = { 23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57 };
            //CheckRetirement(ages);

            //Console.Write("1-ci terefi daxil et: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2-ci terefi daxil et: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("3-cu terefi daxil et: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //FindTriangleType(a, b, c);
            //PlayGuessGame();
            //Console.WriteLine("Kvadratin sahesi: " + SquareArea(5));
            //Console.WriteLine("Duzbucaqli dordbucaqin sahesi: " + RectangleArea(4, 6));
            //Console.WriteLine("Ucbucagin sahesi: " + TriangleArea(8, 3));

            //Console.Write("Eded daxil et: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (IsPalindrome(number))
            //{
            //    Console.WriteLine("Bu eded palindromdur.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu eded palindrom deyil.");
            //}

            //Console.Write("1 ile 100 arasinda eded daxil et: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int result = CubeNumber(number);
            //Console.WriteLine("Kub: " + result);

            //Console.Write("Adi daxil et: ");
            //string name = Console.ReadLine();

            //Console.Write("Soyadi daxil et: ");
            //string surname = Console.ReadLine();

            //WelcomeUser(name, surname);

            //Console.Write("Bir soz daxil et: ");
            //string word = Console.ReadLine();

            //PrintWordLength(word);
            //Console.WriteLine("Sozu daxil et");
            //string secretWord = Console.ReadLine();
            //GuessWordGame(secretWord);
            //PrintDizNumbers();
            //CountDifferentNumbers(10, 12, 22, 10, 32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15);

            //Console.WriteLine("Enter number 1:");
            //Console.WriteLine("Enter number 2:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //SwapNumbers(ref num1, ref num2);
            //int number1 = 5;
            //ChangeNumber(ref number1);
            //ChangeNumberOut(out int result);

            //int min, max;
            //FindMinMax(10, 5, 20, out min, out max);
            //Console.WriteLine($"Min: {min}, Max: {max}");

            //Console.WriteLine("Enter student's score");
            //int score = Convert.ToInt32(Console.ReadLine());
            //IncreaseScore(ref score);

            //Console.Write("Enter name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //IsAdult(name, age, out bool isAdult);

            //Console.WriteLine($"User: {name}");
            //Console.WriteLine($"Is this user adult? {isAdult}");
            //Console.WriteLine("Enter price:");
            //double price = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter discount percent:");
            //double discountPercent = Convert.ToDouble(Console.ReadLine());

            //DiscountedPrice(price, discountPercent, out double discountedPrice);

            //Console.WriteLine("Discounted price: " + discountedPrice);
        }

        public static void DiscountedPrice(double price, double discountPercent, out double discountedPrice)
        {
            discountedPrice = price * (1 - discountPercent / 100);
        }

        public static void IsAdult(string name, int age, out bool isAdult)
        {
            isAdult = age >= 18;
        }
        public static void IncreaseScore(ref int score)
        {
                score += 10;
            Console.WriteLine(score);
        }
        public static void FindMinMax(int a,int b,int c, out int min, out int max)
        {   
            min = a;
            max = a;

            if (b < min) min = b;
            if (c < min) min = c;

            if (b > max) max = b;
            if (c > max) max = c;
        }

        public static void ChangeNumberOut(out int result)
        {
            int number1 = 20;
            result = number1 + 10;
            Console.WriteLine(result);
        }



        public static void SwapNumbers(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Number1: {num1}, Number2: {num2}");
        }
        public static void ChangeNumber(ref int number1)
        {
            number1 += 10;
        }                           

        public static void CountDifferentNumbers(params int[] numbers)
        {
            int differentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    differentCount++;
                }
            }

            Console.WriteLine("Ferqli ededlerin sayi: " + differentCount);
        }
        public static void PrintDizNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && i % 10 == 7)
                {
                    Console.WriteLine("DIZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void GuessWordGame(string secretWord)
        {
            

            Console.WriteLine("Oyun qaydalari:");
            Console.WriteLine("1. Senin 3 sansin var.");
            Console.WriteLine("2. Verilen ipucuna gore sozu tapmalisan.");
            Console.WriteLine("3. Bu soz bir meyvedir.");
            Console.WriteLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"{i}. cehd: ");
                string userWord = Console.ReadLine().ToLower();

                if (userWord == secretWord)
                {
                    Console.WriteLine("Tebrikler, duz tapdin!");
                    return;
                }
                else
                {
                    Console.WriteLine("Yanlis cavab.");
                  
                }
            }

           Console.WriteLine("Sanslar bitdi.");
        }
        public static void PrintWordLength(string word)
        {
            Console.WriteLine($"{word} - {word.Length}");
        }
        public static void WelcomeUser(string name, string surname)
        {
            string result = string.Concat("Welcome, ", name, " ", surname);
            Console.WriteLine(result);
        }
        
        public static void GetBiggest(int number1, int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine("Number1 is greater than Number2");

            }
            else
            {
                Console.WriteLine("Number2 is greater than Number1");
            }
        }

        public static void DivededByTwo(int number1)
        {
            if (number1 % 2 == 0)
            {
                Console.WriteLine("This number is divided 2");
            }
            else
            {
                Console.WriteLine("This number isn't divided 2");
            }
        }

        public static void CompareWithHunderd(int number1)
        {
            if (number1 >= 100)
            {
                Console.WriteLine("This number is greater than 100");
            }
            else
            {
                Console.WriteLine("This number is smaller than 100");
            }
        }

        public static void UserAge(int number1)
        {
            if (number1 > 18)
            {
                Console.WriteLine("This user is adult");
            }
            else
            {
                Console.WriteLine("This user isn't adult");
            }
        }

        public static string CheckNumber(int number1)
        {
            if (number1 > 0)
            {
                return "This number is positive";

            }
            else if (number1 < 0)
            {
                return "This number is negative";


            }
            return "This number is 0.";


        }

        public static string GetWeekDay(int number1)
        {
            switch (number1)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Please enter valid daytime";

            }
        }

        public static double GetNumberCube(int number1)
        {
            double result = Math.Pow(number1, 3);
            return result;
        }

        public static void CheckMonth(int number1)
        {
            switch (number1)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("This month has 31 days");
                    break;

                case 2:
                    Console.WriteLine("This month has 28 or 29 days");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month has 30 days");
                    break;

                default:
                    Console.WriteLine("Please enter a valid month");
                    break;
            }
        }


        public static string[] CreateStudents()
        {
            string[] students = new string[10];
            int i = 0;

            while (i < students.Length)
            {
                Console.Write($"{i + 1}. telebenin adini daxil et: ");
                students[i] = Console.ReadLine();
                i++;
            }

            return students;
        }

        public static void ShowStudents(string[] students)
        {
            int i = 0;
            Console.WriteLine("\nTelebelerin adlari:");

            while (i < students.Length)
            {
                Console.WriteLine(students[i]);
                i++;
            }
        }


        public static void ShowDivisibleByThree(int[] nums)
        {
            Console.WriteLine("\nNumbers divisible by 3:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }



        }

        public static void EnterAndShowCountries()
        {
            Console.WriteLine("\nHow many countries have you visited?");
            int count = Convert.ToInt32(Console.ReadLine());

            string[] travels = new string[count];

            for (int i = 0; i < travels.Length; i++)
            {
                Console.Write($"Enter country {i + 1}: ");
                travels[i] = Console.ReadLine();
            }

            Console.WriteLine("\nTraveled countries:");
            foreach (string country in travels)
            {
                Console.WriteLine(country);
            }
        }

        public static void ShowMaxMinAvarage(int[] nums)
        {

            int max = nums.Max();
            int min = nums.Min();
            double average = nums.Average();

            Console.WriteLine("\nMax: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Average: " + average);
        }

        public static bool IsPrime(int number1)
        {
            if (number1 <= 1)
                return false;

            for (int i = 2; i <= number1 / 2; i++)
            {
                if (number1 % i == 0)
                {
                    return false;
                }
            }

            return true;
                
        }


        public static void Calculator(double num1,double num2,string act)
        {

            

            double result = 0;

            if (num2 == 0)
            {
                Console.WriteLine("Cannot be divided by 0");
            }
            else
            {
                switch (act)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        result = num1 / num2;
                        break;

                    case "%":
                        result = num1 % num2;
                        break;

                    case "**":
                        result = Math.Pow(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        return;
                    
                }

                Console.WriteLine("Result: " + result);
            }
        }

        public static void ApplyDiscount(params double[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                double discountedPrice = prices[i] * 0.8;
                Console.WriteLine($"Esas qiymet: {prices[i]}, Endirimli qiymet: {discountedPrice:F2}");
            }
        }

        public static void CheckRetirement(int[] ages)
        {
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] >= 65)
                {
                    Console.WriteLine($"{ages[i]} yasinda olan isci teqaude ayrilmalidir.");
                }
            }
        }

        public static void FindTriangleType(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Bu tereflerle ucbucaq qurmaq olmur.");
                return;
            }

            if (a == b && b == c)
            {
                Console.WriteLine("Bu, beraberterefli ucbucaqdir.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Bu, beraberyanli ucbucaqdir.");
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Bu, duzbucaqli ucbucaqdir.");
            }
            else
            {
                Console.WriteLine("Bu, muxtelifterefli ucbucaqdir.");
            }
        }

        public static void PlayGuessGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}. cehd - Ededi daxil et: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You Won");
                    return;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Daha boyuk eded daxil et.");
                }
                else
                {
                    Console.WriteLine("Daha kicik eded daxil et.");
                }
            }

            Console.WriteLine("Game over");
        }

        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectangleArea(double width, double length)
        {
            return width * length;
        }

        public static double TriangleArea(double baseSide, double height)
        {
            return 0.5 * baseSide * height;
        }

        public static bool IsPalindrome(int number)
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
        }

        public static int CubeNumber(int number)
        {
            if (number >= 1 && number <= 100)
            {
                return number * number * number;
            }
            else
            {
                Console.WriteLine("Eded 1 ile 100 arasynda olmalidir.");
                return 0;
            }
        }

    }
}
