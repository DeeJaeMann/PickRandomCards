using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
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
            throw new NotImplementedException();
        }

        private static string RandomValue()
        {
            throw new NotImplementedException();
        }
    }
}
