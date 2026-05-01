namespace Lesson
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("Enter the last number:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int result = SumOfSquare(num);

            //Console.WriteLine("1-den n-e qeder ededlerin kvadratlari cemi: " + result);

            //int[] arr = {2,4,7,1,9,6,18,19,28,20,39,37,25,40,45,49,50 };
            //int sum = SumOfComposite(arr);

            //Console.WriteLine("Mürəkkəb ədədlərin cəmi: " + sum);
            //Console.WriteLine(FindMinIndex(5, 9, 2, 67, 18, 56, 37, 1, 9));

            //Console.WriteLine("Enter the word:");
            //string word = Console.ReadLine();

            //Console.WriteLine(FindSpecLetters(word));


        }
        public static int SumOfSquare(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        public static bool IsComposite(int num)
        {
            if (num < 2)
                return false;

            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            return count > 2;
        }

        public static int SumOfComposite(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsComposite(arr[i]))
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        public static int FindMinIndex(params int[] numbers)
        {
            int minIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;

        }


        public static int FindSpecLetters(string word)
        {
            int count = 0;
            char[] letters = { 'ə', 'ü', 'ö', 'i', 'e', 'a', 'o', 'u', 'ı' };
            word = word.ToLower();

            foreach (char c in word)
            {
                foreach (char l in letters)
                {
                    if (c == l)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

