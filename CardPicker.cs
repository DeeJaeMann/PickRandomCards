using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int index = 0; index < numberOfCards; index++)
            {
                pickedCards[index] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 5);
            /* assign suits based on number:
             * 1 - Spades
             * 2 - Hearts
             * 3 - Clubs
             * 4 - Diamonds
             */
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // get a random number from 1 to 13
            int value = random.Next(1, 14);
            /* If value matches numbers associated with face cards, return the face card value
             * 1 - Ace
             * 11 - Jack
             * 12 - Queen
             * 13 - King
             * Any other value is converted to string and returned
             */
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
