using System.Reflection.Metadata.Ecma335;

namespace LogicalProgramme
{
    public class LogicalProblem
    {
        public static int Fibonacci(int n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
             }
            return c;
        }

        public static bool PrimeNumber(int number)
        {
            int count = 0;
            for (int i = 1; i <= number  ; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(number + " is a perfect number");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number");
                return false;
            }
            
        }
        public static bool PerfectNoProgramme(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is a perfect number");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number");
                return false;
            }
        }
        public static int Reversenumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum = sum * 10 + number % 10;
                number = number / 10;
            }
            return sum;
        }
    }
}
  
