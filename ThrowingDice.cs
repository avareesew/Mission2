using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class ThrowingDice
    {
        //CREATE A RANDOM OBJECT
        private static Random random = new Random();

        //CREATE METHOD FOR SIMULATING DICE THROWS
        public int[] SimulateThrowingDice(int numRolls)
        {
            //CREATING AN EMPTY ARRAY(TO HOUSE DICE THROWS RESULTS/11 SLOTS FOR 2-12)
            int[] results = new int[11];

            //ROLL DICE FOR HOW MANY TIMES THE USER WANTED TO
            for (int i = 0; i < numRolls; i++)
            {
                //ROLL THE DIE (1-6 AS OPTIONS)
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                //ADD UP BOTH DICE
                int sum = dice1 + dice2;

                //ADD ONE TO THE NUMBER THAT WAS ROLLED IN THE ARRAY
                results[sum - 2]++;
            }

            //RETURN THE ARRAY OF RESULTS
            return results;
        }

    }
}
