using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            String commands = "Show: Display cards in the deck\r\n"
                            + "Shuffle: Shuffle the deck\r\n"
                            + "Size: Returns how many cards are left in the deck\r\n"
                            + "Hit: Shows top card in the deck and moves to discard pile\r\n"
                            + "Cut: Moves top 10 cards to the discard pile\r\n"
                            + "Discard: Displays cards in discard pile\r\n"
                            + "Commands: Displays list of commands\r\n";

            Deck black = new Deck();
            black.createDeck();


            String sentinel = " ";
            Console.WriteLine("Blackjack!\r\n");
            Console.WriteLine("Commands");
            Console.WriteLine(commands);
            Console.WriteLine("Type quit to stop playing");

            int userValue = 0;
            while(sentinel != "quit")
            {
                

                Console.Write("Enter Command:");
                sentinel = Console.ReadLine().ToLower();

                switch(sentinel)
                {
                    case "discard":
                        black.showDiscard();
                        break;
                    case "shuffle":
                        black.shuffle();
                        break;
                    case "show":
                        black.toString();
                        break;
                    case "size":
                        black.getSize();
                        break;
                    case "hit":
                        userValue = userValue + black.deal();
                        break;
                    case "cut":
                        black.cut();
                        break;
                    case "commands":
                        Console.WriteLine("\r\n" + commands);
                        break;
                    case "reset":
                        userValue = 0;
                        break;
                }

                Console.WriteLine("Value: " + userValue);
                if (userValue > 21)
                {
                    Console.WriteLine("You lose, over 21");
                    userValue = 0;
                }
                else if (userValue == 21)
                {
                    Console.WriteLine("You win, 21");
                }
                
            }

        }
    }
}
