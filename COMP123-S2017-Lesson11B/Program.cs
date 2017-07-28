using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 27, 2017
 * Description: This is demo for Lesson 11
 * Version: 0.5 - DealsFiveCards  method is tested
 */
namespace COMP123_S2017_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());

            //hand.Add(deck.Deal1());
            //Console.WriteLine(hand.ToString());
            //Console.WriteLine();
            //Console.WriteLine(deck.ToString());

            hand = deck.DealsFiveCards();
            hand.HighestCardsInHand(hand);
        }
    }
}
