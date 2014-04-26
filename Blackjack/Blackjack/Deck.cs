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

        public void getSize()
        {
            Console.WriteLine(cardDeck.Count() + " Cards in the deck");
        }

        public void toString()
        {
            foreach(Card a in cardDeck)
            {
                a.print();
            }
        }

        public void deal()
        {
            Card a = cardDeck[0];
            cardDeck.RemoveAt(0);
            a.print();
        }

        public void cut()
        {
            cardDeck.RemoveRange(0, 10);
        }

        public void showCard(Card a)
        {
            a.print();
        }

        public void shuffle()
        {
            Random rndmCard = new Random();

            for(int i = 0; i < cardDeck.Count; i++)
            {

                Card swapCard;
                int random = rndmCard.Next(cardDeck.Count);

                Console.WriteLine(random);
                swapCard = cardDeck[i];
                cardDeck[random] = cardDeck[i];
                cardDeck[i] = swapCard;
            }

        }
    }
}
