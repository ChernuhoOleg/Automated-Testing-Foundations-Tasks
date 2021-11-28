using System;

namespace tsk2
{
    class Program
    {
        static char[] alphabet = { '0','1', '2', '3', '4', '5', '6', '7', '8', '9',
                         'A', 'B', 'C', 'D', 'E', 'F','G','H','I','J'};
        const int minNumericBase = 2;
        const int maxNumericBase = 20;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter a numeric base(a number from {minNumericBase} to {maxNumericBase})");
                int numericBase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entered number in the new system");
                Console.WriteLine(NumberInNewSystem(number, numericBase));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine( ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// This method converts a 10 base number to a new base
        /// </summary>
        public static string NumberInNewSystem(int value, int newBase)
        {
            string result = string.Empty;
            if (newBase < minNumericBase || newBase > maxNumericBase)
            {
                throw new System.Exception($"Numeric base should be an integer number between {minNumericBase} and {maxNumericBase}");
            }

            do
            {
                result = alphabet[value % newBase] + result;
                value /= newBase;
            }
            while (value > 0);

            return result;
        }

    }
    }

