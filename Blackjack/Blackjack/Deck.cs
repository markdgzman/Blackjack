using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        public static int club = 0;
        public static int spade = 1;
        public static int heart = 2;
        public static int diamonds = 3;

        //Create list data structure to hold the cards
        List<Card> cardDeck = new List <Card>();
            
        public void createDeck()
        {

            //Card object to create new cards
            Card objectC;
            for(int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                    cardDeck.Add(objectC = new Card(j, i));
            }
            
        }

        public void toString()
        {
            foreach(Card a in cardDeck)
            {
                a.print();
            }
        }
    }
}
