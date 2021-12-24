using System;

namespace FirstTask
{
    public class Program
    {

        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 1)
                {
                    string line = args[0];
                    int answer = GetNotMatchingSymbols(line);
                    Console.WriteLine(answer);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            

        /// <summary>
        /// This method returns the biggest amount of symbols that don't match, before a symbol matches itself
        /// </summary>
        static int GetNotMatchingSymbols(string line)
        {
            int currentAmount = 1;
            int biggestAmount = 1;
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] != line[i + 1])
                {
                    currentAmount++;
                }
                else
                {
                    if (currentAmount > biggestAmount)
                    {
                        biggestAmount = currentAmount;
                    }
                    currentAmount = 1;
                }
            }
            if (currentAmount > biggestAmount)
            {
                biggestAmount = currentAmount;
            }

            return biggestAmount;
        }
    }
}
