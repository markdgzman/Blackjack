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
        List<Card> discard = new List<Card>();
            
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

        public void showDiscard()
        {
            foreach(Card a in discard)
            {
                a.print();
            }
        }

        public int deal()
        {
            Card a = cardDeck[0];
            discard.Add(a);
            cardDeck.RemoveAt(0);
            a.print();
            return a.getValue();
        }

        //Add 10 to discard pile
        public void cut()
        {
            cardDeck.RemoveRange(0, 10);
        }

        public void showCard(Card a)
        {
            a.print();
        }

        
        //Fisher Yates algorithm for shuffling
        public void shuffle()
        {
            Random rndmCard = new Random();

            for(int i = 0; i < cardDeck.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Card swapCard;
                    int random = rndmCard.Next(cardDeck.Count);

                    //assign temp card to the card at index i
                    swapCard = cardDeck[i];
                    //assign card at index to the value of the random card
                    cardDeck[i] = cardDeck[random];
                    //assign initial card at index to the random slot
                    cardDeck[random] = swapCard;
                }
            }

        }
    }
}
