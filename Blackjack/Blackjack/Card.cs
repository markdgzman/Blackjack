using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        enum faceCard
        {
            Ace,
            King,
            Queen,
            Jack
        };

        //0 club, 1 spade, 2 heart, 3 diamonds
        private int suit { get; set; }
        private int value { get; set; }

        public Card (int s, int v)
        {
            suit = s;
            value = v;
        }

        public int getValue()
        {
            return value;
        }

        public void print()
        {
            if(value > 10)
            {
                switch(value)
                {
                    case 14:
                        Console.Write(faceCard.Ace + " of ");
                        break;
                    case 13:
                        Console.Write(faceCard.King + " of ");
                        break;
                    case 12:
                        Console.Write(faceCard.Queen + " of ");
                        break;
                    case 11:
                        Console.Write(faceCard.Jack + " of ");
                        break;
                }
            }
            else
            Console.Write(value + " of ");
            
            switch (suit)
            {
                case 1:
                    Console.WriteLine("Clubs");
                    break;
                case 2:
                    Console.WriteLine("Hearts");
                    break;
                case 3:
                    Console.WriteLine("Diamonds");
                    break;
                default:
                    Console.WriteLine("Spades");
                    break;
            }
            
        }
    }
}
