using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        //0 club, 1 spade, 2 heart, 3 diamonds
        private int suit { get; set; }
        private int value { get; set; }

        public Card (int s, int v)
        {
            suit = s;
            value = v;
        }

        public void print()
        {
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
