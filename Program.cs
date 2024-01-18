

namespace Mission2
{
    public class Program
    {
        private static void Main(string[] args)
        {

            //GETTING THE USER INPUT FOR NUMBER OF ROLLS
            System.Console.WriteLine("Welcome to the dice throwing simulator!");
            System.Console.WriteLine("How many dice rolls would you like to simulate?");

            //CONVERTING USER INPUT FROM STRING TO INTEGER
            int numRolls = Convert.ToInt32(System.Console.ReadLine());

            //CREATING A THROWING DICE OBJECT AND PLACING IT IN AN ARRAY OF RESULTS
            ThrowingDice td = new ThrowingDice();
            int[] results = td.SimulateThrowingDice(numRolls);

            //MAKING THE HISTOGRAM
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine($"Total number of rolls = {numRolls}.");

            //ITERATING THROUGH THE RESULTS ARRAY AND CREATING PERCENTAGES
            for (int i = 0; i < 11; i++)
            {
                int percentage = results[i] * 100 / numRolls;
                Console.WriteLine($"{i + 2}: {new string('*', percentage)}");
            }

            //GOODBYE PHRASE
            Console.WriteLine("Thanks for playing!");
        }

    }
}


