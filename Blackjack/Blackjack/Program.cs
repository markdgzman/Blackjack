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
            Deck black = new Deck();
            black.createDeck();


            String sentinel = " ";
            Console.WriteLine("Blackjack!");
            Console.WriteLine("Type quit to stop playing");
            
            while(sentinel != "quit")
            {
                Console.Write("Enter Command:");
                sentinel = Console.ReadLine();

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
                        black.deal();
                        break;
                    case "cut":
                        black.cut();
                        break;
                }
            }


            Console.Read();
        }
    }
}
