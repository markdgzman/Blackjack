using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck : List<Card>
    {
        public static int club = 0;
        public static int spade = 1;
        public static int heart = 2;
        public static int diamonds = 3;

        List<Card> cardDeck = new List <Card>();

        Card twoClub = new Card(club, 2);
        Card twoSpade = new Card(spade, 2);
        Card twoHeart = new Card(heart, 2);
        Card twoDiamonds = new Card(diamonds, 2);
        
        
        public void createDeck()
        {
            //2 card with suit
            /*
            cardDeck.Add(twoClub);
            cardDeck.Add(twoSpade);
            cardDeck.Add(twoHeart);
            cardDeck.Add(twoDiamonds);*/

            Card objectC;
            for(int i = 2; i < 10; i++)
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
