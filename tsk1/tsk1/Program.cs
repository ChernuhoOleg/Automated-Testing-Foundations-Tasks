using System;

namespace tsk1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                string line = args[0];
                int answer = NotMatchingSymblos(line);
                Console.WriteLine(answer);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// This method returns the biggest amount of symbols that don't match, before a symbol matches itself
        /// </summary>
        static int NotMatchingSymblos(string line)
        {
            int biggestAmount = 0;
            int currentAmount = 0;
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] != line[i + 1])
                {
                    biggestAmount++;
                }
                if(biggestAmount > currentAmount)
                {
                    currentAmount = biggestAmount;
                    biggestAmount = 0;
                }
                else
                {
                    biggestAmount = 0;
                }                 
            }
            if (biggestAmount > currentAmount)
            { 
                currentAmount = biggestAmount;
            }

            return currentAmount;
            
        }
    }
}
