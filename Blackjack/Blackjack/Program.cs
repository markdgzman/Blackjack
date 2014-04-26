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
            black.toString();
            black.getSize();

            black.shuffle();
            black.toString();
            Console.WriteLine();
            Console.WriteLine();

            String sentinel = " ";
            Console.WriteLine("Blackjack!");
            Console.WriteLine("Type quit to stop playing");
            
            while(sentinel != "quit")
            {
                Console.Write("Enter Command:");
                sentinel = Console.ReadLine();
                if (sentinel == "shuffle")
                    black.shuffle();
                else if (sentinel == "show")
                    black.toString();
                else if (sentinel == "size")
                    black.getSize();
                else if (sentinel == "hit")
                    black.deal();
                else if (sentinel == "cut")
                    black.cut();
                
            }


            Console.Read();
        }
    }
}
