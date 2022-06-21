using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_Card_WPF
{
    class CardPicker
    {
        static Random random = new Random();

        public static string[] PickCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomSuit() + " " + RandomValue();
            }
            return pickedCards;
        }
        private static string RandomValue()
        {
            int value =random.Next(1,14);
            if (value == 1)
                return "As";
            if (value == 11)
                return "Vale";
            if (value == 12)
                return "Kız";
            if (value == 13)
                return "Papaz";
            return value.ToString();
        }
        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1)
                return "Maça";
            if (value == 2)
                return "Kupa";
            if (value == 3)
                return "Sinek";
            return "Karo";
        }
    }
}
