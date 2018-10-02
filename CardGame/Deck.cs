using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        Card[] cards = new Card[76];

        public Deck()
        {
            for (int i = 0; i < 10; i++)
            {
                cards[i] = new Card("Red", i);
                cards[i + 9] = new Card("Red", i);

                cards[i + 19] = new Card("Blue", i);
                cards[i + 28] = new Card("Blue", i);

                cards[i + 38] = new Card("Green", i);
                cards[i + 47] = new Card("Green", i);

                cards[i + 57] = new Card("Yellow", i);
                cards[i + 66] = new Card("Yellow", i);
            }

            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i]);
            }
        }
    }
}
